using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Service;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.View
{
    public partial class FrmQLNhanVien : Form
    {
        IQLNhanVienService _qLNhanVienService;
        IQLChucVuService _qLChucVuService;
        IQLCuaHangService _qLCuaHangService;
        Guid _idWhenClick;
        public FrmQLNhanVien()
        {
            InitializeComponent();
            _qLNhanVienService = new QLNhanVienService();
            _qLChucVuService = new QLChucVuService();
            _qLCuaHangService = new QLCuaHangService();
            LoadData();
            LoadCacLLoai();
        }
        private void LoadData()
        {
            int stt = 1;
            dgridNhanVien.ColumnCount = 12;
            dgridNhanVien.Columns[0].Name = "Stt";
            dgridNhanVien.Columns[1].Name = "ID";
            dgridNhanVien.Columns[2].Name = "Mã";
            dgridNhanVien.Columns[3].Name = "Tên đầy đủ";
            dgridNhanVien.Columns[4].Name = "Giới tính";
            dgridNhanVien.Columns[5].Name = "Ngày sinh";
            dgridNhanVien.Columns[6].Name = "Địa chỉ";
            dgridNhanVien.Columns[7].Name = "SĐT";
            dgridNhanVien.Columns[8].Name = "Mật khẩu";
            dgridNhanVien.Columns[9].Name = "Tên Của hàng";
            dgridNhanVien.Columns[10].Name = "Tên Chức vụ";
            dgridNhanVien.Columns[11].Name = "Trạng thái";
            dgridNhanVien.Rows.Clear();
            foreach (var x in _qLNhanVienService.GetAll())
            {
                dgridNhanVien.Rows.Add(stt++, x.NhanVien.Id, x.NhanVien.Ma, x.NhanVien.Ho + " " + x.NhanVien.TenDem + " " + x.NhanVien.Ten, (x.NhanVien.GioiTinh == "1" ? "Nam" : "Nữ"), x.NhanVien.NgaySinh, x.NhanVien.DiaChi, x.NhanVien.Sdt, x.NhanVien.MatKhau, x.ChucVu.Ten, x.CuaHang.Ten, (x.NhanVien.TrangThai == 1 ? "Hoạt động" : "Không hoạt động"));
            }
        }
        private void LoadCacLLoai()
        {
            cmbChucVu.Items.Add("Chọn Chức Vụ");
            cmbCuaHang.Items.Add("Chọn Cửa Hàng");
            foreach (var x in _qLChucVuService.GetAll())
            {
                cmbChucVu.Items.Add(x.Ten);
            }
            foreach (var x in _qLCuaHangService.GetAll())
            {
                cmbCuaHang.Items.Add(x.Ten);
            }
            cmbChucVu.SelectedIndex = 0;
            cmbCuaHang.SelectedIndex = 0;
        }
        private ViewNhanVien GetdataFromGui()
        {
            if (cmbChucVu.SelectedIndex == 0 || cmbCuaHang.SelectedIndex == 0)
            {
                MessageBox.Show("chưa đủ thông tin");
            }
            else
            {
                ViewNhanVien nhanhVien = new ViewNhanVien();
                nhanhVien.NhanVien = new NhanVien()
                {
                    Ma = txtMa.Text,
                    Ten = txtTen.Text,
                    TenDem = txtTenDem.Text,
                    Ho = txtHo.Text,
                    GioiTinh = (rbtnNam.Checked == true ? "1" : "0"),
                    NgaySinh = dateNgaySinh.Value,
                    DiaChi = txtDiaChi.Text,
                    Sdt = txtSdt.Text,
                    MatKhau = txtMatKhau.Text,
                    TrangThai = (rbtnHoatDong.Checked == true ? 1 : 0),
                    IdCh = _qLCuaHangService.GetAll().FirstOrDefault(c => c.Ten == cmbCuaHang.Text).Id,
                    IdCv = _qLChucVuService.GetAll().FirstOrDefault(c => c.Ten == cmbChucVu.Text).Id,
                    IdGuiBc = null
                };
                return nhanhVien;
            }
            return null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_qLNhanVienService.Add(GetdataFromGui()));
            LoadData();
        }

        private void dgridNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == _qLNhanVienService.GetAll().Count) return;
            _idWhenClick = Guid.Parse(dgridNhanVien.Rows[rowindex].Cells[1].Value.ToString());
            var nv = _qLNhanVienService.GetAll().FirstOrDefault(c => c.NhanVien.Id == _idWhenClick);//Trả về 1 đối tượng tương ứng với khóa chính
            txtHo.Text = nv.NhanVien.Ho;
            txtTenDem.Text = nv.NhanVien.TenDem;
            txtTen.Text = nv.NhanVien.Ten;
            txtMa.Text = nv.NhanVien.Ma;
            if (nv.NhanVien.GioiTinh == "1")
            {
                rbtnNam.Checked = true;

            }
            else { rbtnNu.Checked = true; }
            if (nv.NhanVien.TrangThai == 1)
            {
                rbtnHoatDong.Checked = true;

            }
            else { rbtnKoHoatDong.Checked = true; }
            txtDiaChi.Text = nv.NhanVien.DiaChi;
            txtSdt.Text = nv.NhanVien.Sdt;
            txtMatKhau.Text = nv.NhanVien.MatKhau;
            dateNgaySinh.Value = (DateTime) nv.NhanVien.NgaySinh;
            cmbCuaHang.SelectedIndex = cmbCuaHang.FindStringExact(_qLCuaHangService.GetAll().FirstOrDefault(c => c.Id == nv.NhanVien.IdCh).Ten.ToString());
            cmbChucVu.SelectedIndex = cmbChucVu.FindString(_qLChucVuService.GetAll().FirstOrDefault(c => c.Id == nv.NhanVien.IdCv).Ten.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var temp = GetdataFromGui();
            temp.NhanVien.Id = _idWhenClick;
            MessageBox.Show(_qLNhanVienService.Delete(temp));
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var temp = GetdataFromGui();
            temp.NhanVien.Id = _idWhenClick;
            MessageBox.Show(_qLNhanVienService.Update(temp));
            LoadData();

        }
    }
}
