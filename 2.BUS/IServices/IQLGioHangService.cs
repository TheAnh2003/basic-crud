using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
   public interface IQLGioHangService
    {
        string Add(ViewGioHang obj);
        string Update(ViewGioHang obj);
        string Delete(ViewGioHang obj);
        List<ViewGioHang> GetAll();
    }
}
