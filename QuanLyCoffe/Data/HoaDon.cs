using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffe.Data
{
    public class HoaDon
    {
        public int ID { get; set; }

        public int BanID { get; set; }
        public virtual Ban Ban { get; set; }

        public int NhanVienID { get; set; }
        public virtual NhanVien NhanVien { get; set; }

        public DateTime NgayLap { get; set; }
        public decimal TongTien { get; set; }

        public virtual ObservableCollectionListSource<ChiTietHoaDon> ChiTietHoaDon { get; } = new();
    }
}
