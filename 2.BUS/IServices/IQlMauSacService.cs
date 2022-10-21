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
        string Add(MauSacView obj);
        string Update(MauSacView obj);
        string Delete(MauSacView obj);
        List<MauSacView> GetAll();
    }
}
