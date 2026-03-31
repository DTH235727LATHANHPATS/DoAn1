using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoffe.Forms
{
    public partial class frmMain : Form
    {
        frmLoaiSanPham loaiSanPham = null;
        frmSanPham sanPham = null;
        frmBan ban = null;
        frmNhanVien nhanVien = null;
        frmLichLam lichLam = null;
        frmHoaDon hoaDon = null;
        string hoVaTenNhanVien = ""; // Lấy tên người dùng hiển thị vào thanh Status.
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://fit.agu.edu.vn"; Process.Start(info);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmTrangChu frm = new frmTrangChu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (loaiSanPham == null || loaiSanPham.IsDisposed)
            {
                loaiSanPham = new frmLoaiSanPham();
                loaiSanPham.MdiParent = this;
                loaiSanPham.Show();
            }
            else
                loaiSanPham.Activate();
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            if (sanPham == null || sanPham.IsDisposed)
            {
                sanPham = new frmSanPham();
                sanPham.MdiParent = this;
                sanPham.Show();
            }
            else
                sanPham.Activate();
        }

        private void mnuBan_Click(object sender, EventArgs e)
        {
            if (ban == null || ban.IsDisposed)
            {
                ban = new frmBan();
                ban.MdiParent = this;
                ban.Show();
            }
            else
                ban.Activate();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else
                nhanVien.Activate();
        }

        private void mnuLichLam_Click(object sender, EventArgs e)
        {
            if (lichLam == null || lichLam.IsDisposed)
            {
                lichLam = new frmLichLam();
                lichLam.MdiParent = this;
                lichLam.Show();
            }
            else
                lichLam.Activate();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            if (hoaDon == null || hoaDon.IsDisposed)
            {
                hoaDon = new frmHoaDon();
                hoaDon.MdiParent = this;
                hoaDon.Show();
            }
            else
                hoaDon.Activate();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is frmTrangChu)
                {
                    f.Activate();
                    return;
                }
            }

            frmTrangChu frm = new frmTrangChu();
            frm.MdiParent = this;
            frm.Show();
        }
    }

}
