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
    public class QLGioHangService : IQLGioHangService
    {
        private IGioHangRepository _iGioHangRepo;
        private IKhachHangRepository _iKhachHangRepo;
        private INhanVienRepository _iNhanVienRepo;
        public QLGioHangService()
        {
            _iGioHangRepo = new GioHangRepository();
            _iKhachHangRepo = new KhachHangRepository();
            _iNhanVienRepo = new NhanVienRepository();
        }
        public string Add(ViewGioHang obj)
        {
            if (obj == null) return "Thêm thất bại";
            var gh = obj.GioHang;
            if (_iGioHangRepo.Add(gh))
                return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(ViewGioHang obj)
        {
            if (obj == null) return "Xóa thất bại";
            var gh = obj.GioHang;

            if (_iGioHangRepo.Delete(gh))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<ViewGioHang> GetAll()
        {
            List<ViewGioHang> lstGioHang = new List<ViewGioHang>();
            
            lstGioHang =
               (
                from b in _iGioHangRepo.GetAll()
                join c in _iKhachHangRepo.GetAll() on b.IdKh equals c.Id
                join d in _iNhanVienRepo.GetAll() on b.IdNv equals d.Id
                select new ViewGioHang()
                {
                    GioHang = b,
                    KhachHang = c,
                    NhanVien = d,
                }).ToList();
            return lstGioHang;
        }

        public string Update(ViewGioHang obj)
        {
            if (obj == null) return "Sửa thất bại";
            var gh = obj.GioHang;

            if (_iGioHangRepo.Update(gh))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
