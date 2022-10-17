using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonReposirory
    {
        bool Add(HoaDon obj);
        bool Update(HoaDon obj);
        bool Delete(HoaDon obj);
        HoaDon GetById(Guid id);//Phương thức tìm sản phẩm theo id
        List<HoaDon> GetAll();
    }
}
