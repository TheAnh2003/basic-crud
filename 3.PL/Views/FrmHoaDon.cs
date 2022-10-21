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
    public partial class FrmHoaDon : Form
    {
        private IQLHoaDonService iHoaDonService;
        private IQLKhachHangService iKhachHangService;
        private IQLNhanVienService iNhanVienService;
        private Guid idClick;
        public FrmHoaDon()
        {
            InitializeComponent();
            iHoaDonService = new QLHoaDonService();
            iKhachHangService = new QLKhachHangService();
            iNhanVienService = new QLNhanVienService();
            LoadCmb();
            LoadData();
        }
        private string GetTinhTrang(int? obj)
        {
            if (obj == 0) return "Hủy";
            if (obj == 1) return "Chờ Thanh Toán";
            return "Đã Thanh Toán";
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_HoaDon.ColumnCount = 13;
            dgrid_HoaDon.Columns[0].Name = "STT";
            dgrid_HoaDon.Columns[1].Name = "Id";
            dgrid_HoaDon.Columns[2].Name = "Mã KH";
            dgrid_HoaDon.Columns[3].Name = "Mã NV";
            dgrid_HoaDon.Columns[4].Name = "Mã HĐ";
            dgrid_HoaDon.Columns[5].Name = "Ngày Tạo";
            dgrid_HoaDon.Columns[6].Name = "Ngày Thanh Toán";
            dgrid_HoaDon.Columns[7].Name = "Ngày Ship";
            dgrid_HoaDon.Columns[8].Name = "Ngày Nhận";
            dgrid_HoaDon.Columns[9].Name = "Tình Trạng";
            dgrid_HoaDon.Columns[10].Name = "Tên Ng Nhận";
            dgrid_HoaDon.Columns[11].Name = "Địa Chỉ";
            dgrid_HoaDon.Columns[12].Name = "SĐT";
            dgrid_HoaDon.Columns[1].Visible = false;
            dgrid_HoaDon.Rows.Clear();
            foreach (var x in iHoaDonService.GetAll())
            {
                dgrid_HoaDon.Rows.Add(stt++,
                    x.HoaDon.Id,
                    iKhachHangService.GetAll().FirstOrDefault(c=>c.KhachHang.Id == x.HoaDon.IdKh).KhachHang.Ma,
                    iNhanVienService.GetAll().FirstOrDefault(c=>c.NhanVien.Id == x.HoaDon.IdNv).NhanVien.Ma,
                    x.HoaDon.Ma,
                    x.HoaDon.NgayTao,
                    x.HoaDon.NgayThanhToan,
                    x.HoaDon.NgayShip,
                    x.HoaDon.NgayNhan,
                    GetTinhTrang(x.HoaDon.TinhTrang),
                    x.HoaDon.TenNguoiNhan,
                    x.HoaDon.DiaChi,
                    x.HoaDon.Sdt);
            }
        }
        private ViewHoaDon GetData()
        {
            return new ViewHoaDon()
            {
                HoaDon = new HoaDon()
                {
                    Id = Guid.Empty,
                    
                    Ma = tbx_Ma.Text,
                    NgayTao = dtp_NgayTao.Value,
                    NgayThanhToan = dtp_NgayTT.Value,
                    NgayShip = dtp_NgayShip.Value,
                    NgayNhan = dtp_NgayNhan.Value,
                    TinhTrang = cmb_TrangThai.SelectedIndex,
                    TenNguoiNhan = tbx_TenNgNhan.Text,
                    DiaChi = tbx_DiaChi.Text,
                    Sdt = tbx_SDT.Text
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
            cmb_TrangThai.Items.Add("Hủy");
            cmb_TrangThai.Items.Add("Chờ Thanh Toán");
            cmb_TrangThai.Items.Add("Đã Thanh Toán");
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iHoaDonService.Add(GetData()));
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.HoaDon.Id = idClick;
            MessageBox.Show(iHoaDonService.Update(temp));
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.HoaDon.Id = idClick;
            MessageBox.Show(iHoaDonService.Delete(temp));
            LoadData();
        }

        private void tbx_TimKiem_TextChanged(object sender, EventArgs e)
        {
            var temp = iHoaDonService.GetAll().Where(c=>c.HoaDon.Ma.ToLower().Contains(tbx_TimKiem.Text.ToLower()));
            if (tbx_TimKiem.Text == null || temp == null)
            {
                LoadData();
            }
            else
            {
                int stt = 1;
                dgrid_HoaDon.ColumnCount = 13;
                dgrid_HoaDon.Columns[0].Name = "STT";
                dgrid_HoaDon.Columns[1].Name = "Id";
                dgrid_HoaDon.Columns[2].Name = "Mã KH";
                dgrid_HoaDon.Columns[3].Name = "Mã NV";
                dgrid_HoaDon.Columns[4].Name = "Mã HĐ";
                dgrid_HoaDon.Columns[5].Name = "Ngày Tạo";
                dgrid_HoaDon.Columns[6].Name = "Ngày Thanh Toán";
                dgrid_HoaDon.Columns[7].Name = "Ngày Ship";
                dgrid_HoaDon.Columns[8].Name = "Ngày Nhận";
                dgrid_HoaDon.Columns[9].Name = "Tình Trạng";
                dgrid_HoaDon.Columns[10].Name = "Tên Ng Nhận";
                dgrid_HoaDon.Columns[11].Name = "Địa Chỉ";
                dgrid_HoaDon.Columns[12].Name = "SĐT";
                dgrid_HoaDon.Columns[1].Visible = false;
                dgrid_HoaDon.Rows.Clear();
                foreach (var x in temp)
                {
                    dgrid_HoaDon.Rows.Add(stt++,
                        x.HoaDon.Id,
                        iKhachHangService.GetAll().FirstOrDefault(c => c.KhachHang.Id == x.HoaDon.IdKh).KhachHang.Ma,
                        iNhanVienService.GetAll().FirstOrDefault(c => c.NhanVien.Id == x.HoaDon.IdNv).NhanVien.Ma,
                        x.HoaDon.Ma,
                        x.HoaDon.NgayTao,
                        x.HoaDon.NgayThanhToan,
                        x.HoaDon.NgayShip,
                        x.HoaDon.NgayNhan,
                        GetTinhTrang(x.HoaDon.TinhTrang),
                        x.HoaDon.TenNguoiNhan,
                        x.HoaDon.DiaChi,
                        x.HoaDon.Sdt);
                }
            }
        }

        private void dgrid_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex <= 0 || rowIndex >= iHoaDonService.GetAll().Count) return;
            idClick = Guid.Parse(dgrid_HoaDon.Rows[rowIndex].Cells[1].Value.ToString());
            var temp = iHoaDonService.GetAll().FirstOrDefault(c=>c.HoaDon.Id == idClick);
            cmb_MaKH.Text = iKhachHangService.GetAll().FirstOrDefault(c => c.KhachHang.Id == temp.HoaDon.IdKh).KhachHang.Ma;
            cmb_MaNV.Text = iNhanVienService.GetAll().FirstOrDefault(c => c.NhanVien.Id == temp.HoaDon.IdNv).NhanVien.Ma;
            tbx_Ma.Text = temp.HoaDon.Ma;
            dtp_NgayTao.Value = temp.HoaDon.NgayTao.Value;
            dtp_NgayTT.Value = temp.HoaDon.NgayThanhToan.Value;
            dtp_NgayShip.Value = temp.HoaDon.NgayShip.Value;
            dtp_NgayNhan.Value = temp.HoaDon.NgayNhan.Value;
            cmb_TrangThai.SelectedIndex = Convert.ToInt32(temp.HoaDon.TinhTrang);
            tbx_TenNgNhan.Text = temp.HoaDon.TenNguoiNhan;
            tbx_DiaChi.Text = temp.HoaDon.DiaChi;
            tbx_SDT.Text = temp.HoaDon.Sdt;
        }
    }
}
