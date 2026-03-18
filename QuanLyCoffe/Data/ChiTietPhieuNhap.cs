using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffe.Data
{
    public class ChiTietPhieuNhap
    {
        public int ID { get; set; }

        public int PhieuNhapID { get; set; }
        public virtual PhieuNhap PhieuNhap { get; set; }

        public int NguyenLieuID { get; set; }
        public virtual NguyenLieu NguyenLieu { get; set; }

        public double SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
    }
}
