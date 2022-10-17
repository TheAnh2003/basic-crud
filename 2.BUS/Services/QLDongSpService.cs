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
    public class QLDongSpService : IQLDongSpService
    {
        private IDongSPRepository _iDongSpRepo;
        public QLDongSpService()
        {
            _iDongSpRepo= new DongSPRepository();
        }
        public string Add(DongSp obj)
        {
            if (obj == null) return "Thêm thất bại";

            if (_iDongSpRepo.Add(obj))
                return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(DongSp obj)
        {
            if (obj == null) return "Xóa thất bại";
            if (_iDongSpRepo.Delete(obj))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<DongSp> GetAll()
        {
            return _iDongSpRepo.GetAll().ToList();
        }

        public string Update(DongSp obj)
        {
            if (obj == null) return "Sửa thất bại";
            if (_iDongSpRepo.Update(obj))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
