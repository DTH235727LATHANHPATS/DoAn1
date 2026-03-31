using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoffe.Forms
{
    public partial class frmTrangChu : Form
    {
        
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            frmTrangChu_Resize(null, null);
            // Cài đặt timer
            timer1.Interval = 1000; // 1 giây
            timer1.Tick += Timer_Tick;
            timer1.Start();
            lblDongHo.BackColor = Color.FromArgb(150, 0, 0, 0); // nền mờ
            lblDongHo.ForeColor = Color.White;
            lblDongHo.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblDongHo.AutoSize = true;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            lblDongHo.Text = DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy");
        }
        private void frmTrangChu_Resize(object sender, EventArgs e)
        {
            lblDongHo.Left = 20;
            lblDongHo.Top = this.Height - lblDongHo.Height - 40;
        }
    }
}
