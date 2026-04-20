using System;
using System.Diagnostics;   //링크연결
using System.Data.SqlTypes;
using System.Windows.Forms;
using Tcp_chat;  // ChatForm 참조



namespace Tcp_chat
{
    public partial class UserPcMain : UserControl
    {
        private System.Windows.Forms.Timer _timer;
        private int _remainSeconds;
        private int _syncCounter = 0;  // ★ 서버 동기화 카운터


        public UserPcMain()
        {
            InitializeComponent();
            this.Load += UserPcMain_Load;

            btnProduct.Click += btnProduct_Click;
            btnExit.Click += btnExit_Click;
            btnInquiry.Click += btnInquiry_Click;





        }


        private void UserPcMain_Load(object sender, EventArgs e)
        {
            var svc = TcpClientService.Instance;

            lbName2.Text = svc.CurrentUserName ?? "-";
            lbSeat2.Text = svc.CurrentSeatNumber > 0 ? svc.CurrentSeatNumber + "번" : "-";

            _remainSeconds = svc.CurrentRemainTime;
            UpdateTimeDisplay();

            // 1초마다 남은시간 감소
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_remainSeconds > 0)
            {
                _remainSeconds--;
                UpdateTimeDisplay();

                // ★ 30초마다 서버에서 남은시간 동기화 (키오스크 충전 반영)
                _syncCounter++;
                if (_syncCounter >= 30)
                {
                    _syncCounter = 0;
                    _ = RefreshTimeAsync();
                }
            }
            else
            {
                _timer.Stop();
                lbTime2.Text = "00:00:00";
                MessageBox.Show("이용 시간이 만료되었습니다.", "시간 만료");
            }
        }

        private void UpdateTimeDisplay()
        {
            int h = _remainSeconds / 3600;
            int m = (_remainSeconds % 3600) / 60;
            int s = _remainSeconds % 60;
            lbTime2.Text = h.ToString("D2") + ":" + m.ToString("D2") + ":" + s.ToString("D2");
        }

        // ── 음식주문 → Menu 폼 열기 (주문은 9001 포트) ──
        private void btnProduct_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();
            menuForm.ShowDialog();

            // 주문 후 남은시간 갱신
            _ = RefreshTimeAsync();
        }

        // ── ★ 문의 → ChatForm 열기 (관리자에게 채팅) ──
        private void btnInquiry_Click(object sender, EventArgs e)
        {
            ChatForm chatForm = new ChatForm();
            chatForm.ShowDialog();
        }

        // ── 종료(로그아웃) → LOGOUT|아이디|남은초 전송 ──
        private async void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            _timer?.Stop();

            // ★ 남은시간을 서비스에 저장 후 로그아웃 (서버가 DB에 반영)
            TcpClientService.Instance.CurrentRemainTime = _remainSeconds;
            await TcpClientService.Instance.LogoutAsync();

            // 로그인 화면으로 돌아가기
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Controls.Clear();
                UserPcLogin login = new UserPcLogin();
                login.Dock = DockStyle.Fill;
                parentForm.Controls.Add(login);
            }
        }

        private async System.Threading.Tasks.Task RefreshTimeAsync()
        {
            try
            {
                int serverRemain = await TcpClientService.Instance.RequestRemainTimeAsync();
                // ★ 서버 값이 로컬보다 크면 충전된 것 → 즉시 반영
                if (serverRemain > _remainSeconds)
                {
                    _remainSeconds = serverRemain;
                    UpdateTimeDisplay();
                }
            }
            catch { }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) { _timer?.Stop(); _timer?.Dispose(); }
            base.Dispose(disposing);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PC를 끄시고, 자리이동해주세요.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            // 오후 2:43 형식 (t는 오전/오후 표시)
            string timeStr = now.ToString("tt h:mm");

            // 2026-03-10 형식
            string dateStr = now.ToString("yyyy-MM-dd");

            // 라벨에 적용 (lblDateTime은 본인의 라벨 이름으로 바꾸세요)
            Time.Text = $"{timeStr}\n{dateStr}";
        }

        private void btnMouse_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("ms-settings:easeofaccess-mousepointer") { UseShellExecute = true });


        }

        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("ms-settings:typing") { UseShellExecute = true });
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("ms-settings:mouse") { UseShellExecute = true });
        }

        private void btnControllPanel_Click(object sender, EventArgs e)
        {
            Process.Start("control");
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            Process.Start("control", "mmsys.cpl");
        }


        private void btnSpeedGamel_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("ms-settings:gaming-gamemode") { UseShellExecute = true });

        }

        private void btnNight_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("ms-settings:nightlight") { UseShellExecute = true });
        }

        private void btnChromeicon_Click(object sender, EventArgs e)
        {
            string url = "https://www.google.com";

            try
            {
                // 기본 브라우저를 통해 URL 실행
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // 중요: .NET Core/5+ 버전에서는 true로 설정해야 함
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("링크를 열 수 없습니다: " + ex.Message);
            }
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            string url = "https://www.microsoft.com/ko-kr/edge/?form=MA13FJ";

            try
            {
                // 기본 브라우저를 통해 URL 실행
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // 중요: .NET Core/5+ 버전에서는 true로 설정해야 함
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("링크를 열 수 없습니다: " + ex.Message);
            }
        }

        private void btnLostArk_Click(object sender, EventArgs e)
        {
            string url = "https://lostark.game.onstove.com/Event/Package/260204";

            try
            {
                // 기본 브라우저를 통해 URL 실행
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // 중요: .NET Core/5+ 버전에서는 true로 설정해야 함
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("링크를 열 수 없습니다: " + ex.Message);
            }
        }

        private void btnMapple_Click(object sender, EventArgs e)
        {
            string url = "https://maplestory.nexon.com/Home/Main?utm_source=naver&utm_medium=search&utm_campaign=2602&utm_content=pcbrand_home";

            try
            {
                // 기본 브라우저를 통해 URL 실행
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // 중요: .NET Core/5+ 버전에서는 true로 설정해야 함
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("링크를 열 수 없습니다: " + ex.Message);
            }
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            string url = "https://www.pubg.com/ko/events/9th_anniversary";

            try
            {
                // 기본 브라우저를 통해 URL 실행
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // 중요: .NET Core/5+ 버전에서는 true로 설정해야 함
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("링크를 열 수 없습니다: " + ex.Message);
            }
        }

        private void btnFifa_Click(object sender, EventArgs e)
        {
            string url = "https://fconline.nexon.com/main/index";

            try
            {
                // 기본 브라우저를 통해 URL 실행
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // 중요: .NET Core/5+ 버전에서는 true로 설정해야 함
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("링크를 열 수 없습니다: " + ex.Message);
            }
        }

        private void btnSudden_Click(object sender, EventArgs e)
        {
            string url = "https://sa.nexon.com/main/index.aspx";

            try
            {
                // 기본 브라우저를 통해 URL 실행
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // 중요: .NET Core/5+ 버전에서는 true로 설정해야 함
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("링크를 열 수 없습니다: " + ex.Message);
            }
        }

        private void btnLeague_Click(object sender, EventArgs e)
        {
            string url = "https://www.leagueoflegends.com/ko-kr/";

            try
            {
                // 기본 브라우저를 통해 URL 실행
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // 중요: .NET Core/5+ 버전에서는 true로 설정해야 함
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("링크를 열 수 없습니다: " + ex.Message);
            }
        }

        private void btnOver_Click(object sender, EventArgs e)
        {
            string url = "https://overwatch.blizzard.com/ko-kr/";

            try
            {
                // 기본 브라우저를 통해 URL 실행
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // 중요: .NET Core/5+ 버전에서는 true로 설정해야 함
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("링크를 열 수 없습니다: " + ex.Message);
            }
        }

        private void btnSteam_Click(object sender, EventArgs e) //스팀런처
        {
            try
            {
                // 스팀 앱 자체를 실행
                Process.Start(new ProcessStartInfo
                {
                    FileName = "steam://open/main",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("스팀을 실행할 수 없습니다: " + ex.Message);
            }
        }

        private void btnOpgg_Click(object sender, EventArgs e) //op.gg
        {
            string url = "https://op.gg/";

            try
            {
                // 기본 브라우저를 통해 URL 실행
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // 중요: .NET Core/5+ 버전에서는 true로 설정해야 함
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("링크를 열 수 없습니다: " + ex.Message);
            }
        }

        private void btnChrome_Click(object sender, EventArgs e)    //chrome
        {
            string url = "https://www.google.com";

            try
            {
                // 기본 브라우저를 통해 URL 실행
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // 중요: .NET Core/5+ 버전에서는 true로 설정해야 함
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("링크를 열 수 없습니다: " + ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://www.msn.com/ko-kr/play/games/mazeancom/cg-9mwdvp3s5n6g?ocid=msedgntp&pc=U531&cvid=69b0081c4f4f4939a2db25ff37ba1c44&ei=17&cgfrom=cg_landing_home_shooter&cvpid=dd85a95307c445928e04ced87cf4f320";

            try
            {
                // 기본 브라우저를 통해 URL 실행
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // 중요: .NET Core/5+ 버전에서는 true로 설정해야 함
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("링크를 열 수 없습니다: " + ex.Message);
            }
        }
    }
    public class TransPanel : Panel     //판넬 투명하게 제작
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }


        protected override void OnPaintBackground(PaintEventArgs e) { }

        protected override void OnPaint(PaintEventArgs e)
        {
            // 1. 판넬의 반투명 배경 그리기 (투명도 100의 검은색)
            using (var brush = new SolidBrush(Color.FromArgb(100, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            // 2. 글자 직접 그리기 (라벨 없이 그림)
            string text = "로스트아크"; // 여기에 표시할 텍스트 입력

            // 안티앨리어싱 적용 (글자를 부드럽게)
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            using (Font font = new Font("맑은 고딕", 10, FontStyle.Bold))
            {
                // 글자 색상 (하얀색)
                e.Graphics.DrawString(text, font, Brushes.White, new PointF(35, 73)); // 위치 (5, 5)


   

                e.Graphics.DrawString("메이플스토리", font, Brushes.White, new PointF(210, 75));

                e.Graphics.DrawString("배틀그라운드", font, Brushes.White, new PointF(384, 75));

                e.Graphics.DrawString("피파온라인3", font, Brushes.White, new PointF(578, 75));

                e.Graphics.DrawString("서든어택", font, Brushes.White, new PointF(752, 75));

                e.Graphics.DrawString("리그오브레전드", font, Brushes.White, new PointF(910, 75));

                e.Graphics.DrawString("오버워치2", font, Brushes.White, new PointF(1091, 75));
            }
        }
    }
}