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
    public partial class FrmNhanVien : Form
    {
        private IQLNhanVienService iNhanVienService;
        private IQLCuaHangService iCuaHangService;
        private IQLChucVuService iChucVuService;
        private Guid idClick = Guid.Empty;
        public FrmNhanVien()
        {
            InitializeComponent();
            iNhanVienService = new QLNhanVienService();
            iChucVuService = new QLChucVuService();
            iCuaHangService = new QLCuaHangService();
            LoadCmb();
            LoadData();
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_NhanVien.ColumnCount = 14;
            dgrid_NhanVien.Columns[0].Name = "STT";
            dgrid_NhanVien.Columns[1].Name = "Id";
            dgrid_NhanVien.Columns[2].Name = "Mã";
            dgrid_NhanVien.Columns[3].Name = "Tên";
            dgrid_NhanVien.Columns[4].Name = "Tên Đệm";
            dgrid_NhanVien.Columns[5].Name = "Họ";
            dgrid_NhanVien.Columns[6].Name = "Giới Tính";
            dgrid_NhanVien.Columns[7].Name = "Ngày Sinh";
            dgrid_NhanVien.Columns[8].Name = "Địa chỉ";
            dgrid_NhanVien.Columns[9].Name = "SĐT";
            dgrid_NhanVien.Columns[10].Name = "Mật Khẩu";
            dgrid_NhanVien.Columns[11].Name = "Cửa Hàng";
            dgrid_NhanVien.Columns[12].Name = "Chức Vụ";
            dgrid_NhanVien.Columns[13].Name = "Trạng Thái";
            dgrid_NhanVien.Columns[1].Visible = false;
            dgrid_NhanVien.Rows.Clear();
            foreach (var x in iNhanVienService.GetAll())
            {
                dgrid_NhanVien.Rows.Add(stt++, x.NhanVien.Id, x.NhanVien.Ma, x.NhanVien.Ten, x.NhanVien.TenDem, x.NhanVien.Ho, x.NhanVien.GioiTinh, x.NhanVien.NgaySinh, x.NhanVien.DiaChi, x.NhanVien.Sdt, x.NhanVien.MatKhau, iCuaHangService.GetAll().FirstOrDefault(c=>c.CuaHang.Id == x.NhanVien.IdCh).CuaHang.Ma, iChucVuService.GetAll().FirstOrDefault(c => c.ChucVu.Id == x.NhanVien.IdCv).ChucVu.Ma, x.NhanVien.TrangThai== 1? "Hoạt Động":"Không Hoạt Động");
            }
        }
        private ViewNhanVien GetData()
        {
            ViewNhanVien nhanVienView = new ViewNhanVien();
            nhanVienView.NhanVien = new NhanVien()
            {
                Id = Guid.Empty,
                IdGuiBc = Guid.Empty,
                Ma = tbx_Ma.Text,
                Ten = tbx_Ten.Text,
                TenDem = tbx_TenDem.Text,
                Ho = tbx_Ho.Text,
                GioiTinh = tbx_GioiTinh.Text,
                NgaySinh = dtp_NgaySinh.Value,
                DiaChi = tbx_DiaChi.Text,
                Sdt = tbx_SDT.Text,
                MatKhau = tbx_MatKhau.Text,
                IdCh = iCuaHangService.GetAll().FirstOrDefault(c => c.CuaHang.Ma == cmb_CuaHang.Text).CuaHang.Id,
                IdCv = iChucVuService.GetAll().FirstOrDefault(c => c.ChucVu.Ma == cmb_ChucVu.Text).ChucVu.Id,
                TrangThai = cmb_TrangThai.SelectedIndex == 1 ? 0 : 1
            };
            return nhanVienView;
        }
        private void LoadCmb()
        {
            foreach (var x in iCuaHangService.GetAll())
            {
                cmb_CuaHang.Items.Add(x.CuaHang.Ma);
            }
            foreach (var x in iChucVuService.GetAll())
            {
                cmb_ChucVu.Items.Add(x.ChucVu.Ma);
            }
            cmb_TrangThai.Items.Add("Hoạt Động");
            cmb_TrangThai.Items.Add("Không Hoạt Động");
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iNhanVienService.Add(GetData()));
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.NhanVien.Id = idClick;
            temp.NhanVien.IdGuiBc = idClick;
            MessageBox.Show(iNhanVienService.Update(temp));
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.NhanVien.Id = idClick;
            temp.NhanVien.IdGuiBc = idClick;
            MessageBox.Show(iNhanVienService.Delete(temp));
            LoadData();
        }

        private void dgrid_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tbx_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgrid_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndext = e.RowIndex;
            if (iNhanVienService.GetAll().Count < rowIndext) return;
            idClick = Guid.Parse(dgrid_NhanVien.Rows[rowIndext].Cells[1].Value.ToString());
            var temp = iNhanVienService.GetAll().FirstOrDefault(c => c.NhanVien.Id == idClick);
            tbx_Ma.Text = temp.NhanVien.Ma;
            tbx_Ten.Text = temp.NhanVien.Ten;
            tbx_TenDem.Text = temp.NhanVien.TenDem;
            tbx_Ho.Text = temp.NhanVien.Ho;
            tbx_GioiTinh.Text = temp.NhanVien.GioiTinh;
            dtp_NgaySinh.Value = temp.NhanVien.NgaySinh.Value;
            tbx_DiaChi.Text = temp.NhanVien.DiaChi;
            tbx_SDT.Text = temp.NhanVien.Sdt;
            tbx_MatKhau.Text = temp.NhanVien.MatKhau;
            cmb_CuaHang.Text = iCuaHangService.GetAll().FirstOrDefault(c => c.CuaHang.Id == temp.NhanVien.IdCh).CuaHang.Ma;
            cmb_ChucVu.Text = iChucVuService.GetAll().FirstOrDefault(c => c.ChucVu.Id == temp.NhanVien.IdCv).ChucVu.Ma;
            cmb_TrangThai.Text = temp.NhanVien.TrangThai == 1 ? "Hoạt Động" : "Không Hoạt Động";
        }
    }
}
