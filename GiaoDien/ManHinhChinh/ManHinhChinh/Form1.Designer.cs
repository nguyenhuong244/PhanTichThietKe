
namespace ManHinhChinh
{
    partial class QuanLyPhongTro
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.QuanLyKhachThue = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyPhongTron = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhSachPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.HoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyThueTraPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.HopDong = new System.Windows.Forms.ToolStripMenuItem();
            this.TraPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyThietBi = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhSachThietBi = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhSachThietBiHuHong = new System.Windows.Forms.ToolStripMenuItem();
            this.BaoCaoThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.PhongTrong = new System.Windows.Forms.ToolStripMenuItem();
            this.PhongConNo = new System.Windows.Forms.ToolStripMenuItem();
            this.ThietBiHu = new System.Windows.Forms.ToolStripMenuItem();
            this.dskt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuanLyKhachThue,
            this.QuanLyPhongTron,
            this.QuanLyThueTraPhong,
            this.QuanLyThietBi,
            this.BaoCaoThongKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // QuanLyKhachThue
            // 
            this.QuanLyKhachThue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dskt});
            this.QuanLyKhachThue.Name = "QuanLyKhachThue";
            this.QuanLyKhachThue.Size = new System.Drawing.Size(148, 24);
            this.QuanLyKhachThue.Text = "Quản lý khách thuê";
            // 
            // QuanLyPhongTron
            // 
            this.QuanLyPhongTron.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DanhSachPhong,
            this.HoaDon});
            this.QuanLyPhongTron.Name = "QuanLyPhongTron";
            this.QuanLyPhongTron.Size = new System.Drawing.Size(143, 24);
            this.QuanLyPhongTron.Text = "Quản lý phòng trọ";
            // 
            // DanhSachPhong
            // 
            this.DanhSachPhong.Name = "DanhSachPhong";
            this.DanhSachPhong.Size = new System.Drawing.Size(224, 26);
            this.DanhSachPhong.Text = "Danh sách phòng";
            this.DanhSachPhong.Click += new System.EventHandler(this.DanhSachPhong_Click);
            // 
            // HoaDon
            // 
            this.HoaDon.Name = "HoaDon";
            this.HoaDon.Size = new System.Drawing.Size(224, 26);
            this.HoaDon.Text = "Hóa đơn";
            this.HoaDon.Click += new System.EventHandler(this.HoaDon_Click);
            // 
            // QuanLyThueTraPhong
            // 
            this.QuanLyThueTraPhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HopDong,
            this.TraPhong});
            this.QuanLyThueTraPhong.Name = "QuanLyThueTraPhong";
            this.QuanLyThueTraPhong.Size = new System.Drawing.Size(175, 24);
            this.QuanLyThueTraPhong.Text = "Quản lý thuê trả phòng";
            // 
            // HopDong
            // 
            this.HopDong.Name = "HopDong";
            this.HopDong.Size = new System.Drawing.Size(224, 26);
            this.HopDong.Text = "Hợp đồng";
            this.HopDong.Click += new System.EventHandler(this.HopDong_Click);
            // 
            // TraPhong
            // 
            this.TraPhong.Name = "TraPhong";
            this.TraPhong.Size = new System.Drawing.Size(224, 26);
            this.TraPhong.Text = "Trả phòng";
            this.TraPhong.Click += new System.EventHandler(this.TraPhong_Click);
            // 
            // QuanLyThietBi
            // 
            this.QuanLyThietBi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DanhSachThietBi,
            this.DanhSachThietBiHuHong});
            this.QuanLyThietBi.Name = "QuanLyThietBi";
            this.QuanLyThietBi.Size = new System.Drawing.Size(124, 24);
            this.QuanLyThietBi.Text = "Quản lý thiết bị";
            // 
            // DanhSachThietBi
            // 
            this.DanhSachThietBi.Name = "DanhSachThietBi";
            this.DanhSachThietBi.Size = new System.Drawing.Size(270, 26);
            this.DanhSachThietBi.Text = "Danh sách thiết bị";
            this.DanhSachThietBi.Click += new System.EventHandler(this.DanhSachThietBi_Click);
            // 
            // DanhSachThietBiHuHong
            // 
            this.DanhSachThietBiHuHong.Name = "DanhSachThietBiHuHong";
            this.DanhSachThietBiHuHong.Size = new System.Drawing.Size(270, 26);
            this.DanhSachThietBiHuHong.Text = "Danh sách thiết bị hư hỏng";
            // 
            // BaoCaoThongKe
            // 
            this.BaoCaoThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PhongTrong,
            this.PhongConNo,
            this.ThietBiHu});
            this.BaoCaoThongKe.Name = "BaoCaoThongKe";
            this.BaoCaoThongKe.Size = new System.Drawing.Size(139, 24);
            this.BaoCaoThongKe.Text = "Báo cáo thống kê";
            // 
            // PhongTrong
            // 
            this.PhongTrong.Name = "PhongTrong";
            this.PhongTrong.Size = new System.Drawing.Size(256, 26);
            this.PhongTrong.Text = "Báo cáo phòng trống";
            // 
            // PhongConNo
            // 
            this.PhongConNo.Name = "PhongConNo";
            this.PhongConNo.Size = new System.Drawing.Size(256, 26);
            this.PhongConNo.Text = "Báo cáo phòng còn nợ";
            // 
            // ThietBiHu
            // 
            this.ThietBiHu.Name = "ThietBiHu";
            this.ThietBiHu.Size = new System.Drawing.Size(256, 26);
            this.ThietBiHu.Text = "Báo cáo thiết bị hư hỏng";
            // 
            // dskt
            // 
            this.dskt.Name = "dskt";
            this.dskt.Size = new System.Drawing.Size(235, 26);
            this.dskt.Text = "Danh sách khách thuê";
            this.dskt.Click += new System.EventHandler(this.dskt_Click);
            // 
            // QuanLyPhongTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLyPhongTro";
            this.Text = "Quản Lý Phòng Trọ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem QuanLyKhachThue;
        private System.Windows.Forms.ToolStripMenuItem QuanLyPhongTron;
        private System.Windows.Forms.ToolStripMenuItem QuanLyThueTraPhong;
        private System.Windows.Forms.ToolStripMenuItem DanhSachPhong;
        private System.Windows.Forms.ToolStripMenuItem HoaDon;
        private System.Windows.Forms.ToolStripMenuItem HopDong;
        private System.Windows.Forms.ToolStripMenuItem TraPhong;
        private System.Windows.Forms.ToolStripMenuItem QuanLyThietBi;
        private System.Windows.Forms.ToolStripMenuItem DanhSachThietBi;
        private System.Windows.Forms.ToolStripMenuItem DanhSachThietBiHuHong;
        private System.Windows.Forms.ToolStripMenuItem BaoCaoThongKe;
        private System.Windows.Forms.ToolStripMenuItem PhongTrong;
        private System.Windows.Forms.ToolStripMenuItem PhongConNo;
        private System.Windows.Forms.ToolStripMenuItem ThietBiHu;
        private System.Windows.Forms.ToolStripMenuItem dskt;
    }
}

