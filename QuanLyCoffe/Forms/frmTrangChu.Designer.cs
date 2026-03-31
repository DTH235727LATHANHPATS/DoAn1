namespace QuanLyCoffe.Forms
{
    partial class frmTrangChu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            pictureBox1 = new PictureBox();
            lblDongHo = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1164, 421);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblDongHo
            // 
            lblDongHo.AutoSize = true;
            lblDongHo.BackColor = Color.Transparent;
            lblDongHo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblDongHo.ForeColor = Color.Blue;
            lblDongHo.Location = new Point(12, 310);
            lblDongHo.Name = "lblDongHo";
            lblDongHo.Size = new Size(185, 54);
            lblDongHo.TabIndex = 1;
            lblDongHo.Text = "Đồng hồ";
            // 
            // frmTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 421);
            Controls.Add(lblDongHo);
            Controls.Add(pictureBox1);
            Name = "frmTrangChu";
            Text = "frmTrangChu";
            Load += frmTrangChu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblDongHo;
        private System.Windows.Forms.Timer timer1;
    }
}