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
    public partial class frmLichLam : Form
    {
        QLCFDbContext context = new QLCFDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa)
        
        public frmLichLam()
        {
            InitializeComponent();
        }

        private void frmLichLam_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            HienThiLichLam();
        }
        public void HienThiLichLam()
        {
            dataGridView.Rows.Clear();

            // Danh sách ca cố định
            List<string> dsCa = new List<string>()
            {
                "6h-11h",
                "11h-15h",
                "15h-18h",
                "18h-21h"
            };

            // Tạo dòng cho từng ca
            foreach (var ca in dsCa)
            {
                int rowIndex = dataGridView.Rows.Add();
                dataGridView.Rows[rowIndex].Cells["CaLam"].Value = ca;
            }

            // Lấy dữ liệu từ DB
            var ds = context.PhanCongNhanVien
                            .Select(x => new
                            {
                                TenNhanVien = x.NhanVien.TenNhanVien,
                                x.CaLam,
                                x.NgayLam
                            })
                            .ToList();

            // Đổ dữ liệu vào bảng
            foreach (var item in ds)
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.Cells["CaLam"].Value?.ToString() == item.CaLam)
                    {
                        string cot = "";

                        switch (item.NgayLam.Trim())
                        {
                            case "Thứ Hai": cot = "ThuHai"; break;
                            case "Thứ Ba": cot = "ThuBa"; break;
                            case "Thứ Tư": cot = "ThuTu"; break;
                            case "Thứ Năm": cot = "ThuNam"; break;
                            case "Thứ Sáu": cot = "ThuSau"; break;
                            case "Thứ Bảy": cot = "ThuBay"; break;
                            case "Chủ Nhật": cot = "ChuNhat"; break;
                        }

                        if (!string.IsNullOrEmpty(cot))
                        {
                            // Nếu đã có người thì nối thêm (tránh bị ghi đè)
                            var giaTriCu = row.Cells[cot].Value?.ToString();
                            if (string.IsNullOrEmpty(giaTriCu))
                                row.Cells[cot].Value = item.TenNhanVien;
                            else
                                row.Cells[cot].Value = giaTriCu + ", " + item.TenNhanVien;
                        }
                    }
                }
            }
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn ô lịch cần thêm!");
                return;
            }

            int row = dataGridView.CurrentCell.RowIndex;
            int col = dataGridView.CurrentCell.ColumnIndex;

            string tenCot = dataGridView.Columns[col].Name;

            if (tenCot == "CaLam")
            {
                MessageBox.Show("Vui lòng chọn ô lịch!");
                return;
            }

            // Lấy ca làm
            string caLam = dataGridView.Rows[row].Cells["CaLam"].Value.ToString();

            // Xác định ngày
            string ngayLam = "";
            switch (tenCot)
            {
                case "ThuHai": ngayLam = "Thứ Hai"; break;
                case "ThuBa": ngayLam = "Thứ Ba"; break;
                case "ThuTu": ngayLam = "Thứ Tư"; break;
                case "ThuNam": ngayLam = "Thứ Năm"; break;
                case "ThuSau": ngayLam = "Thứ Sáu"; break;
                case "ThuBay": ngayLam = "Thứ Bảy"; break;
                case "ChuNhat": ngayLam = "Chủ Nhật"; break;
            }

            // 👉 Mở form chọn nhân viên
            frmPhanCongNhanVien f = new frmPhanCongNhanVien();

            if (f.ShowDialog() == DialogResult.OK)
            {
                int nhanVienID = f.NhanVienID;

                // Kiểm tra trùng
                bool trung = context.PhanCongNhanVien.Any(x =>
                    x.NhanVienID == nhanVienID &&
                    x.CaLam == caLam &&
                    x.NgayLam == ngayLam);

                if (trung)
                {
                    MessageBox.Show("Phân công này đã tồn tại!");
                    return;
                }

                // Thêm vào DB
                PhanCongNhanVien pc = new PhanCongNhanVien();
                pc.NhanVienID = nhanVienID;
                pc.CaLam = caLam;
                pc.NgayLam = ngayLam;

                context.PhanCongNhanVien.Add(pc);
                context.SaveChanges();

                // Load lại lịch
                HienThiLichLam();

                MessageBox.Show("Thêm thành công!");
            }
        }
    }
}
