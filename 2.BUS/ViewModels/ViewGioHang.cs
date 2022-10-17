using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewGioHang
    {
        public GioHang GioHang { get; set; }
        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
