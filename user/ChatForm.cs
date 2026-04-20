using System;
using System.Drawing;
using System.Windows.Forms;
using Tcp_chat; // TcpClientService 참조

namespace Tcp_chat
{
    public class ChatForm : Form
    {
        private RichTextBox rtChat;
        private TextBox txtInput;
        private Button btnSend;
        private System.Windows.Forms.Timer pollTimer;

        public ChatForm()
        {
            this.Text = "문의하기";
            this.Size = new Size(420, 500);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // ── 채팅 표시 영역 ──
            rtChat = new RichTextBox();
            rtChat.Location = new Point(10, 10);
            rtChat.Size = new Size(385, 370);
            rtChat.ReadOnly = true;
            rtChat.BackColor = Color.White;
            rtChat.Font = new Font("맑은 고딕", 10);

            // ── 입력 영역 ──
            txtInput = new TextBox();
            txtInput.Location = new Point(10, 390);
            txtInput.Size = new Size(290, 30);
            txtInput.Font = new Font("맑은 고딕", 10);
            txtInput.KeyDown += (s, ev) =>
            {
                if (ev.KeyCode == Keys.Enter)
                {
                    ev.SuppressKeyPress = true;
                    SendMessage();
                }
            };

            // ── 보내기 버튼 ──
            btnSend = new Button();
            btnSend.Text = "보내기";
            btnSend.Location = new Point(310, 388);
            btnSend.Size = new Size(85, 32);
            btnSend.Font = new Font("맑은 고딕", 10, FontStyle.Bold);
            btnSend.Click += (s, ev) => SendMessage();

            this.Controls.Add(rtChat);
            this.Controls.Add(txtInput);
            this.Controls.Add(btnSend);

            // ── 1.5초마다 관리자 답장 확인 (폴링) ──
            pollTimer = new System.Windows.Forms.Timer();
            pollTimer.Interval = 1500;
            pollTimer.Tick += async (s, ev) =>
            {
                try
                {
                    string reply = await TcpClientService.Instance.PollChatAsync();
                    if (reply != null)
                        AppendChat("관리자", reply, Color.Blue);
                }
                catch { }
            };
            pollTimer.Start();

            this.FormClosing += (s, ev) => { pollTimer.Stop(); pollTimer.Dispose(); };
        }

        private async void SendMessage()
        {
            string msg = txtInput.Text.Trim();
            if (msg.Length == 0) return;

            txtInput.Clear();
            AppendChat("나", msg, Color.DarkGreen);

            bool ok = await TcpClientService.Instance.SendChatAsync(msg);
            if (!ok)
                AppendChat("시스템", "전송 실패", Color.Red);
        }

        private void InitializeComponent()
        {

        }

        private void AppendChat(string sender, string message, Color color)
        {
            string time = DateTime.Now.ToString("HH:mm");
            rtChat.SelectionStart = rtChat.TextLength;
            rtChat.SelectionColor = color;
            rtChat.AppendText("[" + time + "] " + sender + ": " + message + "\n");
            rtChat.SelectionColor = rtChat.ForeColor;
            rtChat.ScrollToCaret();
        }
    }
}