namespace QuanLyCoffe.Forms
{
    partial class frmPhanCongNhanVien
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
            cboNgayLam = new ComboBox();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            cboCaLam = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            cboTenNhanVien = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            CaLam = new DataGridViewTextBoxColumn();
            NgayLam = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboNgayLam);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cboCaLam);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboTenNhanVien);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(17, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1037, 162);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi Tiết Phân Công";
            // 
            // cboNgayLam
            // 
            cboNgayLam.FormattingEnabled = true;
            cboNgayLam.Items.AddRange(new object[] { "Thứ Hai", "Thứ Ba", "Thứ Tư", "Thứ Năm", "Thứ Sáu ", "Thứ Bảy", "Chủ Nhật" });
            cboNgayLam.Location = new Point(403, 32);
            cboNgayLam.Name = "cboNgayLam";
            cboNgayLam.Size = new Size(159, 28);
            cboNgayLam.TabIndex = 30;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(918, 105);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 29;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(803, 105);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 28;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(692, 105);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 27;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(918, 70);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 26;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(803, 70);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 25;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(692, 70);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 24;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(918, 35);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 23;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(803, 35);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(692, 35);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 21;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cboCaLam
            // 
            cboCaLam.FormattingEnabled = true;
            cboCaLam.Items.AddRange(new object[] { "6h_12h", "12h_18h", "18h_22h" });
            cboCaLam.Location = new Point(114, 85);
            cboCaLam.Name = "cboCaLam";
            cboCaLam.Size = new Size(151, 28);
            cboCaLam.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(299, 38);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 5;
            label4.Text = "Ngày làm(*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 92);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 4;
            label3.Text = "Ca làm(*):";
            // 
            // cboTenNhanVien
            // 
            cboTenNhanVien.FormattingEnabled = true;
            cboTenNhanVien.Location = new Point(114, 35);
            cboTenNhanVien.Name = "cboTenNhanVien";
            cboTenNhanVien.Size = new Size(151, 28);
            cboTenNhanVien.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và Tên(*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(16, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1038, 218);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lịch làm";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenNhanVien, CaLam, NgayLam });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1032, 192);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Tên Nhân Viên";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            // 
            // CaLam
            // 
            CaLam.DataPropertyName = "CaLam";
            CaLam.HeaderText = "Ca Làm";
            CaLam.MinimumWidth = 6;
            CaLam.Name = "CaLam";
            // 
            // NgayLam
            // 
            NgayLam.DataPropertyName = "NgayLam";
            NgayLam.HeaderText = "Ngày Làm";
            NgayLam.MinimumWidth = 6;
            NgayLam.Name = "NgayLam";
            // 
            // frmPhanCongNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 509);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmPhanCongNhanVien";
            Text = "Phân Công Nhân Viên";
            Load += frmPhanCongNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox cboTenNhanVien;
        private ComboBox cboCaLam;
        private Label label4;
        private Label label3;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private ComboBox cboNgayLam;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn CaLam;
        private DataGridViewTextBoxColumn NgayLam;
    }
}