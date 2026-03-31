namespace QuanLyCoffe.Forms
{
    partial class frmMain
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
            menuStrip = new MenuStrip();
            trangChủToolStripMenuItem = new ToolStripMenuItem();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuThoat = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuLoaiSanPham = new ToolStripMenuItem();
            mnuSanPham = new ToolStripMenuItem();
            mnuBan = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            mnuNhanVien = new ToolStripMenuItem();
            mnuLichLam = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            mnuHoaDon = new ToolStripMenuItem();
            mnuThongKe = new ToolStripMenuItem();
            mnuThongKeSanPham = new ToolStripMenuItem();
            mnuThongKeDoanhThu = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuHuongDan = new ToolStripMenuItem();
            mnuThongTin = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, mnuHeThong, mnuQuanLy, mnuThongKe, mnuTroGiup });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1173, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            trangChủToolStripMenuItem.Size = new Size(89, 24);
            trangChủToolStripMenuItem.Text = "&Trang Chủ";
            trangChủToolStripMenuItem.Click += trangChủToolStripMenuItem_Click;
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, toolStripMenuItem1, mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(88, 24);
            mnuHeThong.Text = "&Hệ Thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(183, 26);
            mnuDangNhap.Text = "Đăng &nhập";
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(183, 26);
            mnuDangXuat.Text = "Đăng &xuất";
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(183, 26);
            mnuDoiMatKhau.Text = "Đổi &mật khẩu";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 6);
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(183, 26);
            mnuThoat.Text = "&Thoát";
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuLoaiSanPham, mnuSanPham, mnuBan, toolStripMenuItem2, mnuNhanVien, mnuLichLam, toolStripMenuItem3, mnuHoaDon });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(75, 24);
            mnuQuanLy.Text = "&Quản Lý";
            // 
            // mnuLoaiSanPham
            // 
            mnuLoaiSanPham.Name = "mnuLoaiSanPham";
            mnuLoaiSanPham.Size = new Size(221, 26);
            mnuLoaiSanPham.Text = "&Loại Sản Phẩm";
            mnuLoaiSanPham.Click += mnuLoaiSanPham_Click;
            // 
            // mnuSanPham
            // 
            mnuSanPham.Name = "mnuSanPham";
            mnuSanPham.Size = new Size(221, 26);
            mnuSanPham.Text = "&Sản Phẩm";
            mnuSanPham.Click += mnuSanPham_Click;
            // 
            // mnuBan
            // 
            mnuBan.Name = "mnuBan";
            mnuBan.Size = new Size(221, 26);
            mnuBan.Text = "&Bàn";
            mnuBan.Click += mnuBan_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(218, 6);
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(221, 26);
            mnuNhanVien.Text = "&Nhân Viên";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuLichLam
            // 
            mnuLichLam.Name = "mnuLichLam";
            mnuLichLam.Size = new Size(221, 26);
            mnuLichLam.Text = "&Lịch Làm";
            mnuLichLam.Click += mnuLichLam_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(218, 6);
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(221, 26);
            mnuHoaDon.Text = "Hó&a Đơn Bán Hàng";
            mnuHoaDon.Click += mnuHoaDon_Click;
            // 
            // mnuThongKe
            // 
            mnuThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeSanPham, mnuThongKeDoanhThu });
            mnuThongKe.Name = "mnuThongKe";
            mnuThongKe.Size = new Size(86, 24);
            mnuThongKe.Text = "Thống &Kê";
            // 
            // mnuThongKeSanPham
            // 
            mnuThongKeSanPham.Name = "mnuThongKeSanPham";
            mnuThongKeSanPham.Size = new Size(231, 26);
            mnuThongKeSanPham.Text = "Thống Kê &Sản Phẩm";
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Size = new Size(231, 26);
            mnuThongKeDoanhThu.Text = "Thống Kê &Doanh Thu";
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuHuongDan, mnuThongTin });
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(79, 24);
            mnuTroGiup.Text = "Trợ &Giúp";
            // 
            // mnuHuongDan
            // 
            mnuHuongDan.Name = "mnuHuongDan";
            mnuHuongDan.ShortcutKeys = Keys.Control | Keys.F1;
            mnuHuongDan.Size = new Size(281, 26);
            mnuHuongDan.Text = "&Hướng dẫn sử dụng";
            // 
            // mnuThongTin
            // 
            mnuThongTin.Name = "mnuThongTin";
            mnuThongTin.Size = new Size(281, 26);
            mnuThongTin.Text = "&Thông tin phần mềm";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, lblLienKet });
            statusStrip.Location = new Point(0, 409);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1173, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(123, 20);
            lblTrangThai.Text = "Chưa Đăng Nhập";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(915, 20);
            toolStripStatusLabel1.Spring = true;
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(81, 20);
            lblLienKet.Text = "© 2024 FIT";
            lblLienKet.Click += toolStripStatusLabel2_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 435);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Cà Phê";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuThongKe;
        private ToolStripMenuItem mnuTroGiup;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuLoaiSanPham;
        private ToolStripMenuItem mnuSanPham;
        private ToolStripMenuItem mnuBan;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuLichLam;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem mnuThongKeSanPham;
        private ToolStripMenuItem mnuThongKeDoanhThu;
        private ToolStripMenuItem mnuHuongDan;
        private ToolStripMenuItem mnuThongTin;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblLienKet;
    }
}