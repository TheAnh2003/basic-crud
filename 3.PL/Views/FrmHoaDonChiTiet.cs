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
using _1.DAL.IRepositories;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;

namespace _3.PresentationLayers
{
    public partial class FrmHoaDonChiTiet : Form
    {
        private IChiTietHoaDonService iHoaDonChiTietService;
        private IQLSanPhamService iSanPhamService;
        private IQLSanPhamDetailService iChiTietSanPhamService;
        private IQLHoaDonService iHoaDonService;
        private Guid idClick;
        public FrmHoaDonChiTiet()
        {
            iHoaDonChiTietService = new ChiTietHoaDonService();
            iSanPhamService = new QlSanPhamService();
            iChiTietSanPhamService = new QLSanPhamDetailService();
            iHoaDonService = new QLHoaDonService();
            InitializeComponent();
            LoadData();
            LoadCmb();
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_HoaDonChiTiet.ColumnCount = 6;
            dgrid_HoaDonChiTiet.Columns[0].Name = "STT";
            dgrid_HoaDonChiTiet.Columns[1].Name = "Mã HĐ";
            dgrid_HoaDonChiTiet.Columns[2].Name = "Mã SP";
            dgrid_HoaDonChiTiet.Columns[3].Name = "Số Lượng";
            dgrid_HoaDonChiTiet.Columns[4].Name = "Đơn Giá";
            dgrid_HoaDonChiTiet.Columns[5].Name = "IdHD";
            dgrid_HoaDonChiTiet.Rows.Clear();
            dgrid_HoaDonChiTiet.Columns[5].Visible = false;
            foreach (var x in iHoaDonChiTietService.GetAll())
            {
                dgrid_HoaDonChiTiet.Rows.Add(stt++,
                    x.HoaDon.Ma,
                    x.SanPham.Ma,
                    x.HoaDonChiTiet.SoLuong,
                    x.ChiTietSp.GiaBan,
                    x.HoaDonChiTiet.IdHoaDon);
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
            foreach (var x in iHoaDonService.GetAll())
            {
                cmb_MaHD.Items.Add(x.HoaDon.Ma);
            }
        }
        private ViewHoaDonChiTiet GetData()
        {
            return new ViewHoaDonChiTiet()
            {
                HoaDonChiTiet = new HoaDonChiTiet()
                {
                    IdChiTietSp = iChiTietSanPhamService.GetAll().FirstOrDefault(c => c.ChiTietSp.IdSp == (iSanPhamService.GetAll().FirstOrDefault(c => c.SanPham.Ma == cmb_MaSp.Text).SanPham.Id)).ChiTietSp.Id,
                    IdHoaDon = iHoaDonService.GetAll().FirstOrDefault(c => c.HoaDon.Ma == cmb_MaHD.Text).HoaDon.Id,
                    SoLuong = Convert.ToInt32(tbx_SoLuong.Text),
                    DonGia = iChiTietSanPhamService.GetAll().FirstOrDefault(c => c.ChiTietSp.IdSp == (iSanPhamService.GetAll().FirstOrDefault(c => c.SanPham.Ma == cmb_MaSp.Text).SanPham.Id)).ChiTietSp.GiaBan,
                }
            };
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iHoaDonChiTietService.Add(GetData()));
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iHoaDonChiTietService.Update(GetData()));
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iHoaDonChiTietService.Delete(GetData()));
            LoadData();
        }

        private void tbx_TimKiem_TextChanged(object sender, EventArgs e)
        {
            var temp = iHoaDonChiTietService.GetAll().Where(c => c.HoaDonChiTiet.IdHoaDon == iHoaDonService.GetAll().FirstOrDefault(c => c.HoaDon.Ma.ToLower().Contains(tbx_TimKiem.Text.ToLower())).HoaDon.Id);
            if (temp == null)
            {
                LoadData();
            }
            else
            {
                int stt = 1;
                dgrid_HoaDonChiTiet.ColumnCount = 6;
                dgrid_HoaDonChiTiet.Columns[0].Name = "STT";
                dgrid_HoaDonChiTiet.Columns[1].Name = "Mã HĐ";
                dgrid_HoaDonChiTiet.Columns[2].Name = "Mã SP";
                dgrid_HoaDonChiTiet.Columns[3].Name = "Số Lượng";
                dgrid_HoaDonChiTiet.Columns[4].Name = "Đơn Giá";
                dgrid_HoaDonChiTiet.Columns[5].Name = "IdHD";
                dgrid_HoaDonChiTiet.Rows.Clear();
                dgrid_HoaDonChiTiet.Columns[5].Visible = false;
                foreach (var x in temp)
                {
                    dgrid_HoaDonChiTiet.Rows.Add(stt++,
                        x.HoaDon.Ma,
                        x.SanPham.Ma,
                        x.HoaDonChiTiet.SoLuong,
                        x.ChiTietSp.GiaBan,
                        x.HoaDonChiTiet.IdHoaDon);
                }
            }
        }

        private void dgrid_HoaDonChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= iHoaDonChiTietService.GetAll().Count || rowIndex < 0) return;
            idClick = Guid.Parse(dgrid_HoaDonChiTiet.Rows[rowIndex].Cells[5].Value.ToString());
            var temp = iHoaDonChiTietService.GetAll().FirstOrDefault(c => c.HoaDonChiTiet.IdHoaDon == idClick);
            tbx_SoLuong.Text = Convert.ToString(temp.HoaDonChiTiet.SoLuong);
            cmb_MaHD.Text = iHoaDonService.GetAll().FirstOrDefault(c => c.HoaDon.Id == temp.HoaDonChiTiet.IdHoaDon).HoaDon.Ma;
            cmb_MaSp.Text = iSanPhamService.GetAll().FirstOrDefault(c => c.SanPham.Id == iChiTietSanPhamService.GetAll().FirstOrDefault(c => c.ChiTietSp.Id == temp.HoaDonChiTiet.IdChiTietSp).ChiTietSp.IdSp).SanPham.Ma;
            tbx_SoLuong.Text = Convert.ToString(temp.HoaDonChiTiet.SoLuong);
        }
    }
}
