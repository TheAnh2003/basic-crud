namespace _3.PresentationLayers
{
    partial class FrmChiTietSp
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
            this.lbl_Nsx = new System.Windows.Forms.Label();
            this.lbl_SanPham = new System.Windows.Forms.Label();
            this.dgrid_ChiTietSp = new System.Windows.Forms.DataGridView();
            this.lbl_DongSP = new System.Windows.Forms.Label();
            this.lbl_MauSac = new System.Windows.Forms.Label();
            this.tbx_GiaBan = new System.Windows.Forms.TextBox();
            this.tbx_GiaNhap = new System.Windows.Forms.TextBox();
            this.lbl_GiaBan = new System.Windows.Forms.Label();
            this.lbl_GiaNhap = new System.Windows.Forms.Label();
            this.tbx_SLTon = new System.Windows.Forms.TextBox();
            this.tbx_MoTa = new System.Windows.Forms.TextBox();
            this.lbl_SLTon = new System.Windows.Forms.Label();
            this.lbl_MoTa = new System.Windows.Forms.Label();
            this.tbx_NamBH = new System.Windows.Forms.TextBox();
            this.lbl_NamBH = new System.Windows.Forms.Label();
            this.cmb_NhaSx = new System.Windows.Forms.ComboBox();
            this.cmb_SanPham = new System.Windows.Forms.ComboBox();
            this.cmb_MauSac = new System.Windows.Forms.ComboBox();
            this.cmb_DongSp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChiTietSp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(606, 155);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(182, 47);
            this.btn_Xoa.TabIndex = 19;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(606, 86);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(182, 47);
            this.btn_Sua.TabIndex = 18;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Thêm
            // 
            this.btn_Thêm.Location = new System.Drawing.Point(606, 18);
            this.btn_Thêm.Name = "btn_Thêm";
            this.btn_Thêm.Size = new System.Drawing.Size(182, 47);
            this.btn_Thêm.TabIndex = 17;
            this.btn_Thêm.Text = "Thêm";
            this.btn_Thêm.UseVisualStyleBackColor = true;
            this.btn_Thêm.Click += new System.EventHandler(this.btn_Thêm_Click);
            // 
            // tbx_TimKiem
            // 
            this.tbx_TimKiem.Location = new System.Drawing.Point(612, 235);
            this.tbx_TimKiem.Name = "tbx_TimKiem";
            this.tbx_TimKiem.Size = new System.Drawing.Size(176, 27);
            this.tbx_TimKiem.TabIndex = 15;
            this.tbx_TimKiem.TextChanged += new System.EventHandler(this.tbx_TimKiem_TextChanged);
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(525, 238);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(72, 20);
            this.lbl_TimKiem.TabIndex = 13;
            this.lbl_TimKiem.Text = "Tìm Kiếm";
            // 
            // lbl_Nsx
            // 
            this.lbl_Nsx.AutoSize = true;
            this.lbl_Nsx.Location = new System.Drawing.Point(10, 68);
            this.lbl_Nsx.Name = "lbl_Nsx";
            this.lbl_Nsx.Size = new System.Drawing.Size(57, 20);
            this.lbl_Nsx.TabIndex = 12;
            this.lbl_Nsx.Text = "Nhà SX";
            // 
            // lbl_SanPham
            // 
            this.lbl_SanPham.AutoSize = true;
            this.lbl_SanPham.Location = new System.Drawing.Point(10, 15);
            this.lbl_SanPham.Name = "lbl_SanPham";
            this.lbl_SanPham.Size = new System.Drawing.Size(74, 20);
            this.lbl_SanPham.TabIndex = 11;
            this.lbl_SanPham.Text = "Sản Phẩm";
            // 
            // dgrid_ChiTietSp
            // 
            this.dgrid_ChiTietSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_ChiTietSp.Location = new System.Drawing.Point(12, 268);
            this.dgrid_ChiTietSp.Name = "dgrid_ChiTietSp";
            this.dgrid_ChiTietSp.RowHeadersWidth = 51;
            this.dgrid_ChiTietSp.RowTemplate.Height = 29;
            this.dgrid_ChiTietSp.Size = new System.Drawing.Size(776, 157);
            this.dgrid_ChiTietSp.TabIndex = 10;
            this.dgrid_ChiTietSp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_ChiTietSp_CellContentClick);
            // 
            // lbl_DongSP
            // 
            this.lbl_DongSP.AutoSize = true;
            this.lbl_DongSP.Location = new System.Drawing.Point(11, 174);
            this.lbl_DongSP.Name = "lbl_DongSP";
            this.lbl_DongSP.Size = new System.Drawing.Size(66, 20);
            this.lbl_DongSP.TabIndex = 25;
            this.lbl_DongSP.Text = "Dòng SP";
            // 
            // lbl_MauSac
            // 
            this.lbl_MauSac.AutoSize = true;
            this.lbl_MauSac.Location = new System.Drawing.Point(11, 121);
            this.lbl_MauSac.Name = "lbl_MauSac";
            this.lbl_MauSac.Size = new System.Drawing.Size(65, 20);
            this.lbl_MauSac.TabIndex = 24;
            this.lbl_MauSac.Text = "Màu Sắc";
            // 
            // tbx_GiaBan
            // 
            this.tbx_GiaBan.Location = new System.Drawing.Point(353, 174);
            this.tbx_GiaBan.Name = "tbx_GiaBan";
            this.tbx_GiaBan.Size = new System.Drawing.Size(140, 27);
            this.tbx_GiaBan.TabIndex = 35;
            // 
            // tbx_GiaNhap
            // 
            this.tbx_GiaNhap.Location = new System.Drawing.Point(351, 121);
            this.tbx_GiaNhap.Name = "tbx_GiaNhap";
            this.tbx_GiaNhap.Size = new System.Drawing.Size(140, 27);
            this.tbx_GiaNhap.TabIndex = 34;
            // 
            // lbl_GiaBan
            // 
            this.lbl_GiaBan.AutoSize = true;
            this.lbl_GiaBan.Location = new System.Drawing.Point(278, 177);
            this.lbl_GiaBan.Name = "lbl_GiaBan";
            this.lbl_GiaBan.Size = new System.Drawing.Size(60, 20);
            this.lbl_GiaBan.TabIndex = 33;
            this.lbl_GiaBan.Text = "Giá Bán";
            // 
            // lbl_GiaNhap
            // 
            this.lbl_GiaNhap.AutoSize = true;
            this.lbl_GiaNhap.Location = new System.Drawing.Point(278, 124);
            this.lbl_GiaNhap.Name = "lbl_GiaNhap";
            this.lbl_GiaNhap.Size = new System.Drawing.Size(71, 20);
            this.lbl_GiaNhap.TabIndex = 32;
            this.lbl_GiaNhap.Text = "Giá Nhập";
            // 
            // tbx_SLTon
            // 
            this.tbx_SLTon.Location = new System.Drawing.Point(349, 68);
            this.tbx_SLTon.Name = "tbx_SLTon";
            this.tbx_SLTon.Size = new System.Drawing.Size(140, 27);
            this.tbx_SLTon.TabIndex = 31;
            // 
            // tbx_MoTa
            // 
            this.tbx_MoTa.Location = new System.Drawing.Point(349, 15);
            this.tbx_MoTa.Name = "tbx_MoTa";
            this.tbx_MoTa.Size = new System.Drawing.Size(140, 27);
            this.tbx_MoTa.TabIndex = 30;
            // 
            // lbl_SLTon
            // 
            this.lbl_SLTon.AutoSize = true;
            this.lbl_SLTon.Location = new System.Drawing.Point(278, 68);
            this.lbl_SLTon.Name = "lbl_SLTon";
            this.lbl_SLTon.Size = new System.Drawing.Size(53, 20);
            this.lbl_SLTon.TabIndex = 29;
            this.lbl_SLTon.Text = "SL Tồn";
            // 
            // lbl_MoTa
            // 
            this.lbl_MoTa.AutoSize = true;
            this.lbl_MoTa.Location = new System.Drawing.Point(280, 18);
            this.lbl_MoTa.Name = "lbl_MoTa";
            this.lbl_MoTa.Size = new System.Drawing.Size(51, 20);
            this.lbl_MoTa.TabIndex = 28;
            this.lbl_MoTa.Text = "Mô Tả";
            // 
            // tbx_NamBH
            // 
            this.tbx_NamBH.Location = new System.Drawing.Point(94, 217);
            this.tbx_NamBH.Name = "tbx_NamBH";
            this.tbx_NamBH.Size = new System.Drawing.Size(140, 27);
            this.tbx_NamBH.TabIndex = 37;
            // 
            // lbl_NamBH
            // 
            this.lbl_NamBH.AutoSize = true;
            this.lbl_NamBH.Location = new System.Drawing.Point(12, 220);
            this.lbl_NamBH.Name = "lbl_NamBH";
            this.lbl_NamBH.Size = new System.Drawing.Size(65, 20);
            this.lbl_NamBH.TabIndex = 36;
            this.lbl_NamBH.Text = "Năm BH";
            // 
            // cmb_NhaSx
            // 
            this.cmb_NhaSx.FormattingEnabled = true;
            this.cmb_NhaSx.Location = new System.Drawing.Point(94, 65);
            this.cmb_NhaSx.Name = "cmb_NhaSx";
            this.cmb_NhaSx.Size = new System.Drawing.Size(151, 28);
            this.cmb_NhaSx.TabIndex = 38;
            // 
            // cmb_SanPham
            // 
            this.cmb_SanPham.FormattingEnabled = true;
            this.cmb_SanPham.Location = new System.Drawing.Point(94, 12);
            this.cmb_SanPham.Name = "cmb_SanPham";
            this.cmb_SanPham.Size = new System.Drawing.Size(151, 28);
            this.cmb_SanPham.TabIndex = 39;
            // 
            // cmb_MauSac
            // 
            this.cmb_MauSac.FormattingEnabled = true;
            this.cmb_MauSac.Location = new System.Drawing.Point(94, 118);
            this.cmb_MauSac.Name = "cmb_MauSac";
            this.cmb_MauSac.Size = new System.Drawing.Size(151, 28);
            this.cmb_MauSac.TabIndex = 40;
            // 
            // cmb_DongSp
            // 
            this.cmb_DongSp.FormattingEnabled = true;
            this.cmb_DongSp.Location = new System.Drawing.Point(94, 171);
            this.cmb_DongSp.Name = "cmb_DongSp";
            this.cmb_DongSp.Size = new System.Drawing.Size(151, 28);
            this.cmb_DongSp.TabIndex = 41;
            // 
            // FrmChiTietSp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_DongSp);
            this.Controls.Add(this.cmb_MauSac);
            this.Controls.Add(this.cmb_SanPham);
            this.Controls.Add(this.cmb_NhaSx);
            this.Controls.Add(this.tbx_NamBH);
            this.Controls.Add(this.lbl_NamBH);
            this.Controls.Add(this.tbx_GiaBan);
            this.Controls.Add(this.tbx_GiaNhap);
            this.Controls.Add(this.lbl_GiaBan);
            this.Controls.Add(this.lbl_GiaNhap);
            this.Controls.Add(this.tbx_SLTon);
            this.Controls.Add(this.tbx_MoTa);
            this.Controls.Add(this.lbl_SLTon);
            this.Controls.Add(this.lbl_MoTa);
            this.Controls.Add(this.lbl_DongSP);
            this.Controls.Add(this.lbl_MauSac);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Thêm);
            this.Controls.Add(this.tbx_TimKiem);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.lbl_Nsx);
            this.Controls.Add(this.lbl_SanPham);
            this.Controls.Add(this.dgrid_ChiTietSp);
            this.Name = "FrmChiTietSp";
            this.Text = "FrmChiTietSp";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChiTietSp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Thêm;
        private System.Windows.Forms.TextBox tbx_TimKiem;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.Label lbl_Nsx;
        private System.Windows.Forms.Label lbl_SanPham;
        private System.Windows.Forms.DataGridView dgrid_ChiTietSp;
        private System.Windows.Forms.Label lbl_DongSP;
        private System.Windows.Forms.Label lbl_MauSac;
        private System.Windows.Forms.TextBox tbx_GiaBan;
        private System.Windows.Forms.TextBox tbx_GiaNhap;
        private System.Windows.Forms.Label lbl_GiaBan;
        private System.Windows.Forms.Label lbl_GiaNhap;
        private System.Windows.Forms.TextBox tbx_SLTon;
        private System.Windows.Forms.TextBox tbx_MoTa;
        private System.Windows.Forms.Label lbl_SLTon;
        private System.Windows.Forms.Label lbl_MoTa;
        private System.Windows.Forms.TextBox tbx_NamBH;
        private System.Windows.Forms.Label lbl_NamBH;
        private System.Windows.Forms.ComboBox cmb_NhaSx;
        private System.Windows.Forms.ComboBox cmb_SanPham;
        private System.Windows.Forms.ComboBox cmb_MauSac;
        private System.Windows.Forms.ComboBox cmb_DongSp;
    }
}