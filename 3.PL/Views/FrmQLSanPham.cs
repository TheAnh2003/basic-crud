using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.Services;

namespace _3.PL.Views
{
    public partial class FrmQLSanPham : Form
    {
        private IQLSanPhamDetailService iQLSanPhamService;
        public FrmQLSanPham()
        {
            InitializeComponent();
            iQLSanPhamService = new QLSanPhamDetailService();
            LoadData();
            LoadCMB();
        }
        private void LoadCMB()
        {
            foreach (var x in iQLSanPhamService.GetAll())
            {
                cmb_dongSp.Items.Add(x.DongSp.Ten);
            }
            cmb_dongSp.SelectedIndex = 0;
            foreach (var x in iQLSanPhamService.GetAll())
            {
                cmb_mauSac.Items.Add(x.MauSac.Ten);
            }
            cmb_mauSac.SelectedIndex = 0;
            foreach (var x in iQLSanPhamService.GetAll())
            {
                cmb_nsx.Items.Add(x.Nsx.Ten);
            }
            cmb_nsx.SelectedIndex = 0;
            foreach (var x in iQLSanPhamService.GetAll())
            {
                cmb_Sp.Items.Add(x.SanPham.Ten);
            }
            cmb_Sp.SelectedIndex = 0;
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_SP.ColumnCount = 11;
            dgrid_SP.Columns[0].Name = "Stt";
            dgrid_SP.Columns[1].Name = "Id";
            dgrid_SP.Columns[1].Visible= false ;
            dgrid_SP.Columns[2].Name = "Sản phẩm";
            dgrid_SP.Columns[3].Name = "Dòng SP";
            dgrid_SP.Columns[4].Name = "Màu sắc";
            dgrid_SP.Columns[5].Name = "NSX";
            dgrid_SP.Columns[6].Name = "Số lượng tồn";
            dgrid_SP.Columns[7].Name = "Mô tả";
            dgrid_SP.Columns[8].Name = "Giá nhập";
            dgrid_SP.Columns[9].Name = "Giá bán";
            dgrid_SP.Columns[10].Name = "Năm BH";
            dgrid_SP.Rows.Clear();
            foreach (var x in iQLSanPhamService.GetAll())
            {
                dgrid_SP.Rows.Add(stt++,x.SanPham.Ten,x.DongSp.Ten,x.MauSac.Ten,x.Nsx.Ten,x.ChiTietSp.SoLuongTon,x.ChiTietSp.MoTa,x.ChiTietSp.GiaNhap,x.ChiTietSp.GiaBan,x.ChiTietSp.NamBh);
            }
        }
    }
}
