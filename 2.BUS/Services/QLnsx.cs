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
    public class QLnsx : IQLnsxService
    {
        private INsxRepository _iNsxRepo;
        public QLnsx()
        {
            _iNsxRepo = new NsxRepository();
        }
        public string Add(NsxView obj)
        {
            if (obj == null) return "Thêm thất bại";

            if (_iNsxRepo.Add(obj.Nsx))
                return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(NsxView obj)
        {
            if (obj == null) return "Xóa thất bại";
            if (_iNsxRepo.Delete(obj.Nsx))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<NsxView> GetAll()
        {
            List<NsxView> _lst = new List<NsxView>();
            _lst =
                (from a in _iNsxRepo.GetAll()
                 select new NsxView()
                 {
                     Nsx = a
                 }).ToList();
            return _lst;
        }

        public string Update(NsxView obj)
        {
            if (obj == null) return "Sửa thất bại";
            if (_iNsxRepo.Update(obj.Nsx))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
        public List<NsxView> GetById(Guid obj)
        {
            if (obj == Guid.Empty) return null;
            List<NsxView> _lst = new List<NsxView>()
            {
                new NsxView(){Nsx = _iNsxRepo.GetById(obj)},
            };
            return _lst;
        }

    }
}
