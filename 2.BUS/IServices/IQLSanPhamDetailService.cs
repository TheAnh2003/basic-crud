using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLSanPhamDetailService
    {
        string Add(ViewSP obj);
        string Update(ViewSP obj);
        string Delete(ViewSP obj);
        List<ViewSP> GetAll();
    }
}
