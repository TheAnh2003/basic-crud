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
using _2.BUS.Service;
using _2.BUS.Services;
using _2.BUS.ViewModels;

namespace _3.PresentationLayers
{
    public partial class FrmGioHang : Form
    {
        private IQLGioHangService iGioHangService;
        private IQLKhachHangService iKhachHangService;
        private IQLNhanVienService iNhanVienService;
        Guid idClick;
        public FrmGioHang()
        {
            iGioHangService = new QLGioHangService();
            iKhachHangService = new QLKhachHangService();
            iNhanVienService = new QLNhanVienService();
            InitializeComponent();
            LoadData();
            LoadCmb();
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_GioHang.ColumnCount = 11;
            dgrid_GioHang.Columns[0].Name = "STT";
            dgrid_GioHang.Columns[1].Name = "Id";
            dgrid_GioHang.Columns[2].Name = "MaKh";
            dgrid_GioHang.Columns[3].Name = "MaNv";
            dgrid_GioHang.Columns[4].Name = "Mã Giỏ Hàng";
            dgrid_GioHang.Columns[5].Name = "Ngày Tạo";
            dgrid_GioHang.Columns[6].Name = "Ngày Thanh Toán";
            dgrid_GioHang.Columns[7].Name = "Tên Người Nhận";
            dgrid_GioHang.Columns[8].Name = "Địa Chỉ";
            dgrid_GioHang.Columns[9].Name = "SĐT";
            dgrid_GioHang.Columns[10].Name = "Tình Trạng";
            dgrid_GioHang.Columns[1].Visible = false;
            dgrid_GioHang.Rows.Clear();
            foreach (var x in iGioHangService.GetAll())
            {
                dgrid_GioHang.Rows.Add(stt++, x.GioHang.Id, x.KhachHang.Ma, x.NhanVien.Ma, x.GioHang.Ma, x.GioHang.NgayTao, x.GioHang.NgayThanhToan, x.GioHang.TenNguoiNhan, x.GioHang.DiaChi, x.GioHang.Sdt, x.GioHang.TinhTrang == 0 ? "Hủy":"Chờ");
            }
        }
        private ViewGioHang GetData()
        {
            return new ViewGioHang()
            {
                GioHang = new GioHang()
                {
                    Id = Guid.Empty,
                    Ma = tbx_MaGioHang.Text,
                    NgayTao = dtp_NgayTao.Value,
                    NgayThanhToan = dtp_NgayTT.Value,
                    TenNguoiNhan = tbx_TenNgNhan.Text,
                    DiaChi = tbx_DiaChi.Text,
                    Sdt = tbx_SDT.Text,
                    TinhTrang = cmb_TinhTrang.SelectedIndex == 1 ? 0 : 1,
                    IdKh = iKhachHangService.GetAll().FirstOrDefault(c => c.KhachHang.Ma == cmb_MaKH.Text).KhachHang.Id,
                    IdNv = iNhanVienService.GetAll().FirstOrDefault(c => c.NhanVien.Ma == cmb_MaNV.Text).NhanVien.Id,
                }
            };
        }
        private void LoadCmb()
        {
            foreach (var x in iKhachHangService.GetAll())
            {
                cmb_MaKH.Items.Add(x.KhachHang.Ma);
            }
            foreach (var x in iNhanVienService.GetAll())
            {
                cmb_MaNV.Items.Add(x.NhanVien.Ma);
            }
            cmb_TinhTrang.Items.Add("Chờ");
            cmb_TinhTrang.Items.Add("Hủy");
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iGioHangService.Add(GetData()));
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.GioHang.Id = idClick;
            MessageBox.Show(iGioHangService.Update(temp));
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.GioHang.Id = idClick;
            MessageBox.Show(iGioHangService.Delete(temp));
            LoadData();
        }

        private void tbx_TimKiem_TextChanged(object sender, EventArgs e)
        {
            var temp = iGioHangService.GetAll().Where(c=>c.GioHang.Ma.ToLower().Contains(tbx_TimKiem.Text.ToLower()));
            if (tbx_TimKiem.Text == null || temp == null)
            {
                LoadData();
            }
            else
            {
                int stt = 1;
                dgrid_GioHang.ColumnCount = 11;
                dgrid_GioHang.Columns[0].Name = "STT";
                dgrid_GioHang.Columns[1].Name = "Id";
                dgrid_GioHang.Columns[2].Name = "MaKh";
                dgrid_GioHang.Columns[3].Name = "MaNv";
                dgrid_GioHang.Columns[4].Name = "Mã Giỏ Hàng";
                dgrid_GioHang.Columns[5].Name = "Ngày Tạo";
                dgrid_GioHang.Columns[6].Name = "Ngày Thanh Toán";
                dgrid_GioHang.Columns[7].Name = "Tên Người Nhận";
                dgrid_GioHang.Columns[8].Name = "Địa Chỉ";
                dgrid_GioHang.Columns[9].Name = "SĐT";
                dgrid_GioHang.Columns[10].Name = "Tình Trạng";
                dgrid_GioHang.Columns[1].Visible = false;
                dgrid_GioHang.Rows.Clear();
                foreach (var x in temp)
                {
                    dgrid_GioHang.Rows.Add(stt++, x.GioHang.Id, x.KhachHang.Ma, x.NhanVien.Ma, x.GioHang.Ma, x.GioHang.NgayTao, x.GioHang.NgayThanhToan, x.GioHang.TenNguoiNhan, x.GioHang.DiaChi, x.GioHang.Sdt, x.GioHang.TinhTrang);
                }
            }
        }

        private void dgrid_GioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndext = e.RowIndex;
            if (rowIndext >= iGioHangService.GetAll().Count|| rowIndext <0) return;
            idClick = Guid.Parse(dgrid_GioHang.Rows[rowIndext].Cells[1].Value.ToString());
            var temp = iGioHangService.GetAll().FirstOrDefault(c => c.GioHang.Id == idClick);
            tbx_MaGioHang.Text = temp.GioHang.Ma;
            dtp_NgayTao.Value = temp.GioHang.NgayTao.Value;
            dtp_NgayTT.Value = temp.GioHang.NgayThanhToan.Value;
            tbx_TenNgNhan.Text = temp.GioHang.TenNguoiNhan;
            tbx_DiaChi.Text = temp.GioHang.DiaChi;
            tbx_SDT.Text = temp.GioHang.Sdt;
            cmb_TinhTrang.SelectedIndex = temp.GioHang.TinhTrang == 1 ? 0:1;
            cmb_MaKH.Text = temp.KhachHang.Ma;
            cmb_MaNV.Text = temp.NhanVien.Ma;
        }
    }
}
