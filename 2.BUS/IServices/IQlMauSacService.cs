using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQlMauSacService
    {
        string Add(MauSac obj);
        string Update(MauSac obj);
        string Delete(MauSac obj);
        List<MauSac> GetAll();
    }
}
