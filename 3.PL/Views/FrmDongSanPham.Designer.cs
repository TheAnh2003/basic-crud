namespace _3.PresentationLayers
{
    partial class FrmDongSanPham
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
            this.dgrid_DongSp = new System.Windows.Forms.DataGridView();
            this.lbl_Ma = new System.Windows.Forms.Label();
            this.lbl_Ten = new System.Windows.Forms.Label();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.tbx_Ma = new System.Windows.Forms.TextBox();
            this.tbx_TimKiem = new System.Windows.Forms.TextBox();
            this.tbx_Ten = new System.Windows.Forms.TextBox();
            this.btn_Thêm = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_DongSp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_DongSp
            // 
            this.dgrid_DongSp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_DongSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_DongSp.Location = new System.Drawing.Point(12, 250);
            this.dgrid_DongSp.Name = "dgrid_DongSp";
            this.dgrid_DongSp.RowHeadersWidth = 51;
            this.dgrid_DongSp.RowTemplate.Height = 29;
            this.dgrid_DongSp.Size = new System.Drawing.Size(776, 188);
            this.dgrid_DongSp.TabIndex = 0;
            this.dgrid_DongSp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_DongSp_CellContentClick);
            // 
            // lbl_Ma
            // 
            this.lbl_Ma.AutoSize = true;
            this.lbl_Ma.Location = new System.Drawing.Point(58, 46);
            this.lbl_Ma.Name = "lbl_Ma";
            this.lbl_Ma.Size = new System.Drawing.Size(30, 20);
            this.lbl_Ma.TabIndex = 1;
            this.lbl_Ma.Text = "Mã";
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.Location = new System.Drawing.Point(58, 102);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(32, 20);
            this.lbl_Ten.TabIndex = 2;
            this.lbl_Ten.Text = "Tên";
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(58, 215);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(72, 20);
            this.lbl_TimKiem.TabIndex = 3;
            this.lbl_TimKiem.Text = "Tìm Kiếm";
            // 
            // tbx_Ma
            // 
            this.tbx_Ma.Location = new System.Drawing.Point(162, 39);
            this.tbx_Ma.Name = "tbx_Ma";
            this.tbx_Ma.Size = new System.Drawing.Size(176, 27);
            this.tbx_Ma.TabIndex = 4;
            // 
            // tbx_TimKiem
            // 
            this.tbx_TimKiem.Location = new System.Drawing.Point(162, 212);
            this.tbx_TimKiem.Name = "tbx_TimKiem";
            this.tbx_TimKiem.Size = new System.Drawing.Size(176, 27);
            this.tbx_TimKiem.TabIndex = 5;
            this.tbx_TimKiem.TextChanged += new System.EventHandler(this.tbx_TimKiem_TextChanged);
            // 
            // tbx_Ten
            // 
            this.tbx_Ten.Location = new System.Drawing.Point(162, 99);
            this.tbx_Ten.Name = "tbx_Ten";
            this.tbx_Ten.Size = new System.Drawing.Size(176, 27);
            this.tbx_Ten.TabIndex = 6;
            // 
            // btn_Thêm
            // 
            this.btn_Thêm.Location = new System.Drawing.Point(523, 39);
            this.btn_Thêm.Name = "btn_Thêm";
            this.btn_Thêm.Size = new System.Drawing.Size(182, 47);
            this.btn_Thêm.TabIndex = 7;
            this.btn_Thêm.Text = "Thêm";
            this.btn_Thêm.UseVisualStyleBackColor = true;
            this.btn_Thêm.Click += new System.EventHandler(this.btn_Thêm_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(523, 107);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(182, 47);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(523, 176);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(182, 47);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // FrmDongSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Thêm);
            this.Controls.Add(this.tbx_Ten);
            this.Controls.Add(this.tbx_TimKiem);
            this.Controls.Add(this.tbx_Ma);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.lbl_Ten);
            this.Controls.Add(this.lbl_Ma);
            this.Controls.Add(this.dgrid_DongSp);
            this.Name = "FrmDongSanPham";
            this.Text = "FrmDongSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_DongSp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_DongSp;
        private System.Windows.Forms.Label lbl_Ma;
        private System.Windows.Forms.Label lbl_Ten;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.TextBox tbx_Ma;
        private System.Windows.Forms.TextBox tbx_TimKiem;
        private System.Windows.Forms.TextBox tbx_Ten;
        private System.Windows.Forms.Button btn_Thêm;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
    }
}