namespace Kiosk_Sum
{
    partial class Credit
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btnComplete = new Button();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.card_inner_3;
            pictureBox1.Location = new Point(19, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(798, 505);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnComplete
            // 
            btnComplete.BackColor = Color.LightGreen;
            btnComplete.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnComplete.ForeColor = Color.Black;
            btnComplete.Location = new Point(347, 568);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(121, 55);
            btnComplete.TabIndex = 7;
            btnComplete.Text = "결제";
            btnComplete.UseVisualStyleBackColor = false;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(718, 577);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(99, 46);
            bigLabel1.TabIndex = 8;
            bigLabel1.Text = "00:30";
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Credit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(bigLabel1);
            Controls.Add(btnComplete);
            Controls.Add(pictureBox1);
            Name = "Credit";
            Size = new Size(849, 666);
            Load += Credit_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Button btnComplete;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.Timer timer2;
    }
}
