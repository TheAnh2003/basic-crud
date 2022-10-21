using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLDongSpService : IQLDongSpService
    {
        private IDongSPRepository _iDongSpRepo;
        public QLDongSpService()
        {
            _iDongSpRepo= new DongSPRepository();
        }
        public string Add(DongSpView obj)
        {
            if (obj == null) return "Thêm thất bại";

            if (_iDongSpRepo.Add(obj.DongSp))
                return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(DongSpView obj)
        {
            if (obj == null) return "Xóa thất bại";
            if (_iDongSpRepo.Delete(obj.DongSp))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<DongSpView> GetAll()
        {
            List<DongSpView> lstDongSpViews = new List<DongSpView>();
            lstDongSpViews = (from a in _iDongSpRepo.GetAll()
                              select new DongSpView()
                              {
                                  DongSp = a
                              }).ToList();
            return lstDongSpViews;
        }

        public string Update(DongSpView obj)
        {
            if (obj == null) return "Sửa thất bại";
            if (_iDongSpRepo.Update(obj.DongSp))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
