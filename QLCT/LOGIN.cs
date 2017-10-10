using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCT
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            tb_id.Text = "admin";
            tb_pw.Text = "admin";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (this.tb_id.Text.Length == 0)
            {
                lb_loi.Text = "Vui Lòng Nhập Tài Khoản";
                lb_loi.Visible = true;
            }

            else if (this.tb_pw.Text.Length == 0)
            {
                lb_loi.Visible = true;
                lb_loi.Text = "Vui lòng Nhập Mật Khẩu";

            }
            else
            {
                lb_loi.Visible = false;
            }
            if (this.tb_id.Text.CompareTo("admin") == 0 && tb_pw.Text.CompareTo("admin") == 0)
            {
                //MessageBox.Show("Đăng nhập thành công");
                lb_loi.Visible = false;

                Visible = false;
                ShowInTaskbar = false;

                Form1 form1 = new Form1();
                form1.Activate();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
                lb_loi.Visible = false;
            }
        }

        private void lb_loi_Click(object sender, EventArgs e)
        {

        }
    }
}
