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
using BC = BCrypt.Net.BCrypt;

namespace QuanLyCoffe.Forms
{
    public partial class frmNhanVien : Form
    {
        QLCFDbContext context = new QLCFDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã nhân viên (dùng cho Sửa và Xóa
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenNhanVien.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            txtGioiTinh.Enabled = giaTri;
            cboChucVu.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;
            List<NhanVien> nv = new List<NhanVien>(); nv = context.NhanVien.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;
            txtTenNhanVien.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Add("Text", bindingSource, "TenNhanVien", false, DataSourceUpdateMode.Never);
            // Tương tự đối với txtDienThoai, txtDiaChi, txtTenDangNhap
            cboChucVu.DataBindings.Clear();
            cboChucVu.DataBindings.Add("Text", bindingSource, "ChucVu", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenNhanVien.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtGioiTinh.Clear();
            cboChucVu.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text))
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                MessageBox.Show("Vui lòng nhập tên đăng nhập?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboChucVu.Text))
                MessageBox.Show("Vui lòng chọn quyền hạn cho nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                        MessageBox.Show("Vui lòng nhập mật khẩu?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        NhanVien nv = new NhanVien();
                        nv.TenNhanVien = txtTenNhanVien.Text;
                        nv.DienThoai = txtDienThoai.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.GioiTinh = txtGioiTinh.Text;
                        nv.MatKhau = BC.HashPassword(txtMatKhau.Text); // Mã hóa mật khẩu
                        nv.ChucVu = cboChucVu.SelectedIndex == 0 ? true : false;
                        context.NhanVien.Add(nv);
                        context.SaveChanges();
                    }
                }
                else
                {
                    NhanVien nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.TenNhanVien = txtTenNhanVien.Text;
                        nv.DienThoai = txtDienThoai.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.ChucVu = cboChucVu.SelectedIndex == 0 ? true : false;
                        context.NhanVien.Update(nv);
                        if (string.IsNullOrEmpty(txtMatKhau.Text))
                            context.Entry(nv).Property(x => x.MatKhau).IsModified = false; // Giữ nguyên mật khẩu cũ
                        else
                            nv.MatKhau = BC.HashPassword(txtMatKhau.Text); // Cập nhật mật khẩu mớicontext.SaveChanges();
                    }
                }
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa nhân viên " + txtTenNhanVien.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["IDc"].Value.ToString());
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                }
                context.SaveChanges();
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }
    }
}
