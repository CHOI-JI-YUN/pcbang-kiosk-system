using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tcp_chat; // Checksum 클래스 참조

namespace Tcp_chat
{
    public class TcpClientService
    {
        private static TcpClientService _instance;
        public static TcpClientService Instance
        {
            get { if (_instance == null) _instance = new TcpClientService(); return _instance; }
        }
        private TcpClientService() { }

        public string ServerIp { get; set; } = "192.168.0.6";
        public string CurrentUserId { get; set; }
        public string CurrentUserName { get; set; }
        public int CurrentRemainTime { get; set; }
        public int CurrentSeatNumber { get; set; }
        public bool IsLoggedIn { get; private set; }

        private TcpClient _client9000;
        private StreamReader _reader9000;
        private StreamWriter _writer9000;
        private readonly SemaphoreSlim _lock9000 = new SemaphoreSlim(1, 1);
        private bool _connected9000;

        public event Action<string> OnLogMessage;
        private void Log(string msg) { OnLogMessage?.Invoke("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + msg); }

        // ═══════════════════════════════════════
        //  9000 연결/해제
        // ═══════════════════════════════════════
        public async Task<bool> Connect9000Async()
        {
            if (_connected9000) return true;
            try
            {
                _client9000 = new TcpClient();
                await _client9000.ConnectAsync(ServerIp, 9000);
                var ns = _client9000.GetStream();
                _reader9000 = new StreamReader(ns, Encoding.UTF8);
                _writer9000 = new StreamWriter(ns, Encoding.UTF8) { AutoFlush = true };
                _connected9000 = true;
                Log("[9000] 연결 성공");
                return true;
            }
            catch (Exception ex) { Log("[9000] 연결 실패: " + ex.Message); _connected9000 = false; return false; }
        }

        public void Disconnect9000()
        {
            _connected9000 = false;
            try { _writer9000?.Dispose(); } catch { }
            try { _reader9000?.Dispose(); } catch { }
            try { _client9000?.Close(); } catch { }
        }

        // ── 9000 송수신 (체크섬 포장) ──
        private async Task<string> Send9000(string body)
        {
            if (!_connected9000) { bool ok = await Connect9000Async(); if (!ok) return null; }
            await _lock9000.WaitAsync();
            try
            {
                await _writer9000.WriteLineAsync(Checksum.Wrap(body));
                Log("[9000 송신] " + body);

                string line = await _reader9000.ReadLineAsync();
                string res = Checksum.Unwrap(line);
                if (res == null) { Log("[9000] ✕ 응답 체크섬 실패"); return null; }
                Log("[9000 수신] ✓ " + res);
                return res;
            }
            catch (Exception ex) { Log("[9000 오류] " + ex.Message); _connected9000 = false; return null; }
            finally { _lock9000.Release(); }
        }

        // ═══════════════════════════════════════
        //  회원가입
        // ═══════════════════════════════════════
        public async Task<RegisterResult> RegisterAsync(string name, string id, string pw, string birth, string phone)
        {
            string res = await Send9000("REGISTER|" + name + "|" + id + "|" + pw + "|" + birth + "|" + phone + "|손님");
            if (res == null) return new RegisterResult(false, "서버 연결 실패");
            if (res == "REGISTER_OK") return new RegisterResult(true, "회원가입 성공");
            if (res.StartsWith("REGISTER_FAIL|")) return new RegisterResult(false, res.Substring(14));
            return new RegisterResult(false, "알 수 없는 응답");
        }

        // ═══════════════════════════════════════
        //  로그인
        // ═══════════════════════════════════════
        public async Task<LoginResult> LoginAsync(string id, string pw)
        {
            string res = await Send9000("LOGIN|" + id + "|" + pw);
            if (res == null) return new LoginResult(false, "서버 연결 실패", "", 0, 0);
            if (res.StartsWith("LOGIN_OK|"))
            {
                string[] p = res.Split('|');
                if (p.Length >= 4)
                {
                    string name = p[1]; int time; int.TryParse(p[2], out time); int seat; int.TryParse(p[3], out seat);
                    CurrentUserId = id; CurrentUserName = name; CurrentRemainTime = time; CurrentSeatNumber = seat; IsLoggedIn = true;
                    return new LoginResult(true, "로그인 성공", name, time, seat);
                }
            }
            if (res.StartsWith("LOGIN_FAIL|")) return new LoginResult(false, res.Substring(11), "", 0, 0);
            return new LoginResult(false, "알 수 없는 응답", "", 0, 0);
        }

        // ═══════════════════════════════════════
        //  남은시간
        // ═══════════════════════════════════════
        public async Task<int> RequestRemainTimeAsync()
        {
            if (!IsLoggedIn) return 0;
            string res = await Send9000("TIME_REQ|" + CurrentUserId);
            if (res != null && res.StartsWith("TIME_RES|"))
            { int v; if (int.TryParse(res.Substring(9), out v)) { CurrentRemainTime = v; return v; } }
            return 0;
        }

        // ═══════════════════════════════════════
        //  로그아웃
        // ═══════════════════════════════════════
        public async Task<bool> LogoutAsync()
        {
            if (!IsLoggedIn) return false;
            // ★ 남은시간도 함께 전송 → 서버가 DB에 저장
            string res = await Send9000("LOGOUT|" + CurrentUserId + "|" + CurrentRemainTime);
            IsLoggedIn = false; CurrentUserId = null; CurrentUserName = null; CurrentRemainTime = 0; CurrentSeatNumber = 0;
            return res != null;
        }

        // ═══════════════════════════════════════
        //  9001 주문 (연결→전송→응답→끊기)
        // ═══════════════════════════════════════
        public async Task<OrderResult> SendOrderAsync(string items, int totalPrice)
        {
            if (!IsLoggedIn) return new OrderResult(false, "로그인 필요", 0);
            TcpClient c = null; StreamReader r = null; StreamWriter w = null;
            try
            {
                c = new TcpClient(); await c.ConnectAsync(ServerIp, 9001);
                var ns = c.GetStream(); r = new StreamReader(ns, Encoding.UTF8); w = new StreamWriter(ns, Encoding.UTF8) { AutoFlush = true };

                string body = "ORDER|" + CurrentUserId + "|" + items + "|" + totalPrice;
                await w.WriteLineAsync(Checksum.Wrap(body));
                Log("[9001 송신] " + body);

                string line = await r.ReadLineAsync();
                string res = Checksum.Unwrap(line);
                if (res == null) return new OrderResult(false, "응답 데이터 손상", 0);
                Log("[9001 수신] ✓ " + res);

                if (res.StartsWith("ORDER_OK|")) { int oid; int.TryParse(res.Substring(9), out oid); return new OrderResult(true, "주문 성공", oid); }
                if (res.StartsWith("ORDER_FAIL|")) return new OrderResult(false, res.Substring(11), 0);
                return new OrderResult(false, "알 수 없는 응답", 0);
            }
            catch (Exception ex) { Log("[9001 오류] " + ex.Message); return new OrderResult(false, "서버 연결 실패", 0); }
            finally { try { r?.Dispose(); } catch { } try { w?.Dispose(); } catch { } try { c?.Close(); } catch { } }
        }

        // ═══════════════════════════════════════
        //  채팅 전송 (이용자 → 관리자)
        //  → CHAT|userId|message
        //  ← CHAT_OK
        // ═══════════════════════════════════════
        public async Task<bool> SendChatAsync(string message)
        {
            if (!IsLoggedIn || string.IsNullOrEmpty(CurrentUserId)) return false;
            string res = await Send9000("CHAT|" + CurrentUserId + "|" + message);
            return res != null && res == "CHAT_OK";
        }

        // ═══════════════════════════════════════
        //  채팅 수신 (관리자 → 이용자)
        //  → CHAT_POLL|userId
        //  ← CHAT_REPLY|msg / CHAT_EMPTY
        // ═══════════════════════════════════════
        public async Task<string> PollChatAsync()
        {
            if (!IsLoggedIn || string.IsNullOrEmpty(CurrentUserId)) return null;
            string res = await Send9000("CHAT_POLL|" + CurrentUserId);
            if (res != null && res.StartsWith("CHAT_REPLY|"))
            {
                return res.Substring(11); // "|" 이후의 메시지 내용 반환
            }
            return null; // CHAT_EMPTY 또는 오류
        }

        public void Shutdown() { Disconnect9000(); }
    }

    public class RegisterResult { public bool Success; public string Message; public RegisterResult(bool s, string m) { Success = s; Message = m; } }
    public class LoginResult
    {
        public bool Success; public string Message; public string Name; public int RemainTime; public int SeatNumber;
        public LoginResult(bool s, string m, string n, int t, int seat) { Success = s; Message = m; Name = n; RemainTime = t; SeatNumber = seat; }
    }
    public class OrderResult { public bool Success; public string Message; public int OrderId; public OrderResult(bool s, string m, int id) { Success = s; Message = m; OrderId = id; } }
}