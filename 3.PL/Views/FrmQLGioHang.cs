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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.View
{
    public partial class FrmQLGioHang : Form
    {
        IQLKhachHangService _qLKhachHangService;
        IQLNhanVienService _qNhanVienService;
        IQLGioHangService _qGioHangService;
        public FrmQLGioHang()
        {
            InitializeComponent();
            _qLKhachHangService = new QLKhachHangService();
            _qNhanVienService = new QLNhanVienService();
            _qGioHangService = new QLGioHangService();
            loadCacLoai();
            LoadData();
        }
        public void loadCacLoai()
        {
            cmbKhachHang.Items.Add("Chọn Khách Hàng");
            cmbNhanVien.Items.Add("Chọn Nhân Viên");
            foreach (var x in _qLKhachHangService.GetAll())
            {
                cmbKhachHang.Items.Add(x.Ten);
            }
            foreach (var x in _qNhanVienService.GetAll())
            {
                cmbNhanVien.Items.Add(x.NhanVien.Ten);
            }
            cmbKhachHang.SelectedIndex = 0;
            cmbNhanVien.SelectedIndex = 0;
        }
        private void LoadData()
        {
            int stt = 1;
            dgridGioHang.ColumnCount = 8;
            dgridGioHang.Columns[0].Name = "Stt";
            dgridGioHang.Columns[1].Name = "ID";
            dgridGioHang.Columns[2].Name = "Mã";
            dgridGioHang.Columns[3].Name = "Ngày Tạo";
            dgridGioHang.Columns[4].Name = "Ngày Thanh Toán";
            dgridGioHang.Columns[5].Name = "Tên Người Nhận";
            dgridGioHang.Columns[6].Name = "SĐT";
            dgridGioHang.Columns[7].Name = "Tình Trạng";

            dgridGioHang.Rows.Clear();
            foreach (var x in _qGioHangService.GetAll())
            {
                dgridGioHang.Rows.Add(stt++, x.GioHang.Id, x.GioHang.Ma, x.GioHang.NgayTao, x.GioHang.NgayThanhToan, x.GioHang.DiaChi, x.GioHang.Sdt, (x.GioHang.TinhTrang == 1 ? "Hoạt động" : "Không hoạt động"));
            }
        }
        public void GetdataFromGui()
        {
            ViewGioHang gioHang = new ViewGioHang();
            gioHang.GioHang = new GioHang()
            {

            };


        }
    }
}

