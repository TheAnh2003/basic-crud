using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
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
        public string Add(Nsx obj)
        {
            if (obj == null) return "Thêm thất bại";

            if (_iNsxRepo.Add(obj))
                return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(Nsx obj)
        {
            if (obj == null) return "Xóa thất bại";
            if (_iNsxRepo.Delete(obj))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<Nsx> GetAll()
        {
            return _iNsxRepo.GetAll().ToList();
        }

        public string Update(Nsx obj)
        {
            if (obj == null) return "Sửa thất bại";
            if (_iNsxRepo.Update(obj))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
