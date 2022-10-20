using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewNhanVien
    {
        public NhanVien NhanVien { get; set; }
        public CuaHang CuaHang { get; set; }
        public ChucVu ChucVu { get; set; }
        
    }
}
