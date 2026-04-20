
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tcp_chat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UserPcLogin user = new UserPcLogin();
            user.Dock = DockStyle.Fill;
            this.Controls.Add(user);

            this.FormBorderStyle = FormBorderStyle.None;

            // 2. 화면 상태를 최대화로 설정
            this.WindowState = FormWindowState.Maximized;

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Esc 키를 누르면 프로그램 즉시 종료
            if (keyData == Keys.Escape)
            {
                Application.Exit(); // 또는 this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
