using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyCoffe.Data
{
    public class SanPham
    {
        public int ID { get; set; }
        public string TenSanPham { get; set; }
        public int Gia { get; set; }
        public string? HinhAnh { get; set; }  // Đường dẫn hình ảnh

        public string? MoTa { get; set; }     // Mô tả sản phẩm

        public int LoaiSanPhamID { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }

        public virtual ObservableCollectionListSource<ChiTietHoaDon> ChiTietHoaDon { get; } = new();
    }
    [NotMapped]
    public class DanhSachSanPham
    {
        public int ID { get; set; }

        public int LoaiSanPhamID { get; set; }

        public string TenLoai { get; set; }  // Lấy từ bảng LoaiSanPham

        public string TenSanPham { get; set; }

        public decimal Gia { get; set; }

        public string? HinhAnh { get; set; }  // Đường dẫn hình ảnh

        public string? MoTa { get; set; }     // Mô tả sản phẩm
    }
}
