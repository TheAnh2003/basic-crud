using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLDongSpService
    {
        string Add(DongSpView obj);
        string Update(DongSpView obj);
        string Delete(DongSpView obj);
        List<DongSpView> GetAll();
    }
}
