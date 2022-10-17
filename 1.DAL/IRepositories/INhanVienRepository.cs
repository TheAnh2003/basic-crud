using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface INhanVienRepository
    {
        bool Add(NhanVien obj);
        bool Update(NhanVien obj);
        bool Delete(NhanVien obj);
        NhanVien GetById(Guid id);//Phương thức tìm sản phẩm theo id
        List<NhanVien> GetAll();
    }
}
