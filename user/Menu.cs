using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tcp_chat
{
    public partial class Menu : Form
    {
        // ── 관리자 서버 IP (환경에 맞게 수정) ──
        private const string ServerIp = "192.168.0.6";
        private const int OrderPort = 9001;

        private static int _nextOrderId = 200;

        public Menu()
        {
            InitializeComponent();

            // ★ 이벤트를 생성자에서 등록 (Menu_Load 실패해도 동작)
            button1.Click += btnOrder_Click;
            btnExit.Click += (s, ev) => this.Close();

            // 문의사항 placeholder
            textBox1.Text = "문의사항 입력해주세요.";
            textBox1.ForeColor = Color.Gray;
            textBox1.GotFocus += (s, ev) =>
            {
                if (textBox1.Text == "문의사항 입력해주세요.")
                { textBox1.Text = ""; textBox1.ForeColor = Color.Black; }
            };
            textBox1.LostFocus += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                { textBox1.Text = "문의사항 입력해주세요."; textBox1.ForeColor = Color.Gray; }
            };

            // ListView 더블클릭 삭제
            listView1.DoubleClick += (s, ev) =>
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    UpdateTotal();
                }
            };
        }

        // ───────────────────────────────────────
        // 폼 로드
        // ───────────────────────────────────────
        private void Menu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Maximized;
            

            try { SetupListView(); }
            catch (Exception ex) { MessageBox.Show("ListView 오류: " + ex.Message); }

            try { RegisterMenuButtons(); }
            catch (Exception ex) { MessageBox.Show("버튼 등록 오류: " + ex.Message); }

            try { LoadMenuImages(); }
            catch { }

            this.BeginInvoke(new Action(() =>
            {
                float scaleX = (float)this.ClientSize.Width / 1337f;
                float scaleY = (float)this.ClientSize.Height / 645f;
                this.AutoScaleMode = AutoScaleMode.None;
                this.Scale(new SizeF(scaleX, scaleY));
            }));
        }

        // ───────────────────────────────────────
        // ListView 초기 설정
        // ───────────────────────────────────────
        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Clear();
            listView1.Columns.Add("메뉴명", 110);
            listView1.Columns.Add("수량", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("단가", 60, HorizontalAlignment.Right);
            listView1.Columns.Add("소계", 70, HorizontalAlignment.Right);
        }

        // ───────────────────────────────────────
        // 메뉴 버튼 클릭 이벤트 자동 등록
        // ───────────────────────────────────────
        private void RegisterMenuButtons()
        {
            var categories = new (string prefix, int count)[]
            {
                ("Noodle", 17), ("Rice", 8), ("Instance", 8),
                ("Snack", 10), ("Drink", 16)
            };

            foreach (var (prefix, count) in categories)
            {
                for (int i = 1; i <= count; i++)
                {
                    try
                    {
                        Control[] btns = this.Controls.Find(prefix + i, true);
                        Control[] names = this.Controls.Find(prefix + "_name" + i, true);
                        Control[] prices = this.Controls.Find(prefix + "_price" + i, true);

                        if (btns.Length == 0 || names.Length == 0 || prices.Length == 0) continue;

                        System.Windows.Forms.Button btn = btns[0] as System.Windows.Forms.Button;
                        Label nameLabel = names[0] as Label;
                        Label priceLabel = prices[0] as Label;
                        if (btn == null || nameLabel == null || priceLabel == null) continue;

                        btn.Click += (s, ev) =>
                        {
                            string menuName = nameLabel.Text.Trim();
                            int price = ParsePrice(priceLabel.Text);
                            AddToCart(menuName, price);
                        };
                    }
                    catch { }
                }
            }
        }

        // ───────────────────────────────────────
        private int ParsePrice(string priceText)
        {
            string digits = "";
            foreach (char c in priceText)
                if (c >= '0' && c <= '9') digits += c;
            int price = 0;
            int.TryParse(digits, out price);
            return price;
        }

        // ───────────────────────────────────────
        private void AddToCart(string menuName, int price)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text == menuName)
                {
                    int qty = int.Parse(item.SubItems[1].Text) + 1;
                    item.SubItems[1].Text = qty.ToString();
                    item.SubItems[3].Text = (qty * price).ToString("N0") + "원";
                    UpdateTotal();
                    return;
                }
            }

            ListViewItem lvi = new ListViewItem(menuName);
            lvi.SubItems.Add("1");
            lvi.SubItems.Add(price.ToString("N0") + "원");
            lvi.SubItems.Add(price.ToString("N0") + "원");
            listView1.Items.Add(lvi);
            UpdateTotal();
        }

        // ───────────────────────────────────────
        private void UpdateTotal()
        {
            int total = 0;
            foreach (ListViewItem item in listView1.Items)
                total += ParsePrice(item.SubItems[3].Text);
            lbTotal.Text = total.ToString("N0") + "원";
        }

        // ───────────────────────────────────────
        // 주문하기 버튼 클릭
        // ───────────────────────────────────────
        private async void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.Items.Count == 0)
                {
                    MessageBox.Show("장바구니가 비어있습니다.", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<string> itemsList = new List<string>();
                int total = 0;

                foreach (ListViewItem item in listView1.Items)
                {
                    string name = item.Text;
                    int qty = int.Parse(item.SubItems[1].Text);
                    int subtotal = ParsePrice(item.SubItems[3].Text);
                    itemsList.Add(name + ":" + qty);
                    total += subtotal;
                }

                string items = string.Join(",", itemsList);
                int orderId = System.Threading.Interlocked.Increment(ref _nextOrderId);

                button1.Enabled = false;
                button1.Text = "전송 중...";

                bool success = await SendOrderAsync(orderId, items, total);

                button1.Enabled = true;
                button1.Text = "주문하기";

                if (success)
                {
                    MessageBox.Show(
                        "주문 완료!\n주문번호: " + orderId + "\n총액: " + total.ToString("N0") + "원",
                        "주문 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listView1.Items.Clear();
                    lbTotal.Text = "-";
                    textBox1.Text = "문의사항 입력해주세요.";
                    textBox1.ForeColor = Color.Gray;
                }
                else
                {
                    MessageBox.Show(
                        "주문 전송 실패!\nIP: " + ServerIp + " / Port: " + OrderPort,
                        "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                button1.Enabled = true;
                button1.Text = "주문하기";
                MessageBox.Show("오류: " + ex.Message);
            }
        }

        // ───────────────────────────────────────
        // TCP 주문 전송 (체크섬 적용)
        // 송신: Checksum.Wrap("ORDER|주문번호|내역|총액")
        // 수신: Checksum.Unwrap → "ACK|주문번호|OK"
        // ───────────────────────────────────────
        private async Task<bool> SendOrderAsync(int orderId, string items, int total)
        {
            TcpClient client = null;
            StreamReader reader = null;
            StreamWriter writer = null;

            try
            {
                client = new TcpClient();
                await client.ConnectAsync(ServerIp, OrderPort);

                var ns = client.GetStream();
                reader = new StreamReader(ns, Encoding.UTF8);
                writer = new StreamWriter(ns, Encoding.UTF8) { AutoFlush = true };

                // ★ 체크섬으로 감싸서 전송
                string body = "ORDER|" + orderId + "|" + items + "|" + total;
                await writer.WriteLineAsync(Checksum.Wrap(body));

                // ★ 체크섬 검증하며 수신
                var readTask = reader.ReadLineAsync();
                if (await Task.WhenAny(readTask, Task.Delay(5000)) == readTask)
                {
                    string raw = readTask.Result;
                    string response = Checksum.Unwrap(raw);

                    if (response != null && response.StartsWith("ACK|"))
                        return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                try { reader?.Dispose(); } catch { }
                try { writer?.Dispose(); } catch { }
                try { client?.Close(); } catch { }
            }
        }

        // ───────────────────────────────────────
        // Images 폴더에서 메뉴 이미지 로드
        // ───────────────────────────────────────
        private void LoadMenuImages()
        {
            string basePath = Path.Combine(Application.StartupPath, "Images");
            if (!Directory.Exists(basePath)) return;

            var imageMap = new Dictionary<string, string>
            {
                { "Noodle1",  "열라면.jpg" },       { "Noodle2",  "진라면(순한맛).jpg" },
                { "Noodle3",  "너구리.jpg" },       { "Noodle4",  "스낵면.jpg" },
                { "Noodle5",  "안성탕면.jpg" },     { "Noodle6",  "오징어 짬뽕.jpg" },
                { "Noodle7",  "진라면(매운맛).jpg" }, { "Noodle8",  "불닭볶음면.jpg" },
                { "Noodle9",  "짜파게티.jpg" },     { "Noodle10", "짜계치.jpg" },
                { "Noodle11", "참깨라면.jpg" },     { "Noodle12", "신라면.jpg" },
                { "Noodle13", "배홍동 칼빔면.jpg" },{ "Noodle14", "삼겹살 비빔면.jpg" },
                { "Noodle15", "신라면컵.jpg" },     { "Noodle16", "육개장컵.jpg" },
                { "Noodle17", "카구리.jpg" },
                { "Rice1", "김치볶음밥.jpg" },      { "Rice2", "돈까스.jpg" },
                { "Rice3", "스파게티.jpg" },        { "Rice4", "제육덮밥.jpg" },
                { "Rice5", "참치 마요 덮밥.jpg" },  { "Rice6", "치킨마요덮밥.jpg" },
                { "Rice7", "닭갈비볶음밥.jpg" },    { "Rice8", "쭈꾸미덮밥.jpg" },
                { "Instance1", "미스터리 박스.png" },{ "Instance2", "떡볶이.jpg" },
                { "Instance3", "크림치즈볼.jpg" },  { "Instance4", "회오리감자.jpg" },
                { "Instance5", "감자튀김.jpg" },    { "Instance6", "김말이.jpg" },
                { "Instance7", "타코야끼.jpg" },    { "Instance8", "냉모밀.jpg" },
                { "Snack1",  "만두.jpg" },          { "Snack2",  "소떡소떡.jpg" },
                { "Snack3",  "두쫀쿠.jpg" },       { "Snack4",  "수제 햄버거.jpg" },
                { "Snack5",  "파닭꼬치.jpg" },     { "Snack6",  "핫도그.jpeg" },
                { "Snack7",  "치즈스틱.jpg" },     { "Snack8",  "피까츄돈까스.jpg" },
                { "Snack9",  "쫄병 매콤한맛.jpg" },{ "Snack10", "숏다리.jpg" },
                { "Drink1",  "아이스아메리카노.jpg" },{ "Drink2",  "아이스바닐라라떼.jpg" },
                { "Drink3",  "카페라떼.jpg" },     { "Drink4",  "초코라떼.jpg" },
                { "Drink5",  "딸기라떼.jpg" },     { "Drink6",  "녹차라떼.jpg" },
                { "Drink7",  "수박스무디.jpg" },   { "Drink8",  "자두스무디.jpg" },
                { "Drink9",  "망고스무디.png" },   { "Drink10", "딸기스무디.jpg" },
                { "Drink11", "얼.박.사.jpg" },     { "Drink12", "다방커피.jpg" },
                { "Drink13", "몬스터.jpg" },       { "Drink14", "핫식스.jpg" },
                { "Drink15", "콜라.jpg" },         { "Drink16", "포카리.jpg" },
            };

            foreach (var pair in imageMap)
            {
                try
                {
                    string filePath = Path.Combine(basePath, pair.Value);
                    Control[] controls = this.Controls.Find(pair.Key, true);
                    if (controls.Length > 0 && controls[0] is System.Windows.Forms.Button btn && File.Exists(filePath))
                    {
                        byte[] bytes = File.ReadAllBytes(filePath);
                        using (MemoryStream ms = new MemoryStream(bytes))
                            btn.BackgroundImage = Image.FromStream(ms);
                    }
                }
                catch { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) // 선택된 게 있는지 먼저 확인
            {
                // 선택된 첫 번째 아이템을 삭제
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("삭제할 항목을 먼저 선택해주세요.");
            }
        }
    }
}
