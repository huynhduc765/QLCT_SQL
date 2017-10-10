namespace QLCT
{
    partial class Form1
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
            this.labelSoThuChi = new System.Windows.Forms.Label();
            this.buttonThemChiTieu = new System.Windows.Forms.Button();
            this.buttonThemThuNhap = new System.Windows.Forms.Button();
            this.buttonBaoCao = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemTrợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSoThuChi
            // 
            this.labelSoThuChi.AutoSize = true;
            this.labelSoThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoThuChi.Location = new System.Drawing.Point(223, 97);
            this.labelSoThuChi.Name = "labelSoThuChi";
            this.labelSoThuChi.Size = new System.Drawing.Size(115, 24);
            this.labelSoThuChi.TabIndex = 0;
            this.labelSoThuChi.Text = "Sổ Thu Chi";
            this.labelSoThuChi.Click += new System.EventHandler(this.labelSoThuChi_Click);
            // 
            // buttonThemChiTieu
            // 
            this.buttonThemChiTieu.Location = new System.Drawing.Point(30, 37);
            this.buttonThemChiTieu.Name = "buttonThemChiTieu";
            this.buttonThemChiTieu.Size = new System.Drawing.Size(136, 41);
            this.buttonThemChiTieu.TabIndex = 1;
            this.buttonThemChiTieu.Text = "Thêm Chi Tiêu";
            this.buttonThemChiTieu.UseVisualStyleBackColor = true;
            this.buttonThemChiTieu.Click += new System.EventHandler(this.buttonThemChiTieu_Click);
            // 
            // buttonThemThuNhap
            // 
            this.buttonThemThuNhap.Location = new System.Drawing.Point(188, 37);
            this.buttonThemThuNhap.Name = "buttonThemThuNhap";
            this.buttonThemThuNhap.Size = new System.Drawing.Size(130, 41);
            this.buttonThemThuNhap.TabIndex = 2;
            this.buttonThemThuNhap.Text = "Thêm Thu Nhập";
            this.buttonThemThuNhap.UseVisualStyleBackColor = true;
            this.buttonThemThuNhap.Click += new System.EventHandler(this.buttonThemThuNhap_Click);
            // 
            // buttonBaoCao
            // 
            this.buttonBaoCao.Location = new System.Drawing.Point(344, 37);
            this.buttonBaoCao.Name = "buttonBaoCao";
            this.buttonBaoCao.Size = new System.Drawing.Size(125, 41);
            this.buttonBaoCao.TabIndex = 3;
            this.buttonBaoCao.Text = "Xem Báo Cáo";
            this.buttonBaoCao.UseVisualStyleBackColor = true;
            this.buttonBaoCao.Click += new System.EventHandler(this.buttonBaoCao_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.càiĐặtToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(512, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem});
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.càiĐặtToolStripMenuItem.Text = "Cài Đặt";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemTrợGiúpToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // xemTrợGiúpToolStripMenuItem
            // 
            this.xemTrợGiúpToolStripMenuItem.Name = "xemTrợGiúpToolStripMenuItem";
            this.xemTrợGiúpToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.xemTrợGiúpToolStripMenuItem.Text = "Thông Tin";
            this.xemTrợGiúpToolStripMenuItem.Click += new System.EventHandler(this.xemTrợGiúpToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(512, 291);
            this.Controls.Add(this.buttonBaoCao);
            this.Controls.Add(this.buttonThemThuNhap);
            this.Controls.Add(this.buttonThemChiTieu);
            this.Controls.Add(this.labelSoThuChi);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Chính";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSoThuChi;
        private System.Windows.Forms.Button buttonThemChiTieu;
        private System.Windows.Forms.Button buttonThemThuNhap;
        private System.Windows.Forms.Button buttonBaoCao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemTrợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
    }
}

