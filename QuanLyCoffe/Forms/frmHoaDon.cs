using QuanLyCoffe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoffe.Forms
{
    public partial class frmHoaDon : Form
    {
        QLCFDbContext context = new QLCFDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        int id;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;

            var hd = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,

                // Nhân viên
                NhanVienID = r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.TenNhanVien,

                // Bàn
                BanID = r.BanID,
                Ban = r.TenBan,

                // Ngày lập
                NgayLap = r.NgayLap,

                // Tổng tiền
                TongTienHoaDon = r.ChiTietHoaDon
                                    .Sum(ct => ct.SoLuong * ct.DonGia),

                // Button text
                XemChiTiet = "Xem chi tiết"
            }).ToList();

            dataGridView.DataSource = hd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (frmHoaDonChiTiet chiTiet = new frmHoaDonChiTiet())
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            using (frmHoaDonChiTiet chiTiet = new frmHoaDonChiTiet(id))
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại hóa đơn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                HoaDon lsp = context.HoaDon.Find(id);
                if (lsp != null)
                {
                    context.HoaDon.Remove(lsp);
                }
                context.SaveChanges();
                frmHoaDon_Load(sender, e);
            }
        }
    }
}
