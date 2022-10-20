using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.View
{
    public partial class FrmQLChiTietSP : Form
    {
        private IQLSanPhamDetailService _iqLChiTietSpService;
        private IQLDongSpService _iqlDongSpService;
        private IQlMauSacService _iqLMauSacservice;
        private IQLnsxService _iqLNsxService;
        private IQLSanPhamService _iqLSanPhamService;
        Guid _idwhenclick;
        string _getCmb;
        public FrmQLChiTietSP()
        {
            InitializeComponent();
            _iqLChiTietSpService = new QLSanPhamDetailService();
            _iqlDongSpService = new QLDongSpService();
            _iqLMauSacservice = new QlMauSacService();
            _iqLNsxService = new QLnsx();
            _iqLSanPhamService = new QlSanPhamService();
            LoadDGriSP();
            loadCacLoai();
        }
        private void LoadDGriSP()
        {
            int stt = 1;
            dgridChiTietSp.ColumnCount = 11;//Hiển thị bao nhiểu cột tự cấu hình
            dgridChiTietSp.Columns[0].Name = "Stt";

            dgridChiTietSp.Columns[1].Name = "Id";
            dgridChiTietSp.Columns[1].Visible = false;

            dgridChiTietSp.Columns[2].Name = "Màu";
            dgridChiTietSp.Columns[3].Name = "Sản Phẩm";
            dgridChiTietSp.Columns[4].Name = "Dòng Sản Phẩm";
            dgridChiTietSp.Columns[5].Name = "Nhà sản xuất";
            dgridChiTietSp.Columns[6].Name = "Mô tả";
            dgridChiTietSp.Columns[7].Name = "NămBh";
            dgridChiTietSp.Columns[8].Name = "Số lượng tồn";
            dgridChiTietSp.Columns[9].Name = "Giá nhập";
            dgridChiTietSp.Columns[10].Name = "Giá bán";
           
            dgridChiTietSp.Rows.Clear();
            var TimKiem = _iqLChiTietSpService.GetAll();
            if (txtTimKiem.Text != "")
            {
                TimKiem = TimKiem.Where(c => c.ChiTietSp.NamBh.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) || c.ChiTietSp.MoTa.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) ||c.ChiTietSp.SoLuongTon.ToString().ToLower().Contains(txtTimKiem.Text.ToLower())|| c.ChiTietSp.GiaBan.ToString().ToLower().Contains(txtTimKiem.Text.ToLower())|| c.ChiTietSp.GiaNhap.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) || c.MauSac.Ten.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) || c.SanPham.Ten.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) || c.DongSp.Ten.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) || c.Nsx.Ten.ToString().ToLower().Contains(txtTimKiem.Text.ToLower())).ToList();
            }
            foreach (var x in TimKiem)
            {
                dgridChiTietSp.Rows.Add(stt++, x.ChiTietSp.Id,x.MauSac.Ten, x.SanPham.Ten ,x.DongSp.Ten, x.Nsx.Ten,x.ChiTietSp.MoTa,x.ChiTietSp.NamBh, x.ChiTietSp.SoLuongTon,x.ChiTietSp.GiaNhap,x.ChiTietSp.GiaBan);
            }
        }
        public ViewSP GetdataFromGui()
        {
            if (txtGiaBan.Text == "" || txtGiaNhap.Text == "" || txtMoTa.Text == "" || txtNamBH.Text == "" || txtSoLuongTon.Text == "" || cmbDongsp.SelectedIndex == 0 ||cmbNsx.SelectedIndex == 0 ||cmbMausac.SelectedIndex == 0 ||cmbSanpham.SelectedIndex == 0 )
            {
                MessageBox.Show("vui lòng nhập đủ thông tin");
            }
            else
            {
                ViewSP ctsp = new ViewSP();
                ctsp.ChiTietSp = new ChiTietSp()
                {
                    NamBh = int.Parse(txtNamBH.Text),
                    MoTa = txtMoTa.Text,
                    SoLuongTon = int.Parse(txtSoLuongTon.Text),
                    GiaBan = decimal.Parse(txtGiaBan.Text),
                    GiaNhap = decimal.Parse(txtGiaNhap.Text),
                    IdMauSac = _iqLMauSacservice.GetAll().FirstOrDefault(c => c.Ten == cmbMausac.Text).Id,
                    IdDongSp = _iqlDongSpService.GetAll().FirstOrDefault(c => c.Ten == cmbDongsp.Text).Id,
                    IdNsx = _iqLNsxService.GetAll().FirstOrDefault(c => c.Ten == cmbNsx.Text).Id,
                    IdSp = _iqLSanPhamService.GetAll().FirstOrDefault(c => c.Ten == cmbSanpham.Text).Id
                };
                return ctsp;
            }
            return null;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iqLChiTietSpService.Add(GetdataFromGui()));
            LoadDGriSP();
        }
        public void loadCacLoai()
        {
            cmbSanpham.Items.Add("Chọn Sản Phẩm");
            cmbNsx.Items.Add("Chọn Nhà Sản Xuất");
            cmbDongsp.Items.Add("Chọn Dòng Sản Phẩm");
            cmbMausac.Items.Add("Chọn Màu Sắc");
            foreach (var x in _iqLSanPhamService.GetAll())
            {
                cmbSanpham.Items.Add(x.Ten);
            }
            foreach (var x in _iqLMauSacservice.GetAll())
            {
                cmbMausac.Items.Add(x.Ten);
            }
            foreach (var x in _iqLNsxService.GetAll())
            {
                cmbNsx.Items.Add(x.Ten);
            }
            foreach (var x in _iqlDongSpService.GetAll())
            {
                cmbDongsp.Items.Add(x.Ten);
            }
            cmbDongsp.SelectedIndex = 0;
            cmbNsx.SelectedIndex = 0;
            cmbMausac.SelectedIndex = 0;
            cmbSanpham.SelectedIndex = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var tempobj = GetdataFromGui();
            tempobj.ChiTietSp.Id = _idwhenclick;
            MessageBox.Show(_iqLChiTietSpService.Delete(tempobj));
            LoadDGriSP();
            ReSetForm();
        }

        private void dgridChiTietSp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex=e.RowIndex;
            if (rowindex == -1 || rowindex == _iqLChiTietSpService.GetAll().Count) return;
            _idwhenclick = Guid.Parse(dgridChiTietSp.Rows[rowindex].Cells[1].Value.ToString());
            var ctsp = _iqLChiTietSpService.GetAll().FirstOrDefault(c => c.ChiTietSp.Id == _idwhenclick);
            cmbMausac.SelectedIndex=cmbMausac.FindStringExact(_getCmb=_iqLMauSacservice.GetAll().FirstOrDefault(c=>c.Id==ctsp.ChiTietSp.IdMauSac).Ten.ToString());
            cmbSanpham.SelectedIndex= cmbSanpham.FindStringExact(_getCmb=_iqLSanPhamService.GetAll().FirstOrDefault(c=>c.Id==ctsp.ChiTietSp.IdSp).Ten.ToString());
            cmbDongsp.SelectedIndex=cmbDongsp.FindStringExact(_getCmb=_iqlDongSpService.GetAll().FirstOrDefault(c=>c.Id==ctsp.ChiTietSp.IdDongSp).Ten.ToString());
            cmbNsx.SelectedIndex= cmbNsx.FindStringExact(_getCmb=_iqLNsxService.GetAll().FirstOrDefault(c=>c.Id==ctsp.ChiTietSp.IdNsx).Ten.ToString());
            txtNamBH.Text = ctsp.ChiTietSp.NamBh.ToString();
            txtMoTa.Text = ctsp.ChiTietSp.MoTa;
            txtSoLuongTon.Text = ctsp.ChiTietSp.SoLuongTon.ToString();
            txtGiaNhap.Text = ctsp.ChiTietSp.GiaNhap.ToString();
            txtGiaBan.Text = ctsp.ChiTietSp.GiaBan.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var tempobj = GetdataFromGui();
            tempobj.ChiTietSp.Id = _idwhenclick;
            MessageBox.Show(_iqLChiTietSpService.Update(tempobj));
            LoadDGriSP();
            ReSetForm();
        }
        private void btnReSet_Click(object sender, EventArgs e)
        {
            ReSetForm();
        }
        public void ReSetForm()
        {
            txtGiaBan.Clear();
            txtGiaNhap.Clear();
            txtMoTa.Clear();
            txtNamBH.Clear();
            txtSoLuongTon.Clear();
            txtTimKiem.Clear();
            cmbDongsp.SelectedIndex = 0;
            cmbNsx.SelectedIndex = 0;
            cmbMausac.SelectedIndex = 0;
            cmbSanpham.SelectedIndex = 0;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDGriSP();
        }
    }
}
