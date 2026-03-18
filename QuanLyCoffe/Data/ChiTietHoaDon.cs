using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        public int SanPhamID { get; set; }
        public virtual SanPham SanPham { get; set; }

        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
    }
}
