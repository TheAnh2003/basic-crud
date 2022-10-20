using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
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
    public partial class FrmQlKhachHang : Form
    {
        IQLKhachHangService _qLKhachHangService;
        Guid _idWhenclick;
        public FrmQlKhachHang()
        {
            InitializeComponent();
            _qLKhachHangService = new QLKhachHangService();
            LoadData();
        }
        public void LoadData()
        {
            dgridKhachHang.ColumnCount = 11;
            dgridKhachHang.Columns[0].Name = "id";
            dgridKhachHang.Columns[1].Name = "Mã";
            dgridKhachHang.Columns[2].Name = "Tên";
            dgridKhachHang.Columns[3].Name = "Tên Đệm";
            dgridKhachHang.Columns[4].Name = "Họ";
            dgridKhachHang.Columns[5].Name = "Ngày Sinh";
            dgridKhachHang.Columns[6].Name = "Số ĐT";
            dgridKhachHang.Columns[7].Name = "Địa Chỉ";
            dgridKhachHang.Columns[8].Name = "Thành Phố";
            dgridKhachHang.Columns[9].Name = "Quốc Gia";
            dgridKhachHang.Columns[10].Name = "Mật Khẩu";
            dgridKhachHang.Rows.Clear();
            foreach (var x in _qLKhachHangService.GetAll())
            {
                dgridKhachHang.Rows.Add(x.Id, x.Ma, x.Ten,x.TenDem,x.Ho,x.NgaySinh,x.Sdt,x.DiaChi,x.ThanhPho,x.QuocGia,x.MatKhau);
            }
        }
        public KhachHang GetDataFromGui()
        {
            return new KhachHang() { Ten = txtTen.Text, Ma = txtMa.Text, TenDem=txtTenDem.Text,Ho=txtHo.Text,NgaySinh=dateNgaySinh.Value,Sdt=txtSdt.Text,DiaChi=txtDiaChi.Text,ThanhPho=txtThanhPho.Text,QuocGia=txtQuocGia.Text,MatKhau=txtMatkhau.Text };
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_qLKhachHangService.Add(GetDataFromGui()));
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = GetDataFromGui();
            obj.Id = _idWhenclick;
            MessageBox.Show(_qLKhachHangService.Update(obj));
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = GetDataFromGui();
            obj.Id = _idWhenclick;
            MessageBox.Show(_qLKhachHangService.Delete(obj));
            LoadData();
        }

        private void dgridKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _qLKhachHangService.GetAll().Count || rowIndex == -1) return;
            _idWhenclick = Guid.Parse(dgridKhachHang.Rows[rowIndex].Cells[0].Value.ToString());
            var khachhang = _qLKhachHangService.GetAll().FirstOrDefault(c => c.Id == _idWhenclick);
            txtMa.Text = khachhang.Ma;
            txtTen.Text = khachhang.Ten;
            txtTenDem.Text = khachhang.TenDem;
            txtHo.Text = khachhang.Ho;
            dateNgaySinh.Value = (DateTime)khachhang.NgaySinh;
            txtSdt.Text = khachhang.Sdt;
            txtDiaChi.Text = khachhang.DiaChi;
            txtThanhPho.Text = khachhang.ThanhPho;
            txtQuocGia.Text = khachhang.QuocGia;
            txtMatkhau.Text = khachhang.MatKhau;

        }
    }
}
