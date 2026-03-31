namespace QuanLyCoffe.Forms
{
    partial class frmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NhanVien = new DataGridViewTextBoxColumn();
            Ban = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            ChiTiet = new DataGridViewTextBoxColumn();
            button1 = new Button();
            btnInHoaDon = new Button();
            btnTimKiem = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnXuat = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1070, 336);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, NhanVien, Ban, NgayLap, TongTien, ChiTiet });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1064, 310);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // NhanVien
            // 
            NhanVien.DataPropertyName = "NhanVien";
            NhanVien.HeaderText = "Nhân Viên";
            NhanVien.MinimumWidth = 6;
            NhanVien.Name = "NhanVien";
            // 
            // Ban
            // 
            Ban.DataPropertyName = "Ban";
            Ban.HeaderText = "Bàn";
            Ban.MinimumWidth = 6;
            Ban.Name = "Ban";
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            NgayLap.HeaderText = "Ngày Lập";
            NgayLap.MinimumWidth = 6;
            NgayLap.Name = "NgayLap";
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            TongTien.HeaderText = "Tổng Tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            // 
            // ChiTiet
            // 
            ChiTiet.DataPropertyName = "ChiTiet";
            ChiTiet.HeaderText = "Chi Tiết";
            ChiTiet.MinimumWidth = 6;
            ChiTiet.Name = "ChiTiet";
            // 
            // button1
            // 
            button1.Location = new Point(91, 387);
            button1.Name = "button1";
            button1.Size = new Size(132, 29);
            button1.TabIndex = 1;
            button1.Text = "Lập hóa đơn mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(249, 387);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(94, 29);
            btnInHoaDon.TabIndex = 2;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(727, 387);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(374, 387);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(491, 387);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(601, 387);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(848, 387);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 7;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 446);
            Controls.Add(btnXuat);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnTimKiem);
            Controls.Add(btnInHoaDon);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa Đơn";
            Load += frmHoaDon_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView;
        private Button button1;
        private Button btnInHoaDon;
        private Button btnTimKiem;
        private Button btnSua;
        private Button btnThoat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NhanVien;
        private DataGridViewTextBoxColumn Ban;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn ChiTiet;
        private Button btnXoa;
        private Button btnXuat;
    }
}