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
    public class QLChucVuService : IQLChucVuService
    {
        private IChucVuRepository _iChucVuRepo;
        public QLChucVuService()
        {
            _iChucVuRepo = new ChucVuRepository();
        }
        public string Add(ChucVuView obj)
        {
            if (obj == null) return "Thêm thất bại";

            if (_iChucVuRepo.Add(obj.ChucVu))
                return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(ChucVuView obj)
        {
            if (obj == null) return "Xóa thất bại";
            if (_iChucVuRepo.Delete(obj.ChucVu))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<ChucVuView> GetAll()
        {
            return (from a in _iChucVuRepo.GetAll()
                    select new ChucVuView()
                    {
                        ChucVu = a
                    }).ToList();
        }

        public string Update(ChucVuView obj)
        {
            if (obj == null) return "Sửa thất bại";
            if (_iChucVuRepo.Update(obj.ChucVu))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
