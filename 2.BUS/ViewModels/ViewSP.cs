using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewSP
    {
        public ChiTietSp ChiTietSp { get; set; }
        public SanPham SanPham { get; set; }
        public MauSac MauSac { get; set; }
        public Nsx Nsx { get; set; }
        public DongSp DongSp { get; set; }
    }
}
