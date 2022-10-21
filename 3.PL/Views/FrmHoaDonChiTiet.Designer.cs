namespace _3.PresentationLayers
{
    partial class FrmHoaDonChiTiet
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
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Thêm = new System.Windows.Forms.Button();
            this.tbx_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.lbl_MaHD = new System.Windows.Forms.Label();
            this.dgrid_HoaDonChiTiet = new System.Windows.Forms.DataGridView();
            this.lbl_MaSP = new System.Windows.Forms.Label();
            this.cmb_MaSp = new System.Windows.Forms.ComboBox();
            this.cmb_MaHD = new System.Windows.Forms.ComboBox();
            this.tbx_SoLuong = new System.Windows.Forms.TextBox();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDonChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(523, 163);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(182, 47);
            this.btn_Xoa.TabIndex = 19;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(523, 94);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(182, 47);
            this.btn_Sua.TabIndex = 18;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Thêm
            // 
            this.btn_Thêm.Location = new System.Drawing.Point(523, 26);
            this.btn_Thêm.Name = "btn_Thêm";
            this.btn_Thêm.Size = new System.Drawing.Size(182, 47);
            this.btn_Thêm.TabIndex = 17;
            this.btn_Thêm.Text = "Thêm";
            this.btn_Thêm.UseVisualStyleBackColor = true;
            this.btn_Thêm.Click += new System.EventHandler(this.btn_Thêm_Click);
            // 
            // tbx_TimKiem
            // 
            this.tbx_TimKiem.Location = new System.Drawing.Point(162, 199);
            this.tbx_TimKiem.Name = "tbx_TimKiem";
            this.tbx_TimKiem.Size = new System.Drawing.Size(176, 27);
            this.tbx_TimKiem.TabIndex = 15;
            this.tbx_TimKiem.TextChanged += new System.EventHandler(this.tbx_TimKiem_TextChanged);
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(32, 202);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(72, 20);
            this.lbl_TimKiem.TabIndex = 13;
            this.lbl_TimKiem.Text = "Tìm Kiếm";
            // 
            // lbl_MaHD
            // 
            this.lbl_MaHD.AutoSize = true;
            this.lbl_MaHD.Location = new System.Drawing.Point(32, 29);
            this.lbl_MaHD.Name = "lbl_MaHD";
            this.lbl_MaHD.Size = new System.Drawing.Size(94, 20);
            this.lbl_MaHD.TabIndex = 11;
            this.lbl_MaHD.Text = "Mã Hóa Đơn";
            // 
            // dgrid_HoaDonChiTiet
            // 
            this.dgrid_HoaDonChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_HoaDonChiTiet.Location = new System.Drawing.Point(12, 237);
            this.dgrid_HoaDonChiTiet.Name = "dgrid_HoaDonChiTiet";
            this.dgrid_HoaDonChiTiet.RowHeadersWidth = 51;
            this.dgrid_HoaDonChiTiet.RowTemplate.Height = 29;
            this.dgrid_HoaDonChiTiet.Size = new System.Drawing.Size(776, 188);
            this.dgrid_HoaDonChiTiet.TabIndex = 10;
            this.dgrid_HoaDonChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_HoaDonChiTiet_CellClick);
            // 
            // lbl_MaSP
            // 
            this.lbl_MaSP.AutoSize = true;
            this.lbl_MaSP.Location = new System.Drawing.Point(32, 66);
            this.lbl_MaSP.Name = "lbl_MaSP";
            this.lbl_MaSP.Size = new System.Drawing.Size(50, 20);
            this.lbl_MaSP.TabIndex = 22;
            this.lbl_MaSP.Text = "Mã SP";
            // 
            // cmb_MaSp
            // 
            this.cmb_MaSp.FormattingEnabled = true;
            this.cmb_MaSp.Location = new System.Drawing.Point(162, 66);
            this.cmb_MaSp.Name = "cmb_MaSp";
            this.cmb_MaSp.Size = new System.Drawing.Size(176, 28);
            this.cmb_MaSp.TabIndex = 36;
            // 
            // cmb_MaHD
            // 
            this.cmb_MaHD.FormattingEnabled = true;
            this.cmb_MaHD.Location = new System.Drawing.Point(162, 21);
            this.cmb_MaHD.Name = "cmb_MaHD";
            this.cmb_MaHD.Size = new System.Drawing.Size(176, 28);
            this.cmb_MaHD.TabIndex = 37;
            // 
            // tbx_SoLuong
            // 
            this.tbx_SoLuong.Location = new System.Drawing.Point(162, 118);
            this.tbx_SoLuong.Name = "tbx_SoLuong";
            this.tbx_SoLuong.Size = new System.Drawing.Size(176, 27);
            this.tbx_SoLuong.TabIndex = 38;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(32, 121);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(72, 20);
            this.lbl_SoLuong.TabIndex = 39;
            this.lbl_SoLuong.Text = "Số Lượng";
            // 
            // FrmHoaDonChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.tbx_SoLuong);
            this.Controls.Add(this.cmb_MaHD);
            this.Controls.Add(this.cmb_MaSp);
            this.Controls.Add(this.lbl_MaSP);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Thêm);
            this.Controls.Add(this.tbx_TimKiem);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.lbl_MaHD);
            this.Controls.Add(this.dgrid_HoaDonChiTiet);
            this.Name = "FrmHoaDonChiTiet";
            this.Text = "FrmHoaDonChiTiet";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDonChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Thêm;
        private System.Windows.Forms.TextBox tbx_TimKiem;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.Label lbl_MaHD;
        private System.Windows.Forms.DataGridView dgrid_HoaDonChiTiet;
        private System.Windows.Forms.Label lbl_MaSP;
        private System.Windows.Forms.ComboBox cmb_MaSp;
        private System.Windows.Forms.ComboBox cmb_MaHD;
        private System.Windows.Forms.TextBox tbx_SoLuong;
        private System.Windows.Forms.Label lbl_SoLuong;
    }
}