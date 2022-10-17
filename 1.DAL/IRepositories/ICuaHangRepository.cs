using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ICuaHangRepository
    {
        bool Add(CuaHang obj);
        bool Update(CuaHang obj);
        bool Delete(CuaHang obj);
        CuaHang GetById(Guid id);//Phương thức tìm sản phẩm theo id
        List<CuaHang> GetAll();
    }
}
