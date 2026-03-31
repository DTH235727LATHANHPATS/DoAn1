namespace QuanLyCoffe.Forms
{
    partial class frmHoaDonChiTiet
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
            txtGhiChu = new TextBox();
            cboTenBan = new ComboBox();
            cboTenNhanVien = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnXacNhan = new Button();
            label6 = new Label();
            label5 = new Label();
            numSoLuong = new NumericUpDown();
            numDonGia = new NumericUpDown();
            label4 = new Label();
            cboSanPham = new ComboBox();
            groupBox3 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            SanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            btnLuu = new Button();
            btnInHoaDon = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(cboTenBan);
            groupBox1.Controls.Add(cboTenNhanVien);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(862, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(105, 91);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(715, 27);
            txtGhiChu.TabIndex = 5;
            // 
            // cboTenBan
            // 
            cboTenBan.FormattingEnabled = true;
            cboTenBan.Location = new Point(499, 29);
            cboTenBan.Name = "cboTenBan";
            cboTenBan.Size = new Size(321, 28);
            cboTenBan.TabIndex = 4;
            // 
            // cboTenNhanVien
            // 
            cboTenNhanVien.FormattingEnabled = true;
            cboTenNhanVien.Location = new Point(132, 29);
            cboTenNhanVien.Name = "cboTenNhanVien";
            cboTenNhanVien.Size = new Size(257, 28);
            cboTenNhanVien.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 37);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Số bàn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 98);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Ghi chú:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 37);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên Lập:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnXacNhan);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numSoLuong);
            groupBox2.Controls.Add(numDonGia);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cboSanPham);
            groupBox2.Location = new Point(18, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(858, 113);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết hóa đơn";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(722, 57);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(596, 57);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 6;
            btnXacNhan.Text = "xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(414, 30);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 5;
            label6.Text = "Số lượng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 32);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "Đơn giá:";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(414, 59);
            numSoLuong.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(150, 27);
            numSoLuong.TabIndex = 3;
            numSoLuong.ThousandsSeparator = true;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(221, 59);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(150, 27);
            numDonGia.TabIndex = 2;
            numDonGia.ThousandsSeparator = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 33);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 1;
            label4.Text = "Sản Phẩm:";
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(16, 59);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(163, 28);
            cboSanPham.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView);
            groupBox3.Location = new Point(18, 283);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(859, 193);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách bán";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, SanPham, SoLuong, DonGia, ThanhTien });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(853, 167);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // SanPham
            // 
            SanPham.DataPropertyName = "SanPham";
            SanPham.HeaderText = "Sản Phẩm";
            SanPham.MinimumWidth = 6;
            SanPham.Name = "SanPham";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn Giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(198, 508);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(127, 29);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu hóa đơn";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(375, 508);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(113, 29);
            btnInHoaDon.TabIndex = 4;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(528, 508);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 29);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmHoaDonChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 598);
            Controls.Add(btnThoat);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLuu);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmHoaDonChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi Tiết Hóa Đơn";
            Load += frmHoaDonChiTiet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox cboTenNhanVien;
        private Label label3;
        private Label label2;
        private TextBox txtGhiChu;
        private ComboBox cboTenBan;
        private Label label6;
        private Label label5;
        private NumericUpDown numSoLuong;
        private NumericUpDown numDonGia;
        private Label label4;
        private ComboBox cboSanPham;
        private Button btnXoa;
        private Button btnXacNhan;
        private GroupBox groupBox3;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn SanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
        private Button btnLuu;
        private Button btnInHoaDon;
        private Button btnThoat;
    }
}