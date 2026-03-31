using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffe.Data
{
    internal class LichLam
    {
        public int ID { get; set; }

        public int NhanVienID { get; set; }  // khóa ngoại
        public String  NgayLam { get; set; }
        public string CaLam { get; set; }    // "6h-11h", "11h-15h",...

        public virtual NhanVien NhanVien { get; set; }
    }
}
