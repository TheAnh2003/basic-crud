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
    public class QLNhanVienService : IQLNhanVienService
    {
        private INhanVienRepository _iNhaVienRepo;
        private ICuaHangRepository _cuaHangRepo;
        private IChucVuRepository _chucVuRepo;
        public string Add(ViewNhanVien obj)
        {
            if (obj == null) return "Thêm thất bại";
            var ghct = obj.NhanVien;
            if (_iNhaVienRepo.Add(ghct))
                return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(ViewNhanVien obj)
        {
            if (obj == null) return "Xóa thất bại";
            var ghct = obj.NhanVien;

            if (_iNhaVienRepo.Delete(ghct))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<ViewNhanVien> GetAll()
        {
            List<ViewNhanVien> list = new List<ViewNhanVien>();
            list = (
                from a in _iNhaVienRepo.GetAll()
                join b in _chucVuRepo.GetAll() on a.IdCv equals b.Id
                join c in _cuaHangRepo.GetAll() on a.IdCh equals c.Id
                select new ViewNhanVien()
                {
                    NhanVien = a,
                    ChucVu = b,
                    CuaHang = c
                }).ToList();
            return list;
        }

        public string Update(ViewNhanVien obj)
        {
            if (obj == null) return "Sửa thất bại";
            var ghct = obj.NhanVien;

            if (_iNhaVienRepo.Update(ghct))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
