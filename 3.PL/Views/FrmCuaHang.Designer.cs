namespace _3.PresentationLayers
{
    partial class FrmCuaHang
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
            this.dgrid_CuaHang = new System.Windows.Forms.DataGridView();
            this.tbx_ThanhPho = new System.Windows.Forms.TextBox();
            this.tbx_DiaChi = new System.Windows.Forms.TextBox();
            this.lbl_ThanhPho = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.tbx_QuocGia = new System.Windows.Forms.TextBox();
            this.lbl_QuocGia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_CuaHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(628, 143);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(150, 39);
            this.btn_Xoa.TabIndex = 19;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(628, 74);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(150, 39);
            this.btn_Sua.TabIndex = 18;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Thêm
            // 
            this.btn_Thêm.Location = new System.Drawing.Point(628, 6);
            this.btn_Thêm.Name = "btn_Thêm";
            this.btn_Thêm.Size = new System.Drawing.Size(150, 39);
            this.btn_Thêm.TabIndex = 17;
            this.btn_Thêm.Text = "Thêm";
            this.btn_Thêm.UseVisualStyleBackColor = true;
            this.btn_Thêm.Click += new System.EventHandler(this.btn_Thêm_Click);
            // 
            // tbx_Ten
            // 
            this.tbx_Ten.Location = new System.Drawing.Point(113, 82);
            this.tbx_Ten.Name = "tbx_Ten";
            this.tbx_Ten.Size = new System.Drawing.Size(176, 27);
            this.tbx_Ten.TabIndex = 16;
            // 
            // tbx_TimKiem
            // 
            this.tbx_TimKiem.Location = new System.Drawing.Point(603, 202);
            this.tbx_TimKiem.Name = "tbx_TimKiem";
            this.tbx_TimKiem.Size = new System.Drawing.Size(176, 27);
            this.tbx_TimKiem.TabIndex = 15;
            this.tbx_TimKiem.TextChanged += new System.EventHandler(this.tbx_TimKiem_TextChanged);
            // 
            // tbx_Ma
            // 
            this.tbx_Ma.Location = new System.Drawing.Point(113, 26);
            this.tbx_Ma.Name = "tbx_Ma";
            this.tbx_Ma.Size = new System.Drawing.Size(176, 27);
            this.tbx_Ma.TabIndex = 14;
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(499, 205);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(72, 20);
            this.lbl_TimKiem.TabIndex = 13;
            this.lbl_TimKiem.Text = "Tìm Kiếm";
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.Location = new System.Drawing.Point(27, 85);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(32, 20);
            this.lbl_Ten.TabIndex = 12;
            this.lbl_Ten.Text = "Tên";
            // 
            // lbl_Ma
            // 
            this.lbl_Ma.AutoSize = true;
            this.lbl_Ma.Location = new System.Drawing.Point(27, 29);
            this.lbl_Ma.Name = "lbl_Ma";
            this.lbl_Ma.Size = new System.Drawing.Size(30, 20);
            this.lbl_Ma.TabIndex = 11;
            this.lbl_Ma.Text = "Mã";
            // 
            // dgrid_CuaHang
            // 
            this.dgrid_CuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_CuaHang.Location = new System.Drawing.Point(12, 237);
            this.dgrid_CuaHang.Name = "dgrid_CuaHang";
            this.dgrid_CuaHang.RowHeadersWidth = 51;
            this.dgrid_CuaHang.RowTemplate.Height = 29;
            this.dgrid_CuaHang.Size = new System.Drawing.Size(776, 188);
            this.dgrid_CuaHang.TabIndex = 10;
            this.dgrid_CuaHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_CuaHang_CellClick);
            // 
            // tbx_ThanhPho
            // 
            this.tbx_ThanhPho.Location = new System.Drawing.Point(113, 192);
            this.tbx_ThanhPho.Name = "tbx_ThanhPho";
            this.tbx_ThanhPho.Size = new System.Drawing.Size(176, 27);
            this.tbx_ThanhPho.TabIndex = 23;
            // 
            // tbx_DiaChi
            // 
            this.tbx_DiaChi.Location = new System.Drawing.Point(113, 136);
            this.tbx_DiaChi.Name = "tbx_DiaChi";
            this.tbx_DiaChi.Size = new System.Drawing.Size(176, 27);
            this.tbx_DiaChi.TabIndex = 22;
            // 
            // lbl_ThanhPho
            // 
            this.lbl_ThanhPho.AutoSize = true;
            this.lbl_ThanhPho.Location = new System.Drawing.Point(29, 195);
            this.lbl_ThanhPho.Name = "lbl_ThanhPho";
            this.lbl_ThanhPho.Size = new System.Drawing.Size(78, 20);
            this.lbl_ThanhPho.TabIndex = 21;
            this.lbl_ThanhPho.Text = "Thành Phố";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(29, 139);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(57, 20);
            this.lbl_DiaChi.TabIndex = 20;
            this.lbl_DiaChi.Text = "Địa Chỉ";
            // 
            // tbx_QuocGia
            // 
            this.tbx_QuocGia.Location = new System.Drawing.Point(406, 26);
            this.tbx_QuocGia.Name = "tbx_QuocGia";
            this.tbx_QuocGia.Size = new System.Drawing.Size(176, 27);
            this.tbx_QuocGia.TabIndex = 25;
            // 
            // lbl_QuocGia
            // 
            this.lbl_QuocGia.AutoSize = true;
            this.lbl_QuocGia.Location = new System.Drawing.Point(330, 29);
            this.lbl_QuocGia.Name = "lbl_QuocGia";
            this.lbl_QuocGia.Size = new System.Drawing.Size(70, 20);
            this.lbl_QuocGia.TabIndex = 24;
            this.lbl_QuocGia.Text = "Quốc Gia";
            // 
            // FrmCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_QuocGia);
            this.Controls.Add(this.lbl_QuocGia);
            this.Controls.Add(this.tbx_ThanhPho);
            this.Controls.Add(this.tbx_DiaChi);
            this.Controls.Add(this.lbl_ThanhPho);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Thêm);
            this.Controls.Add(this.tbx_Ten);
            this.Controls.Add(this.tbx_TimKiem);
            this.Controls.Add(this.tbx_Ma);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.lbl_Ten);
            this.Controls.Add(this.lbl_Ma);
            this.Controls.Add(this.dgrid_CuaHang);
            this.Name = "FrmCuaHang";
            this.Text = "FrmCuaHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_CuaHang)).EndInit();
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
        private System.Windows.Forms.DataGridView dgrid_CuaHang;
        private System.Windows.Forms.TextBox tbx_ThanhPho;
        private System.Windows.Forms.TextBox tbx_DiaChi;
        private System.Windows.Forms.Label lbl_ThanhPho;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.TextBox tbx_QuocGia;
        private System.Windows.Forms.Label lbl_QuocGia;
    }
}