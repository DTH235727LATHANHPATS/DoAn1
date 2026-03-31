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
    public partial class frmHoaDonChiTiet : Form
    {
        QLCFDbContext context = new QLCFDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        int id; // Lấy mã hóa đơn (dùng cho Sửa và Xóa)
        BindingList<DanhSachHoaDon_ChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>();
        public frmHoaDonChiTiet(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;
        }
        public void LayTenNhanVienVaoComboBox()
        {
            cboTenNhanVien.DataSource = context.NhanVien.ToList();
            cboTenNhanVien.ValueMember = "ID";
            cboTenNhanVien.DisplayMember = "TenNhanVien";
        }
        public void LaySoBanComboBox()
        {
            cboTenBan.DataSource = context.Ban.ToList();
            cboTenBan.ValueMember = "ID";
            cboTenBan.DisplayMember = "HoVaTen";
        }
        public void LaySanPhamVaoComboBox()
        {
            cboSanPham.DataSource = context.SanPham.ToList();
            cboSanPham.ValueMember = "ID";
            cboSanPham.DisplayMember = "TenSanPham";
        }
        public void BatTatChucNang()
        {
            if (id == 0 && dataGridView.Rows.Count == 0) // Thêm
            {
                // Xóa trắng các trường
                cboTenNhanVien.Text = "";
                cboTenBan.Text = "";
                cboSanPham.Text = "";
                numSoLuong.Value = 1;
                numDonGia.Value = 0;
            }
            // Nút lưu và xóa chỉ sáng khi có sản phẩm
            btnXacNhan.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
        }
        private void frmHoaDonChiTiet_Load(object sender, EventArgs e)
        {
            LayTenNhanVienVaoComboBox();
            LaySoBanComboBox();
            LaySanPhamVaoComboBox();
            dataGridView.AutoGenerateColumns = false;
            if (id != 0) // Đã tồn tại chi tiết
            {
                var hoaDon = context.HoaDon.Where(r => r.ID == id).SingleOrDefault();
                cboTenNhanVien.SelectedValue = hoaDon.NhanVienID;
                cboTenBan.SelectedValue = hoaDon.BanID;
                txtGhiChu.Text = hoaDon.GhiChuHoaDon;
                var ct = context.ChiTietHoaDon.Where(r => r.HoaDonID == id).Select(r => new DanhSachHoaDon_ChiTiet
                {
                    ID = r.ID,
                    HoaDonID = r.HoaDonID,
                    SanPhamID = r.SanPhamID,
                    TenSanPham = r.SanPham.TenSanPham,
                    SoLuong = r.SoLuong,
                    DonGia = r.DonGia,
                    ThanhTien = Convert.ToInt32(r.SoLuong * r.DonGia)
                }).ToList();
                hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>(ct);
            }
            dataGridView.DataSource = hoaDonChiTiet;
            BatTatChucNang();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboSanPham.Text))
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuong.Value <= 0)
                MessageBox.Show("Số lượng bán phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGia.Value <= 0)
                MessageBox.Show("Đơn giá bán sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            {
                int maSanPham = Convert.ToInt32(cboSanPham.SelectedValue.ToString());
                var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);
                // Nếu đã tồn tại sản phẩm thì cập nhật thông tin
                if (chiTiet != null)
                {
                    chiTiet.SoLuong = Convert.ToInt16(numSoLuong.Value);
                    chiTiet.DonGia = Convert.ToInt32(numDonGia.Value);
                    chiTiet.ThanhTien = Convert.ToInt32(numSoLuong.Value * numDonGia.Value);
                    dataGridView.Refresh();
                }
                else // Nếu chưa có sản phẩm thì thêm vào
                {
                    // Nếu chưa có sản phẩm nào
                    DanhSachHoaDon_ChiTiet ct = new DanhSachHoaDon_ChiTiet
                    {
                        ID = 0,
                        HoaDonID = id,
                        SanPhamID = maSanPham,
                        TenSanPham = cboSanPham.Text,
                        SoLuong = Convert.ToInt16(numSoLuong.Value),
                        DonGia = Convert.ToInt32(numDonGia.Value),
                        ThanhTien = Convert.ToInt32(numSoLuong.Value * numDonGia.Value)
                    };
                    hoaDonChiTiet.Add(ct);
                }
                BatTatChucNang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maSanPham = Convert.ToInt32(dataGridView.CurrentRow.Cells["SanPhamID"].Value.ToString());
            var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);
            if (chiTiet != null)
            {
                hoaDonChiTiet.Remove(chiTiet);
            }
            BatTatChucNang();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTenNhanVien.Text))
                MessageBox.Show("Vui lòng chọn nhân viên lập hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboTenBan.Text))
                MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id != 0) // Đã tồn tại chi tiết thì chỉ cập nhật
                {
                    HoaDon hd = context.HoaDon.Find(id);
                    if (hd != null)
                    {
                        hd.NhanVienID = Convert.ToInt32(cboTenNhanVien.SelectedValue.ToString());
                        hd.BanID = Convert.ToInt32(cboTenBan.SelectedValue.ToString());
                        hd.GhiChuHoaDon = txtGhiChu.Text;
                        context.HoaDon.Update(hd);// Xóa chi tiết cũ
                        var old = context.ChiTietHoaDon.Where(r => r.HoaDonID == id).ToList();
                        context.ChiTietHoaDon.RemoveRange(old);
                        // Thêm lại chi tiết mới
                        foreach (var item in hoaDonChiTiet.ToList())
                        {
                            ChiTietHoaDon ct = new ChiTietHoaDon();
                            ct.HoaDonID = id;
                            ct.SanPhamID = item.SanPhamID;
                            ct.SoLuong = item.SoLuong;
                            ct.DonGia = item.DonGia;
                            context.ChiTietHoaDon.Add(ct);
                        }
                        context.SaveChanges();
                    }
                }
                else // Thêm mới
                {
                    HoaDon hd = new HoaDon();
                    hd.NhanVienID = Convert.ToInt32(cboTenNhanVien.SelectedValue.ToString());
                    hd.BanID = Convert.ToInt32(cboTenBan.SelectedValue.ToString());
                    hd.NgayLap = DateTime.Now;
                    hd.GhiChuHoaDon = txtGhiChu.Text;
                    context.HoaDon.Add(hd);
                    context.SaveChanges();
                    // Thêm chi tiết
                    foreach (var item in hoaDonChiTiet.ToList())
                    {
                        ChiTietHoaDon ct = new ChiTietHoaDon();
                        ct.HoaDonID = hd.ID;
                        ct.SanPhamID = item.SanPhamID;
                        ct.SoLuong = item.SoLuong;
                        ct.DonGia = item.DonGia;
                        context.ChiTietHoaDon.Add(ct);
                    }
                    context.SaveChanges();
                }
                MessageBox.Show("Đã lưu thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
