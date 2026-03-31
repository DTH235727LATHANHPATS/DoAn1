using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffe.Data
{
    public class ChiTietHoaDon
    {
        public int ID { get; set; }

        public int HoaDonID { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public int NhanVienID { get; set; }
        public string HoVaTenNhanVien { get; set; } // Thêm

        public int SanPhamID { get; set; }
        public virtual SanPham SanPham { get; set; }
        public int BanID { get; set; }
        public virtual Ban TenBan { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
    }
    [NotMapped]
    public class DanhSachHoaDon_ChiTiet
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int SanPhamID { get; set; }
        public string TenSanPham { get; set; } // Thêm
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public int ThanhTien { get; set; } // Thêm
    }
}
