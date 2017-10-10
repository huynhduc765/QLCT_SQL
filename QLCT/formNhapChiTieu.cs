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
    public partial class formNhapChiTieu : Form
    {

        QuanLyChiTieuEntities db = new QuanLyChiTieuEntities();
        public formNhapChiTieu()
        {
           
            InitializeComponent();
            //Load();
            //  AddBinding();

            var loais = db.LoaiChiTieux.Select(c => c).ToList();
            cbbLoai.DataSource = loais;
            cbbLoai.DisplayMember = "TenLoaiChiTieu";
            cbbLoai.ValueMember = "MaLoai";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }
#region methods
        /* Show ra luôn không cần xem
        void AddBinding()
        {
            tb_nhomchitieu.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "MaChiTieu"));
            tb_sotien.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "TenChiTieu"));
        }
        */
        void Load()
        {
            //QLCTEntities db = new QLCTEntities();
            //dtgvData.DataSource = db.DanhSachChiTieux.ToList();
            var result = from c in db.DanhSachChiTieux select c;
            dtgvData.DataSource = result.ToList();

        }
        void Add()
        {
            DanhSachChiTieu chitieu = new DanhSachChiTieu();
            chitieu.LoaiChiTieu = db.LoaiChiTieux.SingleOrDefault(c => c.MaLoai == (int)cbbLoai.SelectedValue);
            chitieu.TenChiTieu = "Ăn trưa";
            chitieu.GiaTien = 200000;
            chitieu.GhiChu = "Ăn trưa 2 người";
            //db.DanhSachChiTieux.Add(new DanhSachChiTieu() { TenChiTieu =Convert.ToString(tb_nhomchitieu) });
            //db.DanhSachChiTieux.Add(new DanhSachChiTieu() { GiaTien = Convert.ToInt32(tb_sotien.Text) });
            ////db.DanhSachChiTieux.Add(new DanhSachChiTieu() { NgayNhap = .Text });
            //db.DanhSachChiTieux.Add(new DanhSachChiTieu() { GhiChu = tb_ghichu.Text });
            db.DanhSachChiTieux.Add(chitieu);
            db.SaveChanges();
            
        }
        void Edit()
        { }
        void Del()
        { }
#endregion
        //Event
        private void bt_view_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Add();
            
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            //Edit();
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            //Del();
        }

        private void datetime_ngaynhap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tb_nhomchitieu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
