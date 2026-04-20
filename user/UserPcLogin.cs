using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tcp_chat
{
    public partial class UserPcLogin : UserControl
    {
        // ── 회원가입 패널 컨트롤 ──
        private Panel pnlRegister;
        private TextBox txtRegName, txtRegBirth, txtRegId, txtRegPw, txtRegPhone;

        public UserPcLogin()
        {
            InitializeComponent();
            InitRegisterPanel();

            // 로그인 버튼 이벤트
            btnLogin.Click += btnLogin_Click;

            tbPw.KeyDown += tbPw_KeyDown;
        }

        // ═══════════════════════════════════════════════
        //  로그인 버튼
        //  → 9000 포트: LOGIN|아이디|비밀번호
        //  ← 9000 포트: LOGIN_OK|이름|남은시간|좌석번호
        // ═══════════════════════════════════════════════

        private void tbPw_KeyDown(object sender, KeyEventArgs e)//로그인 엔터키
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 엔터키를 눌렀을 때 로그인 버튼 클릭 이벤트를 강제로 발생시킴
                btnLogin_Click(btnLogin, EventArgs.Empty);

                // 엔터 입력 시 '띵' 하는 경고음 방지
                e.SuppressKeyPress = true;
            }
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string id = tbId.Text.Trim();
            string pw = tbPw.Text.Trim();

            if (id.Length == 0 || pw.Length == 0)
            {
                MessageBox.Show("아이디와 비밀번호를 입력해주세요.", "로그인");
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "연결 중...";

            try
            {
                LoginResult result = await TcpClientService.Instance.LoginAsync(id, pw);

                if (result.Success)
                {
                    MessageBox.Show(
                        "로그인 성공!\n" +
                        "이름: " + result.Name + "\n" +
                        "남은시간: " + FormatTime(result.RemainTime) + "\n" +
                        "좌석번호: " + result.SeatNumber,
                        "로그인 성공");

                    // UserPcMain으로 전환
                    Form parentForm = this.FindForm();
                    if (parentForm != null)
                    {
                        parentForm.Controls.Clear();
                        UserPcMain main = new UserPcMain();
                        main.Dock = DockStyle.Fill;
                        parentForm.Controls.Add(main);
                    }
                }
                else
                {
                    MessageBox.Show("로그인 실패: " + result.Message, "로그인 실패");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류: " + ex.Message, "오류");
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "로그인";
            }
        }

        // ═══════════════════════════════════════════════
        //  회원가입 패널
        // ═══════════════════════════════════════════════
        private void InitRegisterPanel()
        {
            pnlRegister = new Panel();
            pnlRegister.Size = new Size(350, 400);
            pnlRegister.Location = new Point((this.Width - 350) / 2, (this.Height - 400) / 2);
            pnlRegister.BackColor = Color.White;
            pnlRegister.BorderStyle = BorderStyle.FixedSingle;
            pnlRegister.Visible = false;

            Label lblTitle = new Label();
            lblTitle.Text = "회원가입";
            lblTitle.Font = new Font("맑은 고딕", 14, FontStyle.Bold);
            lblTitle.Location = new Point(120, 15);
            lblTitle.AutoSize = true;

            Label lblName = new Label() { Text = "이름", Location = new Point(30, 60), AutoSize = true };
            txtRegName = new TextBox() { Location = new Point(120, 57), Width = 180 };

            Label lblBirth = new Label() { Text = "생년월일", Location = new Point(30, 100), AutoSize = true };
            txtRegBirth = new TextBox() { Location = new Point(120, 97), Width = 180, PlaceholderText = "YYYY-MM-DD" };

            Label lblId = new Label() { Text = "아이디", Location = new Point(30, 140), AutoSize = true };
            txtRegId = new TextBox() { Location = new Point(120, 137), Width = 180 };

            Label lblPw = new Label() { Text = "패스워드", Location = new Point(30, 180), AutoSize = true };
            txtRegPw = new TextBox() { Location = new Point(120, 177), Width = 180, PasswordChar = '*' };

            Label lblPhone = new Label() { Text = "전화번호", Location = new Point(30, 220), AutoSize = true };
            txtRegPhone = new TextBox() { Location = new Point(120, 217), Width = 180, PlaceholderText = "010-0000-0000" };

            Button btnConfirm = new Button() { Text = "가입완료", Location = new Point(80, 310), Size = new Size(80, 30) };
            btnConfirm.Click += btnRegisterConfirm_Click;

            Button btnCancel = new Button() { Text = "취소", Location = new Point(180, 310), Size = new Size(80, 30) };
            btnCancel.Click += (s, ev) => { ClearRegisterFields(); pnlRegister.Visible = false; };

            pnlRegister.Controls.AddRange(new Control[] {
                lblTitle, lblName, txtRegName, lblBirth, txtRegBirth,
                lblId, txtRegId, lblPw, txtRegPw, lblPhone, txtRegPhone,
                btnConfirm, btnCancel
            });

            this.Controls.Add(pnlRegister);
            pnlRegister.BringToFront();
        }

        // ── 회원가입 완료 ──
        // → 9000 포트: REGISTER|이름|아이디|비번|생년월일|전화번호|손님
        // ← 9000 포트: REGISTER_OK / REGISTER_FAIL|사유
        private async void btnRegisterConfirm_Click(object sender, EventArgs e)
        {
            string name = txtRegName.Text.Trim();
            string id = txtRegId.Text.Trim();
            string pw = txtRegPw.Text.Trim();
            string birth = txtRegBirth.Text.Trim();
            string phone = txtRegPhone.Text.Trim();

            if (name.Length == 0 || id.Length == 0 || pw.Length == 0)
            {
                MessageBox.Show("이름, 아이디, 패스워드는 필수입니다.", "회원가입");
                return;
            }

            try
            {
                RegisterResult result = await TcpClientService.Instance.RegisterAsync(name, id, pw, birth, phone);

                if (result.Success)
                {
                    MessageBox.Show("회원가입이 완료되었습니다!", "회원가입 성공");
                    ClearRegisterFields();
                    pnlRegister.Visible = false;
                }
                else
                {
                    MessageBox.Show("회원가입 실패: " + result.Message, "회원가입 실패");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류: " + ex.Message, "오류");
            }
        }

        // ── 회원가입 버튼 (패널 열기) ──
        private void button1_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = true;
            pnlRegister.BringToFront();
        }

        private void ClearRegisterFields()
        {
            txtRegName.Clear(); txtRegId.Clear(); txtRegPw.Clear();
            txtRegBirth.Clear(); txtRegPhone.Clear();
        }

        private string FormatTime(int sec)
        {
            int h = sec / 3600, m = (sec % 3600) / 60;
            return h.ToString("D2") + "시간 " + m.ToString("D2") + "분";
        }
    }
}