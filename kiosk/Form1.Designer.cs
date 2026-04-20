namespace Kiosk_Sum
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button52 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.충전하기1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("페이퍼로지 8 ExtraBold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(1049, 286);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(630, 541);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button52
            // 
            button52.BackColor = Color.Transparent;
            button52.BackgroundImage = Properties.Resources.좌석보기_Photoroom;
            button52.BackgroundImageLayout = ImageLayout.Stretch;
            button52.Cursor = Cursors.Hand;
            button52.FlatAppearance.BorderSize = 0;
            button52.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button52.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button52.FlatStyle = FlatStyle.Flat;
            button52.Font = new Font("페이퍼로지 8 ExtraBold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button52.ForeColor = SystemColors.Window;
            button52.Location = new Point(187, 286);
            button52.Margin = new Padding(2);
            button52.Name = "button52";
            button52.Size = new Size(684, 541);
            button52.TabIndex = 10;
            button52.UseVisualStyleBackColor = false;
            button52.Click += button52_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1698, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1904, 1041);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(button52);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button52;
        private PictureBox pictureBox1;
    }
}
