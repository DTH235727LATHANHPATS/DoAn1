using Microsoft.Reporting.WinForms;
using QuanLyCoffe.Data;
using System;
using System.Collections.Generic;
//using System.ComponentModel.Design;
//using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoffe.Reports
{
    public partial class frmThongKeSanPham : Form
    {

        public frmThongKeSanPham()
        {
            InitializeComponent();
        }
        QLCFDbContext context = new QLCFDbContext();
        QLCFDataSet.DanhSachSanPhamDataTable danhSachSanPhamDataTable = new QLCFDataSet.DanhSachSanPhamDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net5.0-windows", "Reports");
        private void frmThongKeSanPham_Load(object sender, EventArgs e)
        {

            var danhSachSanPham = context.SanPham.Select(r => new DanhSachSanPham
            {
                ID = r.ID,
                LoaiSanPhamID = r.LoaiSanPhamID,
                TenLoai = r.LoaiSanPham.TenLoai,
                TenSanPham = r.TenSanPham,
                Gia = r.Gia,
                HinhAnh = r.HinhAnh,
                MoTa = r.MoTa
            }).ToList();
            danhSachSanPhamDataTable.Clear();
            foreach (var row in danhSachSanPham)
            {
                danhSachSanPhamDataTable.AddDanhSachSanPhamRow(
                row.ID,
                row.LoaiSanPhamID,
                row.TenLoai,
                row.TenSanPham,
                row.Gia,
                row.HinhAnh,
                row.MoTa);
            }
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachSanPham";
            reportDataSource.Value = danhSachSanPhamDataTable;
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeSanPham.rdlc");
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();

        }
    }
}