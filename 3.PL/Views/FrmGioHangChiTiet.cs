using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;

namespace _3.PresentationLayers
{
    public partial class FrmGioHangChiTiet : Form
    {
        private IQLGioHangChiTietService iGioHangChiTietService;
        private IQLSanPhamService iSanPhamService;
        private IQLGioHangService iGioHangService;
        private IQLSanPhamDetailService iChiTietSanPhamService;
        private Guid idClick;
        public FrmGioHangChiTiet()
        {
            iGioHangChiTietService = new GioHangChiTietService();
            iSanPhamService = new QlSanPhamService();
            iGioHangService = new QLGioHangService();
            iChiTietSanPhamService = new QLSanPhamDetailService();
            InitializeComponent();
            LoadData();
            LoadCmb();
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_GioHangChiTiet.ColumnCount = 7;
            dgrid_GioHangChiTiet.Columns[0].Name = "STT";
            dgrid_GioHangChiTiet.Columns[1].Name = "Mã GH";
            dgrid_GioHangChiTiet.Columns[2].Name = "Mã SP";
            dgrid_GioHangChiTiet.Columns[3].Name = "Số Lượng";
            dgrid_GioHangChiTiet.Columns[4].Name = "Đơn Giá";
            dgrid_GioHangChiTiet.Columns[5].Name = "Đơn Giá Khi Giảm";
            dgrid_GioHangChiTiet.Columns[6].Name = "IdGH";
            dgrid_GioHangChiTiet.Rows.Clear();
            dgrid_GioHangChiTiet.Columns[6].Visible = false;
            foreach (var x in iGioHangChiTietService.GetAll())
            {
                dgrid_GioHangChiTiet.Rows.Add(stt++,
                    x.GioHang.Ma,
                    x.SanPham.Ma,
                    x.GioHangChiTiet.SoLuong,
                    x.ChiTietSp.GiaBan,
                    x.GioHangChiTiet.DonGiaKhiGiam,
                    x.GioHangChiTiet.IdGioHang);
            }
        }
        private void LoadCmb()
        {
            foreach (var x in iSanPhamService.GetAll())
            {
                var temp = iChiTietSanPhamService.GetAll().FindIndex(c => c.ChiTietSp.IdSp == x.SanPham.Id);
                if (temp == -1)
                {
                    continue;
                }
                cmb_MaSp.Items.Add(x.SanPham.Ma);
            }
            foreach (var x in iGioHangService.GetAll())
            {
                cmb_MaGh.Items.Add(x.GioHang.Ma);
            }
        }
        private ViewGioHangChiTiet GetData()
        {
            return new ViewGioHangChiTiet()
            {
                GioHangChiTiet = new GioHangChiTiet()
                {
                    IdGioHang = iGioHangService.GetAll().FirstOrDefault(c => c.GioHang.Ma == cmb_MaGh.Text).GioHang.Id,
                    IdChiTietSp = iChiTietSanPhamService.GetAll().FirstOrDefault(c => c.SanPham.Ma == (iSanPhamService.GetAll().FirstOrDefault(c => c.SanPham.Ma == cmb_MaSp.Text)).SanPham.Ma).ChiTietSp.Id,
                    SoLuong = Convert.ToInt32(tbx_SoLuong.Text),
                    DonGia = iChiTietSanPhamService.GetAll().FirstOrDefault(c => c.ChiTietSp.IdSp == (iSanPhamService.GetAll().FirstOrDefault(c => c.SanPham.Ma == cmb_MaSp.Text).SanPham.Id)).ChiTietSp.GiaBan,
                    DonGiaKhiGiam = Convert.ToDecimal(tbx_DonGiaKhiGiam.Text)
                }
            };
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iGioHangChiTietService.Add(GetData()));
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iGioHangChiTietService.Update(GetData()));
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iGioHangChiTietService.Delete(GetData()));
            LoadData();
        }

        private void dgrid_GioHangChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= iGioHangChiTietService.GetAll().Count) return;
            idClick = Guid.Parse(dgrid_GioHangChiTiet.Rows[rowIndex].Cells[6].Value.ToString());
            var temp = iGioHangChiTietService.GetAll().FirstOrDefault(c => c.GioHangChiTiet.IdGioHang == idClick);
            cmb_MaGh.Text = iGioHangService.GetAll().FirstOrDefault(c => c.GioHang.Id == idClick).GioHang.Ma;
            cmb_MaSp.Text = iChiTietSanPhamService.GetAll().FirstOrDefault(c => c.ChiTietSp.Id == temp.GioHangChiTiet.IdChiTietSp).SanPham.Ma;
            tbx_DonGiaKhiGiam.Text = Convert.ToString(temp.GioHangChiTiet.DonGiaKhiGiam);
            tbx_SoLuong.Text = Convert.ToString(temp.GioHangChiTiet.SoLuong);
        }

        private void tbx_TimKiem_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
