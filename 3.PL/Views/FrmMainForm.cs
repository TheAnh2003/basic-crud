using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3.PL.Utility;
using _3.PL.View;
using _3.PL.Views;

namespace _3.PL.Views
{
    public partial class FrmMainForm : Form
    {
        //fields
        public Button Currentbutton;
        public Random random;
        private int TempIndex;
        private Form ActivityForm;
        //contructor
        public FrmMainForm()
        {
            InitializeComponent();
            random = new Random();
        }
        //method
        private Color Selectthemecolor()
        {
            int index=random.Next(ThemeColor.Colorlist.Count);
            while (TempIndex == index)
            {
               index= random.Next(ThemeColor.Colorlist.Count);
            }
            TempIndex = index;
            string color=ThemeColor.Colorlist[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivityButton(object btnSender)
        {
            if(btnSender!= null)
            {
                if (Currentbutton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Selectthemecolor();
                    Currentbutton = (Button)btnSender;
                    Currentbutton.BackColor = color;
                    Currentbutton.ForeColor = Color.White;
                    panelTitlebar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }


        private void openchildform(Form childform, object btnSender)
        {
            if (ActivityForm !=null)
            {
                ActivityForm.Close();
               
            }
                ActivityButton(btnSender);
                ActivityForm = childform;
                childform.TopLevel = false;
                childform.FormBorderStyle=FormBorderStyle.None;
                childform.Dock = DockStyle.Fill;
                this.panelDesktoppanel.Controls.Add(childform);
                this.panelDesktoppanel.Tag = childform;
                childform.BringToFront();
                childform.Show();
                lblTitle.Text = childform.Text;
        }
        private void btn_Chitietsp_Click(object sender, EventArgs e)
        {
            openchildform(new FrmQLChiTietSP(), sender);
        }

        private void btn_chucvu_Click(object sender, EventArgs e)
        {
            openchildform(new FrmQLChucVu(), sender);
        }

        private void btn_cuahang_Click(object sender, EventArgs e)
        {
            openchildform(new FrmQLCuaHang(), sender);
        }

        private void btn_Dongsp_Click(object sender, EventArgs e)
        {
            openchildform(new FrmQLDongSp(), sender);
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            openchildform(new FrmHoaDon(), sender);
        }

        private void btn_hoadonchitiet_Click(object sender, EventArgs e)
        {
            openchildform(new FrmHoaDonChiTiet(), sender);
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            openchildform(new FrmQlKhachHang(), sender);
        }

        private void btn_mausac_Click(object sender, EventArgs e)
        {
            openchildform(new FrmQLMauSac(), sender);
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            openchildform(new FrmQLNhanVien(), sender);
        }

        private void btn_Nsx_Click(object sender, EventArgs e)
        {
            openchildform(new FrmQLNsx(), sender);
        }

        private void btn_Sanpham_Click(object sender, EventArgs e)
        {
            openchildform(new FrmQLSanPham(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openchildform(new FrmQLGioHang(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openchildform(new FrmGioHangChiTiet(), sender);
        }
    }
}
