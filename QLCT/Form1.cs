using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;


namespace QLCT
//    namespace WindowsEntityFramework

{

    public partial class Form1 : Form
    {
        
        public object dtgvData;

        //private object dtgvData;

        // private readonly object dtgvData;

        //private readonly object dtgvData;

        public Form1()
        {
            InitializeComponent();
       

        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void buttonThemChiTieu_Click(object sender, EventArgs e)
        {
            formNhapChiTieu formNhapChiTieu = new formNhapChiTieu();
            formNhapChiTieu.Activate();
            formNhapChiTieu.ShowDialog();
        }

        public void buttonBaoCao_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Activate();
            form2.ShowDialog();
        }

        public void buttonThemThuNhap_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Activate();
            form3.ShowDialog();
        }

        public void xemTrợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.Activate();
            formHelp.ShowDialog();
        }


        void XemChiTieu()
        {
        
        }

        public void button1_Click(object sender, EventArgs e)
        {
            XemChiTieu();
        }


        public void labelSoThuChi_Click(object sender, EventArgs e)
        {

        }

    

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDangKy fdk = new formDangKy();
            fdk.Activate();
            fdk.ShowDialog();
        }
    }
}
