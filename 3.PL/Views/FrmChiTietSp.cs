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
    public partial class FrmChiTietSp : Form
    {
        private IQLSanPhamDetailService iChiTietSanPhamService;
        private IQLDongSpService iDongSpService;
        private IQlMauSacService iMauSacService;
        private IQLSanPhamService iSanPhamService;
        private IQLnsxService iNsxService;
        private Guid idClick;
        public FrmChiTietSp()
        {
            InitializeComponent();
            iChiTietSanPhamService = new QLSanPhamDetailService();
            iDongSpService = new QLDongSpService();
            iMauSacService = new QlMauSacService();
            iSanPhamService = new QlSanPhamService();
            iNsxService = new QLnsx();
            LoadData();
            LoadCmb();
        }
        private bool CheckValidate()
        {
            try
            {
                Convert.ToInt32(tbx_NamBH.Text);
            }
            catch
            {
                MessageBox.Show("NamBH phai la so", "error");
                return false;
            }
            return true;
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_ChiTietSp.ColumnCount = 11;
            dgrid_ChiTietSp.Columns[0].Name = "STT";
            dgrid_ChiTietSp.Columns[1].Name = "Id";
            dgrid_ChiTietSp.Columns[2].Name = "Sản Phẩm";
            dgrid_ChiTietSp.Columns[3].Name = "Nhà SX";
            dgrid_ChiTietSp.Columns[4].Name = "Màu Sắc";
            dgrid_ChiTietSp.Columns[5].Name = "Dòng SP";
            dgrid_ChiTietSp.Columns[6].Name = "Năm BH";
            dgrid_ChiTietSp.Columns[7].Name = "Mô Tả";
            dgrid_ChiTietSp.Columns[8].Name = "SL Tồn";
            dgrid_ChiTietSp.Columns[9].Name = "Giá Nhập";
            dgrid_ChiTietSp.Columns[10].Name = "Giá Bán";
            dgrid_ChiTietSp.Rows.Clear();
            dgrid_ChiTietSp.Columns["Id"].Visible = false;
            foreach (var x in iChiTietSanPhamService.GetAll())
            {
                dgrid_ChiTietSp.Rows.Add(stt++, x.ChiTietSp.Id, x.SanPham.Ten, x.Nsx.Ten, x.MauSac.Ten, x.DongSp.Ten, x.ChiTietSp.NamBh, x.ChiTietSp.MoTa, x.ChiTietSp.SoLuongTon, x.ChiTietSp.GiaNhap, x.ChiTietSp.GiaBan);
            }
        }
        private ViewSP GetData()
        {
            ViewSP ChiTietSpView = new ViewSP();
            ChiTietSpView.ChiTietSp = new ChiTietSp()
            {
                Id = Guid.Empty,
                NamBh = Convert.ToInt32(tbx_NamBH.Text),
                MoTa = tbx_MoTa.Text,
                SoLuongTon = Convert.ToInt32(tbx_SLTon.Text),
                GiaBan = Convert.ToDecimal(tbx_GiaBan.Text),
                GiaNhap = Convert.ToDecimal(tbx_GiaNhap.Text),
                IdDongSp = iDongSpService.GetAll().FirstOrDefault(c => c.DongSp.Ten == cmb_DongSp.Text).DongSp.Id,
                IdMauSac = iMauSacService.GetAll().FirstOrDefault(c => c.MauSac.Ten == cmb_MauSac.Text).MauSac.Id,
                IdNsx = iNsxService.GetAll().FirstOrDefault(c => c.Nsx.Ten == cmb_NhaSx.Text).Nsx.Id,
                IdSp = iSanPhamService.GetAll().FirstOrDefault(c => c.SanPham.Ten == cmb_SanPham.Text).SanPham.Id,
            };
            return ChiTietSpView;
        }
        private void LoadCmb()
        {
            cmb_DongSp.Items.Add("Chọn Dòng Sp");
            cmb_MauSac.Items.Add("Chọn Màu Sắc");
            cmb_NhaSx.Items.Add("Chọn Nhà SX");
            cmb_SanPham.Items.Add("Chọn Sản Phẩm");
            foreach (var x in iDongSpService.GetAll())
            {
                cmb_DongSp.Items.Add(x.DongSp.Ten);
            }
            foreach (var x in iMauSacService.GetAll())
            {
                cmb_MauSac.Items.Add(x.MauSac.Ten);
            }
            foreach (var x in iNsxService.GetAll())
            {
                cmb_NhaSx.Items.Add(x.Nsx.Ten);
            }
            foreach (var x in iSanPhamService.GetAll())
            {
                cmb_SanPham.Items.Add(x.SanPham.Ten);
            }
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iChiTietSanPhamService.Add(GetData()));
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.ChiTietSp.Id = idClick;
            MessageBox.Show(iChiTietSanPhamService.Update(temp));
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.ChiTietSp.Id = idClick;
            MessageBox.Show(iChiTietSanPhamService.Delete(temp));
            LoadData();
        }

        private void tbx_TimKiem_TextChanged(object sender, EventArgs e)
        {
            var temp = iChiTietSanPhamService.GetAll().Where(c => c.SanPham.Ten.ToLower().Contains(tbx_TimKiem.Text.ToLower()));
            if (temp == null)
            {
                LoadData();
            }
            else
            {
                int stt = 1;
                dgrid_ChiTietSp.ColumnCount = 11;
                dgrid_ChiTietSp.Columns[0].Name = "STT";
                dgrid_ChiTietSp.Columns[1].Name = "Id";
                dgrid_ChiTietSp.Columns[2].Name = "Sản Phẩm";
                dgrid_ChiTietSp.Columns[3].Name = "Nhà SX";
                dgrid_ChiTietSp.Columns[4].Name = "Màu Sắc";
                dgrid_ChiTietSp.Columns[5].Name = "Dòng SP";
                dgrid_ChiTietSp.Columns[6].Name = "Năm BH";
                dgrid_ChiTietSp.Columns[7].Name = "Mô Tả";
                dgrid_ChiTietSp.Columns[8].Name = "SL Tồn";
                dgrid_ChiTietSp.Columns[9].Name = "Giá Nhập";
                dgrid_ChiTietSp.Columns[10].Name = "Giá Bán";
                dgrid_ChiTietSp.Rows.Clear();
                dgrid_ChiTietSp.Columns["Id"].Visible = false;
                foreach (var x in temp)
                {
                    dgrid_ChiTietSp.Rows.Add(stt++, x.ChiTietSp.Id, x.SanPham.Ten, x.Nsx.Ten, x.MauSac.Ten, x.DongSp.Ten, x.ChiTietSp.NamBh, x.ChiTietSp.MoTa, x.ChiTietSp.SoLuongTon, x.ChiTietSp.GiaNhap, x.ChiTietSp.GiaBan);
                }
            }
        }

        private void dgrid_ChiTietSp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            idClick = Guid.Parse(dgrid_ChiTietSp.Rows[rowIndex].Cells[1].Value.ToString());
            var temp = iChiTietSanPhamService.GetAll().FirstOrDefault(c => c.ChiTietSp.Id == idClick);
            cmb_MauSac.Text = temp.MauSac.Ten;
            cmb_SanPham.Text = temp.SanPham.Ten;
            cmb_NhaSx.Text = temp.Nsx.Ten;
            cmb_DongSp.Text = temp.DongSp.Ten;
            tbx_GiaBan.Text = Convert.ToString(temp.ChiTietSp.GiaBan);
            tbx_GiaNhap.Text = Convert.ToString(temp.ChiTietSp.GiaNhap);
            tbx_MoTa.Text = temp.ChiTietSp.MoTa;
            tbx_NamBH.Text = Convert.ToString(temp.ChiTietSp.NamBh);
            tbx_SLTon.Text = Convert.ToString(temp.ChiTietSp.SoLuongTon);
            
        }
    }
}
