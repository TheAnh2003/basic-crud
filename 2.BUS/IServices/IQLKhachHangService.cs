using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLKhachHangService
    {
        string Add(KhachHang obj);
        string Update(KhachHang obj);
        string Delete(KhachHang obj);
        List<KhachHang> GetAll();
    }
}
