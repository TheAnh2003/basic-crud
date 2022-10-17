using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewHoaDonChiTiet
    {
        public HoaDonChiTiet HoaDonChiTiet { get; set; }
        public HoaDon HoaDon { get; set; }
        public ChiTietSp ChiTietSp { get; set; }
    }
}
