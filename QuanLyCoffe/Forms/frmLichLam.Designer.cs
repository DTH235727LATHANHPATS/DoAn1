namespace QuanLyCoffe.Forms
{
    partial class frmLichLam
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
            dataGridView = new DataGridView();
            CaLam = new DataGridViewTextBoxColumn();
            ThuHai = new DataGridViewTextBoxColumn();
            ThuBa = new DataGridViewTextBoxColumn();
            ThuTu = new DataGridViewTextBoxColumn();
            ThuNam = new DataGridViewTextBoxColumn();
            ThuSau = new DataGridViewTextBoxColumn();
            ThuBay = new DataGridViewTextBoxColumn();
            ChuNhat = new DataGridViewTextBoxColumn();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { CaLam, ThuHai, ThuBa, ThuTu, ThuNam, ThuSau, ThuBay, ChuNhat });
            dataGridView.Location = new Point(12, 75);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1053, 294);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // CaLam
            // 
            CaLam.DataPropertyName = "CaLam";
            CaLam.HeaderText = "Ca Làm";
            CaLam.MinimumWidth = 6;
            CaLam.Name = "CaLam";
            CaLam.Width = 125;
            // 
            // ThuHai
            // 
            ThuHai.DataPropertyName = "ThuHai";
            ThuHai.HeaderText = "Thứ Hai";
            ThuHai.MinimumWidth = 6;
            ThuHai.Name = "ThuHai";
            ThuHai.Width = 125;
            // 
            // ThuBa
            // 
            ThuBa.DataPropertyName = "ThuBa";
            ThuBa.HeaderText = "Thứ Ba";
            ThuBa.MinimumWidth = 6;
            ThuBa.Name = "ThuBa";
            ThuBa.Width = 125;
            // 
            // ThuTu
            // 
            ThuTu.DataPropertyName = "ThuTu";
            ThuTu.HeaderText = "Thứ Tư";
            ThuTu.MinimumWidth = 6;
            ThuTu.Name = "ThuTu";
            ThuTu.Width = 125;
            // 
            // ThuNam
            // 
            ThuNam.DataPropertyName = "ThuNam";
            ThuNam.HeaderText = "Thứ Năm";
            ThuNam.MinimumWidth = 6;
            ThuNam.Name = "ThuNam";
            ThuNam.Width = 125;
            // 
            // ThuSau
            // 
            ThuSau.DataPropertyName = "ThuSau";
            ThuSau.HeaderText = "Thứ Sáu";
            ThuSau.MinimumWidth = 6;
            ThuSau.Name = "ThuSau";
            ThuSau.Width = 125;
            // 
            // ThuBay
            // 
            ThuBay.DataPropertyName = "ThuBay";
            ThuBay.HeaderText = "Thứ Bảy";
            ThuBay.MinimumWidth = 6;
            ThuBay.Name = "ThuBay";
            ThuBay.Width = 125;
            // 
            // ChuNhat
            // 
            ChuNhat.DataPropertyName = "ChuNhat";
            ChuNhat.HeaderText = "Chủ Nhật";
            ChuNhat.MinimumWidth = 6;
            ChuNhat.Name = "ChuNhat";
            ChuNhat.Width = 125;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(41, 387);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // frmLichLam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 480);
            Controls.Add(btnThem);
            Controls.Add(dataGridView);
            Name = "frmLichLam";
            Text = "Lịch Làm";
            Load += frmLichLam_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn CaLam;
        private DataGridViewTextBoxColumn ThuHai;
        private DataGridViewTextBoxColumn ThuBa;
        private DataGridViewTextBoxColumn ThuTu;
        private DataGridViewTextBoxColumn ThuNam;
        private DataGridViewTextBoxColumn ThuSau;
        private DataGridViewTextBoxColumn ThuBay;
        private DataGridViewTextBoxColumn ChuNhat;
        private Button btnThem;
    }
}