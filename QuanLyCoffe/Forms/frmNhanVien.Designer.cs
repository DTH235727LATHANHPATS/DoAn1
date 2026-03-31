namespace QuanLyCoffe.Forms
{
    partial class frmNhanVien
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
            txtGioiTinh = new TextBox();
            label7 = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboChucVu = new ComboBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            txtDiaChi = new TextBox();
            txtDienThoai = new TextBox();
            txtTenNhanVien = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            IDc = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGioiTinh);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cboChucVu);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtTenNhanVien);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1060, 232);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(107, 177);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(184, 27);
            txtGioiTinh.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 180);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 21;
            label7.Text = "Giới tính:";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(936, 127);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 29);
            btnXuat.TabIndex = 20;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(936, 82);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 29);
            btnNhap.TabIndex = 19;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(936, 33);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 18;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(797, 126);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(797, 79);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(94, 29);
            btnHuyBo.TabIndex = 16;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(797, 33);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(652, 128);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(652, 79);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(652, 33);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Items.AddRange(new object[] { "Phục Vụ", "Pha Chế", "Quản Lý" });
            cboChucVu.Location = new Point(452, 129);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(151, 28);
            cboChucVu.TabIndex = 11;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(450, 79);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(152, 27);
            txtMatKhau.TabIndex = 10;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(450, 33);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(153, 27);
            txtTenDangNhap.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(105, 127);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(186, 27);
            txtDiaChi.TabIndex = 8;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(106, 75);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(185, 27);
            txtDienThoai.TabIndex = 7;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(106, 26);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(185, 27);
            txtTenNhanVien.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(317, 130);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 5;
            label6.Text = "Quyền hạn(*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 82);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 4;
            label5.Text = "Mật khẩu(*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 42);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 3;
            label4.Text = "Tên đăng nhập(*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 130);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 82);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "Điện thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và Tên(*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(6, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1060, 283);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { IDc, TenNhanVien, DiaChi, TenDangNhap, ChucVu, GioiTinh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1054, 257);
            dataGridView.TabIndex = 0;
            // 
            // IDc
            // 
            IDc.DataPropertyName = "ID";
            IDc.HeaderText = "ID";
            IDc.MinimumWidth = 6;
            IDc.Name = "IDc";
            // 
            // TenNhanVien
            // 
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Họ và Tên";
            TenNhanVien.MinimumWidth = 6;
            TenNhanVien.Name = "TenNhanVien";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên Đăng Nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            // 
            // ChucVu
            // 
            ChucVu.DataPropertyName = "ChucVu";
            ChucVu.HeaderText = "Quyền Hạn";
            ChucVu.MinimumWidth = 6;
            ChucVu.Name = "ChucVu";
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Phái";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 584);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            Text = "Nhân Viên";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboChucVu;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private TextBox txtDiaChi;
        private TextBox txtDienThoai;
        private TextBox txtTenNhanVien;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private TextBox txtGioiTinh;
        private Label label7;
        private DataGridViewTextBoxColumn IDc;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn ChucVu;
        private DataGridViewTextBoxColumn GioiTinh;
    }
}