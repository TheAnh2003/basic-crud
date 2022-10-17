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
    public class QLCuaHangService : IQLCuaHangService
    {
        private ICuaHangRepository _iCuaHangRepo;
        public QLCuaHangService()
        {
            _iCuaHangRepo = new CuaHangRepository();
        }
        public string Add(CuaHang obj)
        {
            if (obj == null) return "Thêm thất bại";

            if (_iCuaHangRepo.Add(obj))
                return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(CuaHang obj)
        {
            if (obj == null) return "Xóa thất bại";
            if (_iCuaHangRepo.Delete(obj))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<CuaHang> GetAll()
        {
            return _iCuaHangRepo.GetAll().ToList();
        }

        public string Update(CuaHang obj)
        {
            if (obj == null) return "Sửa thất bại";
            if (_iCuaHangRepo.Update(obj))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
