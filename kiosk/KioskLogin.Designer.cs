namespace Kiosk_Sum
{
    partial class KioskLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KioskLogin));
            poisonTabControl1 = new ReaLTaiizor.Controls.PoisonTabControl();
            tabPage1 = new TabPage();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox5 = new PictureBox();
            btn_Log_In = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            tabPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            poisonTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // poisonTabControl1
            // 
            poisonTabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            poisonTabControl1.Controls.Add(tabPage1);
            poisonTabControl1.Controls.Add(tabPage2);
            poisonTabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            poisonTabControl1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            poisonTabControl1.FontSize = ReaLTaiizor.Extension.Poison.PoisonTabControlSize.Tall;
            poisonTabControl1.FontWeight = ReaLTaiizor.Extension.Poison.PoisonTabControlWeight.Bold;
            poisonTabControl1.ItemSize = new Size(960, 34);
            poisonTabControl1.Location = new Point(-4, 95);
            poisonTabControl1.Margin = new Padding(0);
            poisonTabControl1.Name = "poisonTabControl1";
            poisonTabControl1.Padding = new Point(6, 8);
            poisonTabControl1.SelectedIndex = 0;
            poisonTabControl1.Size = new Size(1936, 995);
            poisonTabControl1.SizeMode = TabSizeMode.Fixed;
            poisonTabControl1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Orange;
            poisonTabControl1.TabIndex = 0;
            poisonTabControl1.TextAlign = ContentAlignment.MiddleCenter;
            poisonTabControl1.UseCustomBackColor = true;
            poisonTabControl1.UseCustomForeColor = true;
            poisonTabControl1.UseSelectable = true;
            poisonTabControl1.UseStyleColors = true;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(64, 64, 64);
            tabPage1.Controls.Add(bigLabel1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(pictureBox5);
            tabPage1.Controls.Add(btn_Log_In);
            tabPage1.Controls.Add(pictureBox4);
            tabPage1.Controls.Add(pictureBox3);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Cursor = Cursors.Hand;
            tabPage1.Location = new Point(4, 38);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1928, 953);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "회원";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.FromArgb(70, 69, 74);
            bigLabel1.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(871, 167);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(178, 42);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "회원 로그인";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(29, 33, 36);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(857, 508);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "패스워드";
            textBox2.Size = new Size(266, 39);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(29, 33, 36);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(857, 387);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "아이디";
            textBox1.Size = new Size(266, 39);
            textBox1.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(49, 47, 53);
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(892, 225);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(156, 136);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // btn_Log_In
            // 
            btn_Log_In.BackgroundImage = Properties.Resources.화면_캡처_2026_03_10_153956;
            btn_Log_In.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Log_In.FlatAppearance.BorderSize = 0;
            btn_Log_In.FlatStyle = FlatStyle.Flat;
            btn_Log_In.Location = new Point(857, 592);
            btn_Log_In.Name = "btn_Log_In";
            btn_Log_In.Size = new Size(209, 74);
            btn_Log_In.TabIndex = 3;
            btn_Log_In.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(46, 46, 60);
            pictureBox4.Image = Properties.Resources.화면_캡처_2026_03_10_154032;
            pictureBox4.Location = new Point(786, 486);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(349, 66);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(46, 46, 60);
            pictureBox3.Image = Properties.Resources.화면_캡처_2026_03_10_154155;
            pictureBox3.Location = new Point(786, 367);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(349, 66);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.로그인창_Photoroom4;
            pictureBox2.Location = new Point(713, 148);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(493, 594);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(64, 64, 64);
            tabPage2.Cursor = Cursors.Hand;
            tabPage2.Location = new Point(4, 38);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1928, 953);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "비회원";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(960, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Home;
            pictureBox6.Location = new Point(1830, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(70, 63);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            // 
            // KioskLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox1);
            Controls.Add(poisonTabControl1);
            Name = "KioskLogin";
            Size = new Size(1920, 1080);
            poisonTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonTabControl poisonTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private Button btn_Log_In;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox6;
    }
}
