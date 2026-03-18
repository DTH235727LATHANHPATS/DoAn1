using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffe.Data
{
    public class PhieuNhap
    {
        public int ID { get; set; }

        public int NhaCungCapID { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }

        public DateTime NgayNhap { get; set; }
        public decimal TongTien { get; set; }

        public virtual ObservableCollectionListSource<ChiTietPhieuNhap> ChiTietPhieuNhap { get; } = new();
    }
}
