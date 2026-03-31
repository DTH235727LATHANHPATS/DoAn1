using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffe.Data
{
    public class NhanVien
    {
        public int ID { get; set; }
        public string TenNhanVien { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public bool ChucVu { get; set; }
        public string TenDangNhap { get; set; }

        public string MatKhau { get; set; }

        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
        public virtual ObservableCollectionListSource<PhanCongNhanVien> PhanCongNhanVien { get; } = new();
    }
}
