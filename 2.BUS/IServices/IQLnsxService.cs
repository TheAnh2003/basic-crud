using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLnsxService
    {
        string Add(Nsx obj);
        string Update(Nsx obj);
        string Delete(Nsx obj);
        List<Nsx> GetAll();
    }
}
