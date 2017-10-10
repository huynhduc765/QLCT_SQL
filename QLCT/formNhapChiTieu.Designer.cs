namespace QLCT
{
    partial class formNhapChiTieu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datetime_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.dtgvData = new System.Windows.Forms.DataGridView();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_view = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            this.tb_nhomchitieu = new System.Windows.Forms.TextBox();
            this.tb_sotien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ghichu = new System.Windows.Forms.TextBox();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên chi tiêu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số Tiền";
            // 
            // datetime_ngaynhap
            // 
            this.datetime_ngaynhap.Location = new System.Drawing.Point(95, 20);
            this.datetime_ngaynhap.Name = "datetime_ngaynhap";
            this.datetime_ngaynhap.Size = new System.Drawing.Size(180, 20);
            this.datetime_ngaynhap.TabIndex = 10;
            this.datetime_ngaynhap.ValueChanged += new System.EventHandler(this.datetime_ngaynhap_ValueChanged);
            // 
            // dtgvData
            // 
            this.dtgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvData.Location = new System.Drawing.Point(307, 12);
            this.dtgvData.Name = "dtgvData";
            this.dtgvData.Size = new System.Drawing.Size(240, 150);
            this.dtgvData.TabIndex = 11;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(147, 150);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 12;
            this.bt_add.Text = "Thêm";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(66, 179);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(75, 23);
            this.bt_edit.TabIndex = 13;
            this.bt_edit.Text = "Sửa";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_view
            // 
            this.bt_view.Location = new System.Drawing.Point(66, 150);
            this.bt_view.Name = "bt_view";
            this.bt_view.Size = new System.Drawing.Size(75, 23);
            this.bt_view.TabIndex = 14;
            this.bt_view.Text = "Xem";
            this.bt_view.UseVisualStyleBackColor = true;
            this.bt_view.Click += new System.EventHandler(this.bt_view_Click);
            // 
            // bt_del
            // 
            this.bt_del.Location = new System.Drawing.Point(147, 179);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(75, 23);
            this.bt_del.TabIndex = 15;
            this.bt_del.Text = "Xóa";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
            // 
            // tb_nhomchitieu
            // 
            this.tb_nhomchitieu.Location = new System.Drawing.Point(95, 46);
            this.tb_nhomchitieu.Name = "tb_nhomchitieu";
            this.tb_nhomchitieu.Size = new System.Drawing.Size(100, 20);
            this.tb_nhomchitieu.TabIndex = 16;
            this.tb_nhomchitieu.TextChanged += new System.EventHandler(this.tb_nhomchitieu_TextChanged);
            // 
            // tb_sotien
            // 
            this.tb_sotien.Location = new System.Drawing.Point(95, 72);
            this.tb_sotien.Name = "tb_sotien";
            this.tb_sotien.Size = new System.Drawing.Size(100, 20);
            this.tb_sotien.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ngày nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ghi chú";
            // 
            // tb_ghichu
            // 
            this.tb_ghichu.Location = new System.Drawing.Point(95, 98);
            this.tb_ghichu.Name = "tb_ghichu";
            this.tb_ghichu.Size = new System.Drawing.Size(100, 20);
            this.tb_ghichu.TabIndex = 21;
            // 
            // cbbLoai
            // 
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Location = new System.Drawing.Point(95, 125);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(121, 21);
            this.cbbLoai.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Loại";
            // 
            // formNhapChiTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 314);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbLoai);
            this.Controls.Add(this.tb_ghichu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_sotien);
            this.Controls.Add(this.tb_nhomchitieu);
            this.Controls.Add(this.bt_del);
            this.Controls.Add(this.bt_view);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.dtgvData);
            this.Controls.Add(this.datetime_ngaynhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "formNhapChiTieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Chi Tiêu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datetime_ngaynhap;
        private System.Windows.Forms.DataGridView dtgvData;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_view;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.TextBox tb_nhomchitieu;
        private System.Windows.Forms.TextBox tb_sotien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ghichu;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.Label label5;
    }
}