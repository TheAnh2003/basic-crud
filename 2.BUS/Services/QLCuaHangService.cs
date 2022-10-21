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
    public class QLCuaHangService : IQLCuaHangService
    {
        private ICuaHangRepository _iCuaHangRepo;
        public QLCuaHangService()
        {
            _iCuaHangRepo = new CuaHangRepository();
        }
        public string Add(CuaHangView obj)
        {
            if (obj == null) return "Thêm thất bại";

            if (_iCuaHangRepo.Add(obj.CuaHang))
                return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(CuaHangView obj)
        {
            if (obj == null) return "Xóa thất bại";
            if (_iCuaHangRepo.Delete(obj.CuaHang))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<CuaHangView> GetAll()
        {
            List<CuaHangView> lst = new List<CuaHangView>();
            lst = (from a in _iCuaHangRepo.GetAll()
                   select new CuaHangView()
                   {
                       CuaHang = a
                   }).OrderBy(x => x.CuaHang.Ma).ToList();
            return lst;
        }

        public string Update(CuaHangView obj)
        {
            if (obj == null) return "Sửa thất bại";
            if (_iCuaHangRepo.Update(obj.CuaHang))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
