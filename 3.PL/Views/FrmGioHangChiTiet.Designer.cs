namespace _3.PresentationLayers
{
    partial class FrmGioHangChiTiet
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
            this.dgrid_GioHangChiTiet = new System.Windows.Forms.DataGridView();
            this.tbx_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.lbl_MaGH = new System.Windows.Forms.Label();
            this.lbl_MaSP = new System.Windows.Forms.Label();
            this.cmb_MaSp = new System.Windows.Forms.ComboBox();
            this.lbl_DonGiaKhiGiam = new System.Windows.Forms.Label();
            this.tbx_DonGiaKhiGiam = new System.Windows.Forms.TextBox();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.tbx_SoLuong = new System.Windows.Forms.TextBox();
            this.cmb_MaGh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_GioHangChiTiet)).BeginInit();
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
            // dgrid_GioHangChiTiet
            // 
            this.dgrid_GioHangChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_GioHangChiTiet.Location = new System.Drawing.Point(12, 237);
            this.dgrid_GioHangChiTiet.Name = "dgrid_GioHangChiTiet";
            this.dgrid_GioHangChiTiet.RowHeadersWidth = 51;
            this.dgrid_GioHangChiTiet.RowTemplate.Height = 29;
            this.dgrid_GioHangChiTiet.Size = new System.Drawing.Size(776, 188);
            this.dgrid_GioHangChiTiet.TabIndex = 10;
            this.dgrid_GioHangChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_GioHangChiTiet_CellClick);
            // 
            // tbx_TimKiem
            // 
            this.tbx_TimKiem.Location = new System.Drawing.Point(142, 196);
            this.tbx_TimKiem.Name = "tbx_TimKiem";
            this.tbx_TimKiem.Size = new System.Drawing.Size(135, 27);
            this.tbx_TimKiem.TabIndex = 28;
            this.tbx_TimKiem.TextChanged += new System.EventHandler(this.tbx_TimKiem_TextChanged);
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(12, 199);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(72, 20);
            this.lbl_TimKiem.TabIndex = 26;
            this.lbl_TimKiem.Text = "Tìm Kiếm";
            // 
            // lbl_MaGH
            // 
            this.lbl_MaGH.AutoSize = true;
            this.lbl_MaGH.Location = new System.Drawing.Point(12, 26);
            this.lbl_MaGH.Name = "lbl_MaGH";
            this.lbl_MaGH.Size = new System.Drawing.Size(97, 20);
            this.lbl_MaGH.TabIndex = 24;
            this.lbl_MaGH.Text = "Mã Giỏ Hàng";
            // 
            // lbl_MaSP
            // 
            this.lbl_MaSP.AutoSize = true;
            this.lbl_MaSP.Location = new System.Drawing.Point(12, 69);
            this.lbl_MaSP.Name = "lbl_MaSP";
            this.lbl_MaSP.Size = new System.Drawing.Size(51, 20);
            this.lbl_MaSP.TabIndex = 34;
            this.lbl_MaSP.Text = "Mã Sp";
            // 
            // cmb_MaSp
            // 
            this.cmb_MaSp.FormattingEnabled = true;
            this.cmb_MaSp.Location = new System.Drawing.Point(142, 69);
            this.cmb_MaSp.Name = "cmb_MaSp";
            this.cmb_MaSp.Size = new System.Drawing.Size(135, 28);
            this.cmb_MaSp.TabIndex = 35;
            // 
            // lbl_DonGiaKhiGiam
            // 
            this.lbl_DonGiaKhiGiam.AutoSize = true;
            this.lbl_DonGiaKhiGiam.Location = new System.Drawing.Point(12, 121);
            this.lbl_DonGiaKhiGiam.Name = "lbl_DonGiaKhiGiam";
            this.lbl_DonGiaKhiGiam.Size = new System.Drawing.Size(127, 20);
            this.lbl_DonGiaKhiGiam.TabIndex = 36;
            this.lbl_DonGiaKhiGiam.Text = "Đơn Giá Khi Giảm";
            // 
            // tbx_DonGiaKhiGiam
            // 
            this.tbx_DonGiaKhiGiam.Location = new System.Drawing.Point(142, 118);
            this.tbx_DonGiaKhiGiam.Name = "tbx_DonGiaKhiGiam";
            this.tbx_DonGiaKhiGiam.Size = new System.Drawing.Size(135, 27);
            this.tbx_DonGiaKhiGiam.TabIndex = 37;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(12, 163);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(72, 20);
            this.lbl_SoLuong.TabIndex = 41;
            this.lbl_SoLuong.Text = "Số Lượng";
            // 
            // tbx_SoLuong
            // 
            this.tbx_SoLuong.Location = new System.Drawing.Point(142, 160);
            this.tbx_SoLuong.Name = "tbx_SoLuong";
            this.tbx_SoLuong.Size = new System.Drawing.Size(135, 27);
            this.tbx_SoLuong.TabIndex = 40;
            // 
            // cmb_MaGh
            // 
            this.cmb_MaGh.FormattingEnabled = true;
            this.cmb_MaGh.Location = new System.Drawing.Point(142, 23);
            this.cmb_MaGh.Name = "cmb_MaGh";
            this.cmb_MaGh.Size = new System.Drawing.Size(135, 28);
            this.cmb_MaGh.TabIndex = 42;
            // 
            // FrmGioHangChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_MaGh);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.tbx_SoLuong);
            this.Controls.Add(this.tbx_DonGiaKhiGiam);
            this.Controls.Add(this.lbl_DonGiaKhiGiam);
            this.Controls.Add(this.cmb_MaSp);
            this.Controls.Add(this.lbl_MaSP);
            this.Controls.Add(this.tbx_TimKiem);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.lbl_MaGH);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Thêm);
            this.Controls.Add(this.dgrid_GioHangChiTiet);
            this.Name = "FrmGioHangChiTiet";
            this.Text = "FrmGioHangChiTiet";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_GioHangChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Thêm;
        private System.Windows.Forms.DataGridView dgrid_GioHangChiTiet;
        private System.Windows.Forms.TextBox tbx_TimKiem;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.Label lbl_MaGH;
        private System.Windows.Forms.Label lbl_MaSP;
        private System.Windows.Forms.ComboBox cmb_MaSp;
        private System.Windows.Forms.Label lbl_DonGiaKhiGiam;
        private System.Windows.Forms.TextBox tbx_DonGiaKhiGiam;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.TextBox tbx_SoLuong;
        private System.Windows.Forms.ComboBox cmb_MaGh;
    }
}