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
using System.IO;           // Cần để dùng Path, File, Directory
using System.Drawing;      // Cần để dùng Image, Bitmap
using System.Drawing.Imaging; // Hỗ trợ định dạng ảnh

namespace QuanLyCoffe.Forms
{
    public partial class frmSanPham : Form
    {
        QLCFDbContext context = new QLCFDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã sản phẩm (dùng cho Sửa và Xóa)
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");
        public frmSanPham()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            cboTenLoai.Enabled = giaTri;
            txtTenSanPham.Enabled = giaTri;
            numGia.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnDoiAnh.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        public void LayLoaiSanPhamVaoComboBox()
        {
            cboTenLoai.DataSource = context.LoaiSanPham.ToList();
            cboTenLoai.ValueMember = "ID";
            cboTenLoai.DisplayMember = "TenLoai";
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {

            BatTatChucNang(false);
            LayLoaiSanPhamVaoComboBox();
            dataGridView.AutoGenerateColumns = false;
            List<DanhSachSanPham> sp = new List<DanhSachSanPham>();
            sp = context.SanPham.Select(r => new DanhSachSanPham
            {
                ID = r.ID,
                LoaiSanPhamID = r.LoaiSanPhamID,
                TenLoai = r.LoaiSanPham.TenLoai,
                TenSanPham = r.TenSanPham,
                Gia = r.Gia,
                HinhAnh = r.HinhAnh
            }).ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sp;
            cboTenLoai.DataBindings.Clear();
            cboTenLoai.DataBindings.Add("SelectedValue", bindingSource, "LoaiSanPhamID", false, DataSourceUpdateMode.Never);

            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham", false, DataSourceUpdateMode.Never);

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);

            numGia.DataBindings.Clear();
            numGia.DataBindings.Add("Value", bindingSource, "Gia", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra đúng Tên cột (Name) trong Designer
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                try
                {
                    // Lấy tên file ảnh từ nguồn dữ liệu (List DanhSachSanPham)
                    var rowData = dataGridView.Rows[e.RowIndex].DataBoundItem as DanhSachSanPham;

                    if (rowData != null && !string.IsNullOrWhiteSpace(rowData.HinhAnh))
                    {
                        string fullPath = Path.Combine(imagesFolder, rowData.HinhAnh);

                        if (File.Exists(fullPath))
                        {
                            using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                            {
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    fs.CopyTo(ms);
                                    ms.Seek(0, SeekOrigin.Begin);
                                    using (Image temp = Image.FromStream(ms))
                                    {
                                        // Gán trực tiếp vào e.Value
                                        e.Value = new Bitmap(temp, 32, 32); // Thử để 32x32 cho dễ nhìn
                                    }
                                }
                            }
                        }
                        else
                        {
                            e.Value = null; // Hoặc một ảnh mặc định "No Image"
                        }
                    }
                    else
                    {
                        e.Value = null;
                    }

                    // Dòng này bắt buộc phải có để Grid hiển thị ảnh
                    e.FormattingApplied = true;
                }
                catch
                {
                    e.Value = null;
                }
            }
        }
        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            cboTenLoai.Text = "";
            txtTenSanPham.Clear();
            txtMoTa.Clear();
            numGia.Value = 0;
            picHinhAnh.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTenLoai.Text))
                MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numGia.Value <= 0)
                MessageBox.Show("Đơn giá sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    SanPham sp = new SanPham();

                    sp.LoaiSanPhamID = Convert.ToInt32(cboTenLoai.SelectedValue);
                    sp.TenSanPham = txtTenSanPham.Text;
                    sp.Gia = Convert.ToInt32(numGia.Value);
                    sp.MoTa = txtMoTa.Text;
                    sp.HinhAnh = "";

                    context.SanPham.Add(sp);
                    context.SaveChanges();

                }
                else
                {
                    SanPham sp = context.SanPham.Find(id);
                    if (sp != null)
                    {
                        sp.LoaiSanPhamID = Convert.ToInt32(cboTenLoai.SelectedValue);
                        sp.TenSanPham = txtTenSanPham.Text;
                        sp.Gia = Convert.ToInt32(numGia.Value);
                        sp.MoTa = txtMoTa.Text;

                        context.SanPham.Update(sp);
                        context.SaveChanges();
                    }
                }
                frmSanPham_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa sản phẩm " + txtTenSanPham.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value.ToString());
                SanPham sp = context.SanPham.Find(id);
                if (sp != null)
                {
                    context.SanPham.Remove(sp);
                }
                context.SaveChanges();
                frmSanPham_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Cập nhật hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (!Directory.Exists(imagesFolder)) Directory.CreateDirectory(imagesFolder);

                    // 1. Giải phóng PictureBox ngay lập tức
                    if (picHinhAnh.Image != null)
                    {
                        picHinhAnh.Image.Dispose();
                        picHinhAnh.Image = null;
                    }

                    // Đảm bảo hệ thống nhả file ra hoàn toàn
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                    string ext = Path.GetExtension(openFileDialog.FileName);
                    string newFile = fileName.GenerateSlug() + ext;
                    string fileSavePath = Path.Combine(imagesFolder, newFile);

                    // 2. THAY THẾ File.Copy BẰNG CÁCH GHI BYTE (Tránh lỗi File in use)
                    byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);
                    File.WriteAllBytes(fileSavePath, imageBytes);

                    // 3. Hiển thị lại ảnh lên PictureBox (Dùng MemoryStream để không khóa file mới)
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        picHinhAnh.Image = Image.FromStream(ms);
                    }

                    // 4. Cập nhật Database
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value);
                    var sp = context.SanPham.Find(id);
                    if (sp != null)
                    {
                        sp.HinhAnh = newFile;
                        context.SaveChanges();
                    }

                    // 5. Load lại Grid
                    frmSanPham_Load(sender, e);
                    MessageBox.Show("Cập nhật ảnh thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi hệ thống");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                // Lấy tên file ảnh từ ô "HinhAnh" của dòng đang chọn
                var cellValue = dataGridView.CurrentRow.Cells["HinhAnh"].Value;

                if (cellValue != null && !string.IsNullOrWhiteSpace(cellValue.ToString()))
                {
                    string fullPath = Path.Combine(imagesFolder, cellValue.ToString());

                    if (File.Exists(fullPath))
                    {
                        // Giải phóng ảnh cũ trước khi nạp ảnh mới
                        if (picHinhAnh.Image != null) picHinhAnh.Image.Dispose();

                        // Nạp ảnh qua MemoryStream để KHÔNG khóa file
                        using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                        {
                            MemoryStream ms = new MemoryStream();
                            fs.CopyTo(ms);
                            ms.Seek(0, SeekOrigin.Begin);
                            picHinhAnh.Image = Image.FromStream(ms);
                        }
                        return;
                    }
                }
            }
            // Nếu không có ảnh hoặc file không tồn tại
            if (picHinhAnh.Image != null) picHinhAnh.Image.Dispose();
            picHinhAnh.Image = null;
        }
    }
}

