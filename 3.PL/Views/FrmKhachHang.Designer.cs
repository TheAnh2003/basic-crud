namespace _3.PresentationLayers
{
    partial class FrmKhachHang
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
            this.tbx_Ten = new System.Windows.Forms.TextBox();
            this.tbx_TimKiem = new System.Windows.Forms.TextBox();
            this.tbx_Ma = new System.Windows.Forms.TextBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.lbl_Ten = new System.Windows.Forms.Label();
            this.lbl_Ma = new System.Windows.Forms.Label();
            this.dgrid_KhachHang = new System.Windows.Forms.DataGridView();
            this.tbx_Ho = new System.Windows.Forms.TextBox();
            this.tbx_TenDem = new System.Windows.Forms.TextBox();
            this.lbl_Ho = new System.Windows.Forms.Label();
            this.lbl_TenDem = new System.Windows.Forms.Label();
            this.tbx_DiaChi = new System.Windows.Forms.TextBox();
            this.tbx_SDT = new System.Windows.Forms.TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.tbx_QuocGia = new System.Windows.Forms.TextBox();
            this.tbx_ThanhPho = new System.Windows.Forms.TextBox();
            this.lbl_QuocGia = new System.Windows.Forms.Label();
            this.lbl_ThanhPho = new System.Windows.Forms.Label();
            this.tbx_MatKhau = new System.Windows.Forms.TextBox();
            this.lbl_matKhau = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(606, 132);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(172, 41);
            this.btn_Xoa.TabIndex = 19;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(606, 76);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(172, 41);
            this.btn_Sua.TabIndex = 18;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Thêm
            // 
            this.btn_Thêm.Location = new System.Drawing.Point(606, 20);
            this.btn_Thêm.Name = "btn_Thêm";
            this.btn_Thêm.Size = new System.Drawing.Size(172, 41);
            this.btn_Thêm.TabIndex = 17;
            this.btn_Thêm.Text = "Thêm";
            this.btn_Thêm.UseVisualStyleBackColor = true;
            this.btn_Thêm.Click += new System.EventHandler(this.btn_Thêm_Click);
            // 
            // tbx_Ten
            // 
            this.tbx_Ten.Location = new System.Drawing.Point(90, 53);
            this.tbx_Ten.Name = "tbx_Ten";
            this.tbx_Ten.Size = new System.Drawing.Size(144, 27);
            this.tbx_Ten.TabIndex = 16;
            // 
            // tbx_TimKiem
            // 
            this.tbx_TimKiem.Location = new System.Drawing.Point(649, 204);
            this.tbx_TimKiem.Name = "tbx_TimKiem";
            this.tbx_TimKiem.Size = new System.Drawing.Size(129, 27);
            this.tbx_TimKiem.TabIndex = 15;
            this.tbx_TimKiem.TextChanged += new System.EventHandler(this.tbx_TimKiem_TextChanged);
            // 
            // tbx_Ma
            // 
            this.tbx_Ma.Location = new System.Drawing.Point(90, 5);
            this.tbx_Ma.Name = "tbx_Ma";
            this.tbx_Ma.Size = new System.Drawing.Size(144, 27);
            this.tbx_Ma.TabIndex = 14;
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(571, 207);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(72, 20);
            this.lbl_TimKiem.TabIndex = 13;
            this.lbl_TimKiem.Text = "Tìm Kiếm";
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.Location = new System.Drawing.Point(8, 56);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(32, 20);
            this.lbl_Ten.TabIndex = 12;
            this.lbl_Ten.Text = "Tên";
            // 
            // lbl_Ma
            // 
            this.lbl_Ma.AutoSize = true;
            this.lbl_Ma.Location = new System.Drawing.Point(8, 8);
            this.lbl_Ma.Name = "lbl_Ma";
            this.lbl_Ma.Size = new System.Drawing.Size(30, 20);
            this.lbl_Ma.TabIndex = 11;
            this.lbl_Ma.Text = "Mã";
            // 
            // dgrid_KhachHang
            // 
            this.dgrid_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_KhachHang.Location = new System.Drawing.Point(12, 237);
            this.dgrid_KhachHang.Name = "dgrid_KhachHang";
            this.dgrid_KhachHang.RowHeadersWidth = 51;
            this.dgrid_KhachHang.RowTemplate.Height = 29;
            this.dgrid_KhachHang.Size = new System.Drawing.Size(776, 188);
            this.dgrid_KhachHang.TabIndex = 10;
            this.dgrid_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_KhachHang_CellClick);
            // 
            // tbx_Ho
            // 
            this.tbx_Ho.Location = new System.Drawing.Point(90, 157);
            this.tbx_Ho.Name = "tbx_Ho";
            this.tbx_Ho.Size = new System.Drawing.Size(144, 27);
            this.tbx_Ho.TabIndex = 23;
            // 
            // tbx_TenDem
            // 
            this.tbx_TenDem.Location = new System.Drawing.Point(90, 102);
            this.tbx_TenDem.Name = "tbx_TenDem";
            this.tbx_TenDem.Size = new System.Drawing.Size(144, 27);
            this.tbx_TenDem.TabIndex = 22;
            // 
            // lbl_Ho
            // 
            this.lbl_Ho.AutoSize = true;
            this.lbl_Ho.Location = new System.Drawing.Point(8, 160);
            this.lbl_Ho.Name = "lbl_Ho";
            this.lbl_Ho.Size = new System.Drawing.Size(29, 20);
            this.lbl_Ho.TabIndex = 21;
            this.lbl_Ho.Text = "Họ";
            // 
            // lbl_TenDem
            // 
            this.lbl_TenDem.AutoSize = true;
            this.lbl_TenDem.Location = new System.Drawing.Point(8, 105);
            this.lbl_TenDem.Name = "lbl_TenDem";
            this.lbl_TenDem.Size = new System.Drawing.Size(68, 20);
            this.lbl_TenDem.TabIndex = 20;
            this.lbl_TenDem.Text = "Tên Đệm";
            // 
            // tbx_DiaChi
            // 
            this.tbx_DiaChi.Location = new System.Drawing.Point(392, 56);
            this.tbx_DiaChi.Name = "tbx_DiaChi";
            this.tbx_DiaChi.Size = new System.Drawing.Size(144, 27);
            this.tbx_DiaChi.TabIndex = 27;
            // 
            // tbx_SDT
            // 
            this.tbx_SDT.Location = new System.Drawing.Point(392, 8);
            this.tbx_SDT.Name = "tbx_SDT";
            this.tbx_SDT.Size = new System.Drawing.Size(144, 27);
            this.tbx_SDT.TabIndex = 26;
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(312, 59);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(57, 20);
            this.lbl_DiaChi.TabIndex = 25;
            this.lbl_DiaChi.Text = "Địa Chỉ";
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Location = new System.Drawing.Point(312, 11);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(36, 20);
            this.lbl_SDT.TabIndex = 24;
            this.lbl_SDT.Text = "SĐT";
            // 
            // tbx_QuocGia
            // 
            this.tbx_QuocGia.Location = new System.Drawing.Point(392, 160);
            this.tbx_QuocGia.Name = "tbx_QuocGia";
            this.tbx_QuocGia.Size = new System.Drawing.Size(144, 27);
            this.tbx_QuocGia.TabIndex = 31;
            // 
            // tbx_ThanhPho
            // 
            this.tbx_ThanhPho.Location = new System.Drawing.Point(392, 105);
            this.tbx_ThanhPho.Name = "tbx_ThanhPho";
            this.tbx_ThanhPho.Size = new System.Drawing.Size(144, 27);
            this.tbx_ThanhPho.TabIndex = 30;
            // 
            // lbl_QuocGia
            // 
            this.lbl_QuocGia.AutoSize = true;
            this.lbl_QuocGia.Location = new System.Drawing.Point(312, 163);
            this.lbl_QuocGia.Name = "lbl_QuocGia";
            this.lbl_QuocGia.Size = new System.Drawing.Size(70, 20);
            this.lbl_QuocGia.TabIndex = 29;
            this.lbl_QuocGia.Text = "Quốc Gia";
            // 
            // lbl_ThanhPho
            // 
            this.lbl_ThanhPho.AutoSize = true;
            this.lbl_ThanhPho.Location = new System.Drawing.Point(312, 108);
            this.lbl_ThanhPho.Name = "lbl_ThanhPho";
            this.lbl_ThanhPho.Size = new System.Drawing.Size(78, 20);
            this.lbl_ThanhPho.TabIndex = 28;
            this.lbl_ThanhPho.Text = "Thành Phố";
            // 
            // tbx_MatKhau
            // 
            this.tbx_MatKhau.Location = new System.Drawing.Point(392, 204);
            this.tbx_MatKhau.Name = "tbx_MatKhau";
            this.tbx_MatKhau.Size = new System.Drawing.Size(144, 27);
            this.tbx_MatKhau.TabIndex = 35;
            // 
            // lbl_matKhau
            // 
            this.lbl_matKhau.AutoSize = true;
            this.lbl_matKhau.Location = new System.Drawing.Point(312, 207);
            this.lbl_matKhau.Name = "lbl_matKhau";
            this.lbl_matKhau.Size = new System.Drawing.Size(72, 20);
            this.lbl_matKhau.TabIndex = 34;
            this.lbl_matKhau.Text = "Mật Khẩu";
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Location = new System.Drawing.Point(8, 204);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(76, 20);
            this.lbl_NgaySinh.TabIndex = 32;
            this.lbl_NgaySinh.Text = "Ngày Sinh";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.Location = new System.Drawing.Point(90, 202);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(144, 27);
            this.dtp_NgaySinh.TabIndex = 36;
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtp_NgaySinh);
            this.Controls.Add(this.tbx_MatKhau);
            this.Controls.Add(this.lbl_matKhau);
            this.Controls.Add(this.lbl_NgaySinh);
            this.Controls.Add(this.tbx_QuocGia);
            this.Controls.Add(this.tbx_ThanhPho);
            this.Controls.Add(this.lbl_QuocGia);
            this.Controls.Add(this.lbl_ThanhPho);
            this.Controls.Add(this.tbx_DiaChi);
            this.Controls.Add(this.tbx_SDT);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.lbl_SDT);
            this.Controls.Add(this.tbx_Ho);
            this.Controls.Add(this.tbx_TenDem);
            this.Controls.Add(this.lbl_Ho);
            this.Controls.Add(this.lbl_TenDem);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Thêm);
            this.Controls.Add(this.tbx_Ten);
            this.Controls.Add(this.tbx_TimKiem);
            this.Controls.Add(this.tbx_Ma);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.lbl_Ten);
            this.Controls.Add(this.lbl_Ma);
            this.Controls.Add(this.dgrid_KhachHang);
            this.Name = "FrmKhachHang";
            this.Text = "FrmKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_KhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Thêm;
        private System.Windows.Forms.TextBox tbx_Ten;
        private System.Windows.Forms.TextBox tbx_TimKiem;
        private System.Windows.Forms.TextBox tbx_Ma;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.Label lbl_Ten;
        private System.Windows.Forms.Label lbl_Ma;
        private System.Windows.Forms.DataGridView dgrid_KhachHang;
        private System.Windows.Forms.TextBox tbx_Ho;
        private System.Windows.Forms.TextBox tbx_TenDem;
        private System.Windows.Forms.Label lbl_Ho;
        private System.Windows.Forms.Label lbl_TenDem;
        private System.Windows.Forms.TextBox tbx_DiaChi;
        private System.Windows.Forms.TextBox tbx_SDT;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.TextBox tbx_QuocGia;
        private System.Windows.Forms.TextBox tbx_ThanhPho;
        private System.Windows.Forms.Label lbl_QuocGia;
        private System.Windows.Forms.Label lbl_ThanhPho;
        private System.Windows.Forms.TextBox tbx_MatKhau;
        private System.Windows.Forms.Label lbl_matKhau;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
    }
}