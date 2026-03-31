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
    public partial class frmPhanCongNhanVien : Form
    {
        QLCFDbContext context = new QLCFDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa)
        public int NhanVienID { get; set; }
        public frmPhanCongNhanVien()
        {
            InitializeComponent();
        }
        public void LayTenNhanVienVaoComboBox()
        {
            cboTenNhanVien.DataSource = context.NhanVien.ToList();
            cboTenNhanVien.ValueMember = "ID";
            cboTenNhanVien.DisplayMember = "TenNhanVien";
        }
        private void frmPhanCongNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            dataGridView.AutoGenerateColumns = false;

            // Load dữ liệu (JOIN với NhanVien)
            var ds = context.PhanCongNhanVien
                            .Select(x => new
                            {
                                x.ID,
                                TenNhanVien = x.NhanVien.TenNhanVien,
                                x.CaLam,
                                x.NgayLam
                            })
                            .ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ds;

            // Load ComboBox nhân viên
            cboTenNhanVien.DataSource = context.NhanVien.ToList();
            cboTenNhanVien.DisplayMember = "TenNhanVien";
            cboTenNhanVien.ValueMember = "ID";

            // Binding dữ liệu lên control
            cboTenNhanVien.DataBindings.Clear();
            cboTenNhanVien.DataBindings.Add("Text", bindingSource, "TenNhanVien", false, DataSourceUpdateMode.Never);

            cboCaLam.DataBindings.Clear();
            cboCaLam.DataBindings.Add("Text", bindingSource, "CaLam", false, DataSourceUpdateMode.Never);

            cboNgayLam.DataBindings.Clear();
            cboNgayLam.DataBindings.Add("Text", bindingSource, "NgayLam", false, DataSourceUpdateMode.Never);

            // Gán DataGridView
            dataGridView.DataSource = bindingSource;
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            // Reset dữ liệu
            cboTenNhanVien.SelectedIndex = -1;
            cboCaLam.SelectedIndex = -1;
            cboNgayLam.SelectedIndex = -1;

            // Focus vào control đầu tiên
            cboTenNhanVien.Focus();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmPhanCongNhanVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            NhanVienID = (int)cboTenNhanVien.SelectedValue;
            this.DialogResult = DialogResult.OK;
            this.Close();
            if (cboTenNhanVien.SelectedValue == null)
                MessageBox.Show("Vui lòng chọn nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboCaLam.Text))
                MessageBox.Show("Vui lòng chọn ca làm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboNgayLam.Text))
                MessageBox.Show("Vui lòng chọn ngày làm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem) // THÊM
                {
                    // Kiểm tra trùng (1 nhân viên - 1 ca - 1 ngày)
                    bool trung = context.PhanCongNhanVien.Any(x =>
                        x.NhanVienID == (int)cboTenNhanVien.SelectedValue &&
                        x.CaLam == cboCaLam.Text &&
                        x.NgayLam == cboNgayLam.Text);

                    if (trung)
                    {
                        MessageBox.Show("Phân công này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    PhanCongNhanVien pc = new PhanCongNhanVien();
                    pc.NhanVienID = (int)cboTenNhanVien.SelectedValue;
                    pc.CaLam = cboCaLam.Text;
                    pc.NgayLam = cboNgayLam.Text;

                    context.PhanCongNhanVien.Add(pc);
                    context.SaveChanges();
                }
                else // SỬA
                {
                    PhanCongNhanVien pc = context.PhanCongNhanVien.Find(id);

                    if (pc != null)
                    {
                        pc.NhanVienID = (int)cboTenNhanVien.SelectedValue;
                        pc.CaLam = cboCaLam.Text;
                        pc.NgayLam = cboNgayLam.Text;

                        context.PhanCongNhanVien.Update(pc);
                        context.SaveChanges();
                    }
                }

                // Reload lại form
                frmPhanCongNhanVien_Load(sender, e);

                BatTatChucNang(false);
                xuLyThem = false;

                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            xuLyThem = false;
            BatTatChucNang(true);

            // Lấy ID từ dòng đang chọn
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

            // Đổ dữ liệu lên control
            cboTenNhanVien.Text = dataGridView.CurrentRow.Cells["TenNhanVien"].Value.ToString();
            cboCaLam.Text = dataGridView.CurrentRow.Cells["CaLam"].Value.ToString();
            cboNgayLam.Text = dataGridView.CurrentRow.Cells["NgayLam"].Value.ToString();

            cboTenNhanVien.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa phân công này?",
                "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Lấy ID từ dòng đang chọn
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

                PhanCongNhanVien pc = context.PhanCongNhanVien.Find(id);

                if (pc != null)
                {
                    context.PhanCongNhanVien.Remove(pc);
                    context.SaveChanges();
                }

                // Load lại dữ liệu
                frmPhanCongNhanVien_Load(sender, e);

                MessageBox.Show("Xóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
