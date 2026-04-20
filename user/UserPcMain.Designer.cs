using System;
using System.Drawing;
using System.Windows.Forms;
namespace Tcp_chat
{
    partial class UserPcMain
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPcMain));
            panel1 = new Panel();
            lbSeat2 = new Label();
            lbSeat1 = new Label();
            lbName2 = new Label();
            lbName1 = new Label();
            lbTime2 = new Label();
            lbTime1 = new Label();
            btnInquiry = new Button();
            btnExit = new Button();
            btnProduct = new ReaLTaiizor.Controls.CyberButton();
            btnMove = new Button();
            transPanel1 = new TransPanel();
            btnKeyboard = new Button();
            btnSound = new Button();
            btnNight = new Button();
            btnControllPanel = new Button();
            btnSpeedGamel = new Button();
            btnSelect = new Button();
            btnMouse = new Button();
            panel5 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnPop = new Button();
            btnOpgg = new Button();
            btnChrome = new Button();
            btnSteam = new Button();
            btnLostArk = new Button();
            btnMapple = new Button();
            btnBattle = new Button();
            btnFifa = new Button();
            btnSudden = new Button();
            btnLeague = new Button();
            btnOver = new Button();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            Time = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox3 = new PictureBox();
            btnChromeicon = new Button();
            btnEx = new Button();
            panel1.SuspendLayout();
            transPanel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbSeat2);
            panel1.Controls.Add(lbSeat1);
            panel1.Controls.Add(lbName2);
            panel1.Controls.Add(lbName1);
            panel1.Controls.Add(lbTime2);
            panel1.Controls.Add(lbTime1);
            panel1.Location = new Point(1560, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 155);
            panel1.TabIndex = 1;
            // 
            // lbSeat2
            // 
            lbSeat2.AutoSize = true;
            lbSeat2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSeat2.Location = new Point(94, 93);
            lbSeat2.Margin = new Padding(2, 0, 2, 0);
            lbSeat2.Name = "lbSeat2";
            lbSeat2.Size = new Size(17, 21);
            lbSeat2.TabIndex = 0;
            lbSeat2.Text = "-";
            // 
            // lbSeat1
            // 
            lbSeat1.AutoSize = true;
            lbSeat1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSeat1.Location = new Point(12, 93);
            lbSeat1.Margin = new Padding(2, 0, 2, 0);
            lbSeat1.Name = "lbSeat1";
            lbSeat1.Size = new Size(74, 21);
            lbSeat1.TabIndex = 0;
            lbSeat1.Text = "좌석번호";
            // 
            // lbName2
            // 
            lbName2.AutoSize = true;
            lbName2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbName2.Location = new Point(94, 57);
            lbName2.Margin = new Padding(2, 0, 2, 0);
            lbName2.Name = "lbName2";
            lbName2.Size = new Size(17, 21);
            lbName2.TabIndex = 0;
            lbName2.Text = "-";
            // 
            // lbName1
            // 
            lbName1.AutoSize = true;
            lbName1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbName1.Location = new Point(12, 57);
            lbName1.Margin = new Padding(2, 0, 2, 0);
            lbName1.Name = "lbName1";
            lbName1.Size = new Size(42, 21);
            lbName1.TabIndex = 0;
            lbName1.Text = "이름";
            // 
            // lbTime2
            // 
            lbTime2.AutoSize = true;
            lbTime2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTime2.Location = new Point(94, 11);
            lbTime2.Margin = new Padding(2, 0, 2, 0);
            lbTime2.Name = "lbTime2";
            lbTime2.Size = new Size(17, 21);
            lbTime2.TabIndex = 0;
            lbTime2.Text = "-";
            // 
            // lbTime1
            // 
            lbTime1.AutoSize = true;
            lbTime1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTime1.Location = new Point(12, 14);
            lbTime1.Margin = new Padding(2, 0, 2, 0);
            lbTime1.Name = "lbTime1";
            lbTime1.Size = new Size(42, 21);
            lbTime1.TabIndex = 0;
            lbTime1.Text = "시간";
            // 
            // btnInquiry
            // 
            btnInquiry.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnInquiry.Location = new Point(1682, 152);
            btnInquiry.Margin = new Padding(2);
            btnInquiry.Name = "btnInquiry";
            btnInquiry.Size = new Size(120, 34);
            btnInquiry.TabIndex = 2;
            btnInquiry.Text = "문의";
            btnInquiry.UseVisualStyleBackColor = true;
            btnInquiry.Click += btnInquiry_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(1801, 152);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(119, 34);
            btnExit.TabIndex = 2;
            btnExit.Text = "종료";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            btnProduct.Alpha = 20;
            btnProduct.BackColor = Color.Transparent;
            btnProduct.Background = true;
            btnProduct.Background_WidthPen = 4F;
            btnProduct.BackgroundPen = true;
            btnProduct.ColorBackground = Color.FromArgb(45, 45, 48);
            btnProduct.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnProduct.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnProduct.ColorBackground_Pen = SystemColors.ScrollBar;
            btnProduct.ColorLighting = Color.Silver;
            btnProduct.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnProduct.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnProduct.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnProduct.Effect_1 = true;
            btnProduct.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnProduct.Effect_1_Transparency = 25;
            btnProduct.Effect_2 = true;
            btnProduct.Effect_2_ColorBackground = Color.White;
            btnProduct.Effect_2_Transparency = 20;
            btnProduct.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnProduct.ForeColor = Color.White;
            btnProduct.Lighting = false;
            btnProduct.LinearGradient_Background = false;
            btnProduct.LinearGradientPen = false;
            btnProduct.Location = new Point(900, 0);
            btnProduct.Name = "btnProduct";
            btnProduct.PenWidth = 15;
            btnProduct.Rounding = true;
            btnProduct.RoundingInt = 70;
            btnProduct.Size = new Size(162, 63);
            btnProduct.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnProduct.TabIndex = 4;
            btnProduct.TabStop = false;
            btnProduct.Tag = "Cyber";
            btnProduct.TextButton = "음식주문";
            btnProduct.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnProduct.Timer_Effect_1 = 5;
            btnProduct.Timer_RGB = 300;
            // 
            // btnMove
            // 
            btnMove.Font = new Font("맑은 고딕", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMove.Location = new Point(1560, 152);
            btnMove.Margin = new Padding(2);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(124, 34);
            btnMove.TabIndex = 2;
            btnMove.Text = "자리이동";
            btnMove.UseVisualStyleBackColor = true;
            btnMove.Click += btnMove_Click;
            // 
            // transPanel1
            // 
            transPanel1.BackColor = Color.Transparent;
            transPanel1.Controls.Add(btnKeyboard);
            transPanel1.Controls.Add(btnSound);
            transPanel1.Controls.Add(btnNight);
            transPanel1.Controls.Add(btnControllPanel);
            transPanel1.Controls.Add(btnSpeedGamel);
            transPanel1.Controls.Add(btnSelect);
            transPanel1.Controls.Add(btnMouse);
            transPanel1.Controls.Add(panel5);
            transPanel1.Controls.Add(btnLostArk);
            transPanel1.Controls.Add(btnMapple);
            transPanel1.Controls.Add(btnBattle);
            transPanel1.Controls.Add(btnFifa);
            transPanel1.Controls.Add(btnSudden);
            transPanel1.Controls.Add(btnLeague);
            transPanel1.Controls.Add(btnOver);
            transPanel1.Controls.Add(pictureBox4);
            transPanel1.Location = new Point(349, 562);
            transPanel1.Name = "transPanel1";
            transPanel1.Size = new Size(1195, 461);
            transPanel1.TabIndex = 5;
            // 
            // btnKeyboard
            // 
            btnKeyboard.BackgroundImage = (Image)resources.GetObject("btnKeyboard.BackgroundImage");
            btnKeyboard.BackgroundImageLayout = ImageLayout.Stretch;
            btnKeyboard.Cursor = Cursors.Hand;
            btnKeyboard.FlatStyle = FlatStyle.Flat;
            btnKeyboard.Location = new Point(38, 384);
            btnKeyboard.Name = "btnKeyboard";
            btnKeyboard.Size = new Size(141, 53);
            btnKeyboard.TabIndex = 0;
            btnKeyboard.UseVisualStyleBackColor = true;
            btnKeyboard.Click += btnKeyboard_Click;
            // 
            // btnSound
            // 
            btnSound.BackgroundImage = (Image)resources.GetObject("btnSound.BackgroundImage");
            btnSound.BackgroundImageLayout = ImageLayout.Stretch;
            btnSound.Cursor = Cursors.Hand;
            btnSound.FlatStyle = FlatStyle.Flat;
            btnSound.Location = new Point(1045, 385);
            btnSound.Name = "btnSound";
            btnSound.Size = new Size(139, 52);
            btnSound.TabIndex = 0;
            btnSound.UseVisualStyleBackColor = true;
            btnSound.Click += btnSound_Click;
            // 
            // btnNight
            // 
            btnNight.BackgroundImage = (Image)resources.GetObject("btnNight.BackgroundImage");
            btnNight.BackgroundImageLayout = ImageLayout.Stretch;
            btnNight.Cursor = Cursors.Hand;
            btnNight.FlatStyle = FlatStyle.Flat;
            btnNight.Location = new Point(883, 385);
            btnNight.Name = "btnNight";
            btnNight.Size = new Size(141, 53);
            btnNight.TabIndex = 0;
            btnNight.UseVisualStyleBackColor = true;
            btnNight.Click += btnNight_Click;
            // 
            // btnControllPanel
            // 
            btnControllPanel.BackgroundImage = (Image)resources.GetObject("btnControllPanel.BackgroundImage");
            btnControllPanel.BackgroundImageLayout = ImageLayout.Stretch;
            btnControllPanel.Cursor = Cursors.Hand;
            btnControllPanel.FlatStyle = FlatStyle.Flat;
            btnControllPanel.Location = new Point(551, 385);
            btnControllPanel.Name = "btnControllPanel";
            btnControllPanel.Size = new Size(141, 53);
            btnControllPanel.TabIndex = 0;
            btnControllPanel.UseVisualStyleBackColor = true;
            btnControllPanel.Click += btnControllPanel_Click;
            // 
            // btnSpeedGamel
            // 
            btnSpeedGamel.BackgroundImage = (Image)resources.GetObject("btnSpeedGamel.BackgroundImage");
            btnSpeedGamel.BackgroundImageLayout = ImageLayout.Stretch;
            btnSpeedGamel.Cursor = Cursors.Hand;
            btnSpeedGamel.FlatStyle = FlatStyle.Flat;
            btnSpeedGamel.Location = new Point(717, 385);
            btnSpeedGamel.Name = "btnSpeedGamel";
            btnSpeedGamel.Size = new Size(141, 53);
            btnSpeedGamel.TabIndex = 0;
            btnSpeedGamel.UseVisualStyleBackColor = true;
            btnSpeedGamel.Click += btnSpeedGamel_Click;
            // 
            // btnSelect
            // 
            btnSelect.BackgroundImage = (Image)resources.GetObject("btnSelect.BackgroundImage");
            btnSelect.BackgroundImageLayout = ImageLayout.Stretch;
            btnSelect.Cursor = Cursors.Hand;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Location = new Point(377, 385);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(141, 53);
            btnSelect.TabIndex = 0;
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnMouse
            // 
            btnMouse.BackgroundImage = (Image)resources.GetObject("btnMouse.BackgroundImage");
            btnMouse.BackgroundImageLayout = ImageLayout.Stretch;
            btnMouse.Cursor = Cursors.Hand;
            btnMouse.FlatStyle = FlatStyle.Flat;
            btnMouse.Location = new Point(210, 385);
            btnMouse.Name = "btnMouse";
            btnMouse.Size = new Size(141, 53);
            btnMouse.TabIndex = 0;
            btnMouse.UseVisualStyleBackColor = true;
            btnMouse.Click += btnMouse_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button5);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(btnPop);
            panel5.Controls.Add(btnOpgg);
            panel5.Controls.Add(btnChrome);
            panel5.Controls.Add(btnSteam);
            panel5.Location = new Point(351, 97);
            panel5.Name = "panel5";
            panel5.Size = new Size(841, 282);
            panel5.TabIndex = 3;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(694, 0);
            button5.Name = "button5";
            button5.Size = new Size(148, 279);
            button5.TabIndex = 1;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(547, 0);
            button4.Name = "button4";
            button4.Size = new Size(148, 279);
            button4.TabIndex = 1;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(400, 0);
            button3.Name = "button3";
            button3.Size = new Size(148, 279);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(253, 0);
            button2.Name = "button2";
            button2.Size = new Size(148, 279);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // btnPop
            // 
            btnPop.BackgroundImage = (Image)resources.GetObject("btnPop.BackgroundImage");
            btnPop.BackgroundImageLayout = ImageLayout.Stretch;
            btnPop.Cursor = Cursors.Hand;
            btnPop.FlatStyle = FlatStyle.Flat;
            btnPop.Location = new Point(106, 0);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(148, 279);
            btnPop.TabIndex = 1;
            btnPop.UseVisualStyleBackColor = true;
            // 
            // btnOpgg
            // 
            btnOpgg.BackgroundImage = (Image)resources.GetObject("btnOpgg.BackgroundImage");
            btnOpgg.BackgroundImageLayout = ImageLayout.Stretch;
            btnOpgg.Cursor = Cursors.Hand;
            btnOpgg.FlatStyle = FlatStyle.Flat;
            btnOpgg.Location = new Point(0, 191);
            btnOpgg.Name = "btnOpgg";
            btnOpgg.Size = new Size(109, 90);
            btnOpgg.TabIndex = 0;
            btnOpgg.UseVisualStyleBackColor = true;
            btnOpgg.Click += btnOpgg_Click;
            // 
            // btnChrome
            // 
            btnChrome.BackgroundImage = (Image)resources.GetObject("btnChrome.BackgroundImage");
            btnChrome.BackgroundImageLayout = ImageLayout.Stretch;
            btnChrome.Cursor = Cursors.Hand;
            btnChrome.FlatStyle = FlatStyle.Flat;
            btnChrome.Location = new Point(0, 106);
            btnChrome.Name = "btnChrome";
            btnChrome.Size = new Size(109, 89);
            btnChrome.TabIndex = 0;
            btnChrome.UseVisualStyleBackColor = true;
            btnChrome.Click += btnChrome_Click;
            // 
            // btnSteam
            // 
            btnSteam.BackgroundImage = (Image)resources.GetObject("btnSteam.BackgroundImage");
            btnSteam.BackgroundImageLayout = ImageLayout.Stretch;
            btnSteam.Cursor = Cursors.Hand;
            btnSteam.FlatStyle = FlatStyle.Flat;
            btnSteam.Location = new Point(0, 0);
            btnSteam.Name = "btnSteam";
            btnSteam.Size = new Size(109, 108);
            btnSteam.TabIndex = 0;
            btnSteam.UseVisualStyleBackColor = true;
            btnSteam.Click += btnSteam_Click;
            // 
            // btnLostArk
            // 
            btnLostArk.BackgroundImage = (Image)resources.GetObject("btnLostArk.BackgroundImage");
            btnLostArk.BackgroundImageLayout = ImageLayout.Stretch;
            btnLostArk.Cursor = Cursors.Hand;
            btnLostArk.FlatAppearance.BorderSize = 0;
            btnLostArk.FlatStyle = FlatStyle.Flat;
            btnLostArk.Location = new Point(0, 0);
            btnLostArk.Name = "btnLostArk";
            btnLostArk.Size = new Size(133, 70);
            btnLostArk.TabIndex = 2;
            btnLostArk.UseVisualStyleBackColor = true;
            btnLostArk.Click += btnLostArk_Click;
            // 
            // btnMapple
            // 
            btnMapple.BackgroundImage = (Image)resources.GetObject("btnMapple.BackgroundImage");
            btnMapple.BackgroundImageLayout = ImageLayout.Stretch;
            btnMapple.Cursor = Cursors.Hand;
            btnMapple.FlatAppearance.BorderSize = 0;
            btnMapple.FlatStyle = FlatStyle.Flat;
            btnMapple.Location = new Point(183, 2);
            btnMapple.Name = "btnMapple";
            btnMapple.Size = new Size(133, 70);
            btnMapple.TabIndex = 2;
            btnMapple.UseVisualStyleBackColor = true;
            btnMapple.Click += btnMapple_Click;
            // 
            // btnBattle
            // 
            btnBattle.BackgroundImage = (Image)resources.GetObject("btnBattle.BackgroundImage");
            btnBattle.BackgroundImageLayout = ImageLayout.Stretch;
            btnBattle.Cursor = Cursors.Hand;
            btnBattle.FlatAppearance.BorderSize = 0;
            btnBattle.FlatStyle = FlatStyle.Flat;
            btnBattle.Location = new Point(360, 2);
            btnBattle.Name = "btnBattle";
            btnBattle.Size = new Size(133, 70);
            btnBattle.TabIndex = 2;
            btnBattle.UseVisualStyleBackColor = true;
            btnBattle.Click += btnBattle_Click;
            // 
            // btnFifa
            // 
            btnFifa.BackgroundImage = (Image)resources.GetObject("btnFifa.BackgroundImage");
            btnFifa.BackgroundImageLayout = ImageLayout.Stretch;
            btnFifa.Cursor = Cursors.Hand;
            btnFifa.FlatAppearance.BorderSize = 0;
            btnFifa.FlatStyle = FlatStyle.Flat;
            btnFifa.Location = new Point(551, 2);
            btnFifa.Name = "btnFifa";
            btnFifa.Size = new Size(133, 70);
            btnFifa.TabIndex = 2;
            btnFifa.UseVisualStyleBackColor = true;
            btnFifa.Click += btnFifa_Click;
            // 
            // btnSudden
            // 
            btnSudden.BackgroundImage = (Image)resources.GetObject("btnSudden.BackgroundImage");
            btnSudden.BackgroundImageLayout = ImageLayout.Stretch;
            btnSudden.Cursor = Cursors.Hand;
            btnSudden.FlatAppearance.BorderSize = 0;
            btnSudden.FlatStyle = FlatStyle.Flat;
            btnSudden.Location = new Point(717, 2);
            btnSudden.Name = "btnSudden";
            btnSudden.Size = new Size(133, 70);
            btnSudden.TabIndex = 2;
            btnSudden.UseVisualStyleBackColor = true;
            btnSudden.Click += btnSudden_Click;
            // 
            // btnLeague
            // 
            btnLeague.BackgroundImage = (Image)resources.GetObject("btnLeague.BackgroundImage");
            btnLeague.BackgroundImageLayout = ImageLayout.Stretch;
            btnLeague.Cursor = Cursors.Hand;
            btnLeague.FlatAppearance.BorderSize = 0;
            btnLeague.FlatStyle = FlatStyle.Flat;
            btnLeague.Location = new Point(891, 2);
            btnLeague.Name = "btnLeague";
            btnLeague.Size = new Size(133, 70);
            btnLeague.TabIndex = 2;
            btnLeague.UseVisualStyleBackColor = true;
            btnLeague.Click += btnLeague_Click;
            // 
            // btnOver
            // 
            btnOver.BackgroundImage = (Image)resources.GetObject("btnOver.BackgroundImage");
            btnOver.BackgroundImageLayout = ImageLayout.Stretch;
            btnOver.Cursor = Cursors.Hand;
            btnOver.FlatAppearance.BorderSize = 0;
            btnOver.FlatStyle = FlatStyle.Flat;
            btnOver.Location = new Point(1059, 2);
            btnOver.Name = "btnOver";
            btnOver.Size = new Size(133, 70);
            btnOver.TabIndex = 2;
            btnOver.UseVisualStyleBackColor = true;
            btnOver.Click += btnOver_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(38, 96);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(307, 282);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1023);
            panel2.Name = "panel2";
            panel2.Size = new Size(1920, 57);
            panel2.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(pictureBox2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1825, 57);
            panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(813, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(813, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1012, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(218, 224, 232);
            panel3.Controls.Add(Time);
            panel3.Dock = DockStyle.Right;
            panel3.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel3.Location = new Point(1825, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(95, 57);
            panel3.TabIndex = 0;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Time.Location = new Point(15, 14);
            Time.Name = "Time";
            Time.Size = new Size(39, 15);
            Time.TabIndex = 7;
            Time.Text = "label1";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1920, 1023);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // btnChromeicon
            // 
            btnChromeicon.BackColor = Color.Transparent;
            btnChromeicon.BackgroundImage = (Image)resources.GetObject("btnChromeicon.BackgroundImage");
            btnChromeicon.BackgroundImageLayout = ImageLayout.Stretch;
            btnChromeicon.FlatStyle = FlatStyle.Flat;
            btnChromeicon.Location = new Point(14, 104);
            btnChromeicon.Name = "btnChromeicon";
            btnChromeicon.Size = new Size(71, 67);
            btnChromeicon.TabIndex = 8;
            btnChromeicon.UseVisualStyleBackColor = false;
            btnChromeicon.Click += btnChromeicon_Click;
            // 
            // btnEx
            // 
            btnEx.BackColor = Color.Transparent;
            btnEx.BackgroundImage = (Image)resources.GetObject("btnEx.BackgroundImage");
            btnEx.BackgroundImageLayout = ImageLayout.Stretch;
            btnEx.FlatStyle = FlatStyle.Flat;
            btnEx.Location = new Point(14, 22);
            btnEx.Name = "btnEx";
            btnEx.Size = new Size(73, 69);
            btnEx.TabIndex = 8;
            btnEx.UseVisualStyleBackColor = false;
            btnEx.Click += btnEx_Click;
            // 
            // UserPcMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(btnEx);
            Controls.Add(btnChromeicon);
            Controls.Add(transPanel1);
            Controls.Add(btnExit);
            Controls.Add(btnInquiry);
            Controls.Add(btnMove);
            Controls.Add(panel1);
            Controls.Add(btnProduct);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(2);
            Name = "UserPcMain";
            Size = new Size(1920, 1080);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            transPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label lbSeat2;
        private Label lbSeat1;
        private Label lbName2;
        private Label lbName1;
        private Label lbTime2;
        private Label lbTime1;
        private Button btnInquiry;
        private Button btnExit;
        private ReaLTaiizor.Controls.CyberButton btnProduct;
        private Button btnMove;
        private TransPanel transPanel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label Time;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnLostArk;
        private Button btnMapple;
        private Button btnBattle;
        private Button btnFifa;
        private Button btnSudden;
        private Button btnLeague;
        private Button btnOver;
        private Panel panel5;
        private Button btnSteam;
        private Button btnOpgg;
        private Button btnChrome;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnPop;
        private Button btnKeyboard;
        private Button btnMouse;
        private Button btnSelect;
        private Button btnSpeedGamel;
        private Button btnControllPanel;
        private Button btnSound;
        private Button btnNight;
        private Button btnChromeicon;
        private Button btnEx;
    }
}
