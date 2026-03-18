using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffe.Data
{
    public class Ban
    {
        public int ID { get; set; }
        public string TenBan { get; set; }
        public string TrangThai { get; set; }

        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
        public virtual ObservableCollectionListSource<PhanCongNhanVien> PhanCongNhanVien { get; } = new();
    }
}
