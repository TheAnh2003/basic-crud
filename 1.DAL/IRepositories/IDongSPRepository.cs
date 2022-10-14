using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IDongSPRepository
    {
        bool Add(DongSp obj);
        bool Update(DongSp obj);
        bool Delete(DongSp obj);
        DongSp GetById(Guid id);//Phương thức tìm sản phẩm theo id
        List<DongSp> GetAll();
    }
}
