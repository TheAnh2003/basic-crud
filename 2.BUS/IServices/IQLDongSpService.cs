using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLDongSpService
    {
        string Add(DongSp obj);
        string Update(DongSp obj);
        string Delete(DongSp obj);
        List<DongSp> GetAll();
    }
}
