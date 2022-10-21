namespace _3.PresentationLayers
{
    partial class FrmNsx
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
            this.dgrid_Nsx = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.lbl_Ma = new System.Windows.Forms.Label();
            this.lbl_Tên = new System.Windows.Forms.Label();
            this.tbx_Ma = new System.Windows.Forms.TextBox();
            this.tbx_Ten = new System.Windows.Forms.TextBox();
            this.tbx_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TImKiem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Nsx)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_Nsx
            // 
            this.dgrid_Nsx.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_Nsx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Nsx.Location = new System.Drawing.Point(12, 219);
            this.dgrid_Nsx.Name = "dgrid_Nsx";
            this.dgrid_Nsx.RowHeadersWidth = 51;
            this.dgrid_Nsx.RowTemplate.Height = 29;
            this.dgrid_Nsx.Size = new System.Drawing.Size(776, 219);
            this.dgrid_Nsx.TabIndex = 0;
            this.dgrid_Nsx.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_Nsx_CellContentClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(585, 30);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(170, 44);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(585, 87);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(170, 44);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(585, 147);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(170, 44);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // lbl_Ma
            // 
            this.lbl_Ma.AutoSize = true;
            this.lbl_Ma.Location = new System.Drawing.Point(38, 22);
            this.lbl_Ma.Name = "lbl_Ma";
            this.lbl_Ma.Size = new System.Drawing.Size(30, 20);
            this.lbl_Ma.TabIndex = 4;
            this.lbl_Ma.Text = "Mã";
            // 
            // lbl_Tên
            // 
            this.lbl_Tên.AutoSize = true;
            this.lbl_Tên.Location = new System.Drawing.Point(38, 87);
            this.lbl_Tên.Name = "lbl_Tên";
            this.lbl_Tên.Size = new System.Drawing.Size(32, 20);
            this.lbl_Tên.TabIndex = 5;
            this.lbl_Tên.Text = "Tên";
            // 
            // tbx_Ma
            // 
            this.tbx_Ma.Location = new System.Drawing.Point(134, 22);
            this.tbx_Ma.Name = "tbx_Ma";
            this.tbx_Ma.Size = new System.Drawing.Size(161, 27);
            this.tbx_Ma.TabIndex = 6;
            // 
            // tbx_Ten
            // 
            this.tbx_Ten.Location = new System.Drawing.Point(134, 84);
            this.tbx_Ten.Name = "tbx_Ten";
            this.tbx_Ten.Size = new System.Drawing.Size(161, 27);
            this.tbx_Ten.TabIndex = 7;
            // 
            // tbx_TimKiem
            // 
            this.tbx_TimKiem.Location = new System.Drawing.Point(134, 176);
            this.tbx_TimKiem.Name = "tbx_TimKiem";
            this.tbx_TimKiem.Size = new System.Drawing.Size(200, 27);
            this.tbx_TimKiem.TabIndex = 8;
            this.tbx_TimKiem.TextChanged += new System.EventHandler(this.tbx_TimKiem_TextChanged);
            // 
            // lbl_TImKiem
            // 
            this.lbl_TImKiem.AutoSize = true;
            this.lbl_TImKiem.Location = new System.Drawing.Point(38, 179);
            this.lbl_TImKiem.Name = "lbl_TImKiem";
            this.lbl_TImKiem.Size = new System.Drawing.Size(72, 20);
            this.lbl_TImKiem.TabIndex = 9;
            this.lbl_TImKiem.Text = "Tìm Kiếm";
            // 
            // FrmNsx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_TImKiem);
            this.Controls.Add(this.tbx_TimKiem);
            this.Controls.Add(this.tbx_Ten);
            this.Controls.Add(this.tbx_Ma);
            this.Controls.Add(this.lbl_Tên);
            this.Controls.Add(this.lbl_Ma);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgrid_Nsx);
            this.Name = "FrmNsx";
            this.Text = "FrmNsx";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Nsx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_Nsx;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label lbl_Ma;
        private System.Windows.Forms.Label lbl_Tên;
        private System.Windows.Forms.TextBox tbx_Ma;
        private System.Windows.Forms.TextBox tbx_Ten;
        private System.Windows.Forms.TextBox tbx_TimKiem;
        private System.Windows.Forms.Label lbl_TImKiem;
    }
}