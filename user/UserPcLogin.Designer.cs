using System;
using System.Drawing;
using System.Windows.Forms;
namespace Tcp_chat
{
    partial class UserPcLogin
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPcLogin));
            tbPw = new TextBox();
            pictureBox1 = new PictureBox();
            btnLogin = new ReaLTaiizor.Controls.CyberButton();
            button1 = new ReaLTaiizor.Controls.CyberButton();
            pictureBox3 = new PictureBox();
            tbId = new TextBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // tbPw
            // 
            tbPw.BackColor = Color.FromArgb(29, 33, 36);
            tbPw.BorderStyle = BorderStyle.None;
            tbPw.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbPw.ForeColor = Color.White;
            tbPw.Location = new Point(937, 815);
            tbPw.Multiline = true;
            tbPw.Name = "tbPw";
            tbPw.PasswordChar = '*';
            tbPw.PlaceholderText = "패스워드";
            tbPw.Size = new Size(266, 31);
            tbPw.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 1080);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Alpha = 20;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.Background = true;
            btnLogin.Background_WidthPen = 4F;
            btnLogin.BackgroundPen = true;
            btnLogin.ColorBackground = Color.FromArgb(45, 45, 48);
            btnLogin.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnLogin.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnLogin.ColorBackground_Pen = SystemColors.Highlight;
            btnLogin.ColorLighting = Color.Silver;
            btnLogin.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnLogin.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnLogin.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnLogin.Effect_1 = true;
            btnLogin.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnLogin.Effect_1_Transparency = 25;
            btnLogin.Effect_2 = true;
            btnLogin.Effect_2_ColorBackground = SystemColors.Highlight;
            btnLogin.Effect_2_Transparency = 20;
            btnLogin.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Lighting = false;
            btnLogin.LinearGradient_Background = false;
            btnLogin.LinearGradientPen = false;
            btnLogin.Location = new Point(1272, 728);
            btnLogin.Name = "btnLogin";
            btnLogin.PenWidth = 15;
            btnLogin.Rounding = true;
            btnLogin.RoundingInt = 70;
            btnLogin.Size = new Size(130, 50);
            btnLogin.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnLogin.TabIndex = 3;
            btnLogin.TabStop = false;
            btnLogin.Tag = "Cyber";
            btnLogin.TextButton = "로그인";
            btnLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnLogin.Timer_Effect_1 = 5;
            btnLogin.Timer_RGB = 300;
            // 
            // button1
            // 
            button1.Alpha = 20;
            button1.BackColor = Color.Transparent;
            button1.Background = true;
            button1.Background_WidthPen = 4F;
            button1.BackgroundPen = true;
            button1.ColorBackground = Color.FromArgb(45, 45, 48);
            button1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            button1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            button1.ColorBackground_Pen = SystemColors.Highlight;
            button1.ColorLighting = Color.Silver;
            button1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            button1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            button1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            button1.Effect_1 = true;
            button1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            button1.Effect_1_Transparency = 25;
            button1.Effect_2 = true;
            button1.Effect_2_ColorBackground = Color.White;
            button1.Effect_2_Transparency = 20;
            button1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Lighting = false;
            button1.LinearGradient_Background = false;
            button1.LinearGradientPen = false;
            button1.Location = new Point(1272, 793);
            button1.Name = "button1";
            button1.PenWidth = 15;
            button1.Rounding = true;
            button1.RoundingInt = 70;
            button1.Size = new Size(130, 50);
            button1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            button1.TabIndex = 4;
            button1.TabStop = false;
            button1.Tag = "Cyber";
            button1.TextButton = "회원가입";
            button1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            button1.Timer_Effect_1 = 5;
            button1.Timer_RGB = 300;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(46, 46, 60);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(884, 719);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(349, 66);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // tbId
            // 
            tbId.BackColor = Color.FromArgb(29, 33, 36);
            tbId.BorderStyle = BorderStyle.None;
            tbId.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbId.ForeColor = Color.White;
            tbId.Location = new Point(937, 740);
            tbId.Multiline = true;
            tbId.Name = "tbId";
            tbId.PlaceholderText = "아이디";
            tbId.Size = new Size(266, 39);
            tbId.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(46, 46, 60);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(884, 791);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(349, 66);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // UserPcLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(tbPw);
            Controls.Add(tbId);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "UserPcLogin";
            Size = new Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbPw;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.CyberButton btnLogin;
        private ReaLTaiizor.Controls.CyberButton button1;
        private PictureBox pictureBox3;
        private TextBox tbId;
        private PictureBox pictureBox4;
    }
}
