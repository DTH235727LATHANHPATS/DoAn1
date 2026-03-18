using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffe.Data
{
    public class NguyenLieu
    {
        public int ID { get; set; }
        public string TenNguyenLieu { get; set; }
        public string DonViTinh { get; set; }
        public double SoLuongTon { get; set; }

        public int NhaCungCapID { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }

        public virtual ObservableCollectionListSource<ChiTietPhieuNhap> ChiTietPhieuNhap { get; } = new();
    }
}
