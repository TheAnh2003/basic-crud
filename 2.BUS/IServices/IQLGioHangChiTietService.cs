using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLGioHangChiTietService
    {
        string Add(ViewGioHangChiTiet obj);
        string Update(ViewGioHangChiTiet obj);
        string Delete(ViewGioHangChiTiet obj);
        List<ViewGioHangChiTiet> GetAll();
    }
}
