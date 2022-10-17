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
    public class QLChucVuService : IQLChucVuService
    {
        private IChucVuRepository _iChucVuRepo;
        public QLChucVuService()
        {
            _iChucVuRepo = new ChucVuRepository();
        }
        public string Add(ChucVu obj)
        {
            if (obj == null) return "Thêm thất bại";

            if (_iChucVuRepo.Add(obj))
                return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(ChucVu obj)
        {
            if (obj == null) return "Xóa thất bại";
            if (_iChucVuRepo.Delete(obj))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<ChucVu> GetAll()
        {
            return _iChucVuRepo.GetAll().ToList();
        }

        public string Update(ChucVu obj)
        {
            if (obj == null) return "Sửa thất bại";
            if (_iChucVuRepo.Update(obj))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
