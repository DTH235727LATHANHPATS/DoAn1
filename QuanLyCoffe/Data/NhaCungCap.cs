using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffe.Data
{
    public class NhaCungCap
    {
        public int ID { get; set; }
        public string TenNCC { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }

        public virtual ObservableCollectionListSource<NguyenLieu> NguyenLieu { get; } = new();
        public virtual ObservableCollectionListSource<PhieuNhap> PhieuNhap { get; } = new();
    }
}
