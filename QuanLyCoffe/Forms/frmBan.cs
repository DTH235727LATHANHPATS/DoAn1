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
    public partial class frmBan : Form
    {
        QLCFDbContext context = new QLCFDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa)
        public frmBan()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenBan.Enabled = giaTri;
            txtTrangThai.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<Ban> lsp = new List<Ban>();
            lsp = context.Ban.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lsp;
            txtTenBan.DataBindings.Clear();
            txtTenBan.DataBindings.Add("Text", bindingSource, "TenBan", false, DataSourceUpdateMode.Never);
            txtTrangThai.DataBindings.Clear();
            txtTrangThai.DataBindings.Add("Text", bindingSource, "TrangThai", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenBan.Clear();
            txtTrangThai.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenBan.Text))
                MessageBox.Show("Vui lòng nhập tên bàn?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    Ban lsp = new Ban();
                    lsp.TenBan = txtTenBan.Text;
                    lsp.TrangThai = txtTrangThai.Text;
                    context.Ban.Add(lsp);
                    context.SaveChanges();
                }
                else
                {
                    Ban lsp = context.Ban.Find(id);
                    if (lsp != null)
                    {
                        lsp.TenBan = txtTenBan.Text;
                        lsp.TrangThai = txtTrangThai.Text;
                        context.Ban.Update(lsp);
                        context.SaveChanges();
                    }
                }
                frmBan_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa bàn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                Ban lsp = context.Ban.Find(id);
                if (lsp != null)
                {
                    context.Ban.Remove(lsp);
                }
                context.SaveChanges();
                frmBan_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmBan_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
