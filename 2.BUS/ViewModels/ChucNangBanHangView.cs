using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;

namespace _2.BUS.ViewModels
{
    public class ChucNangBanHangView
    {
        public ChiTietSp ChiTietSp { get; set; }
        public ChucVu ChucVu { get; set; }
        public CuaHang CuaHang { get; set; }
        public DongSp DongSp { get; set; }
        public GioHang GioHang { get; set; }
        public GioHangChiTiet GioHangChiTiet { get; set; }
        public HoaDon HoaDon { get; set; }
        public HoaDonChiTiet HoaDonChiTiet{ get; set; }
        public KhachHang KhachHang{ get; set; }
        public MauSac MauSac{ get; set; }
        public NhanVien NhanVien{ get; set; }
        public Nsx Nsx{ get; set; }
        public SanPham SanPham { get; set; }
    }
}
