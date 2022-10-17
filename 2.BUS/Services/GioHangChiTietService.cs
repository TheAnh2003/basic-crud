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
    public class GioHangChiTietService:IQLGioHangChiTietService
    {
        private IGioHangChiTietRepository _iGioHangChiTiet;
        private IChiTietSPRepository _iChiTietSP;
        public GioHangChiTietService()
        {
            _iGioHangChiTiet = new GioHangChiTietRepository();
            _iChiTietSP = new ChiTietSPRepository();
        }

        public string Add(ViewGioHangChiTiet obj)
        {
            if (obj == null) return "Thêm thất bại";
            var ghct = obj.GioHangChiTiet;
            if (_iGioHangChiTiet.Add(ghct))
                return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(ViewGioHangChiTiet obj)
        {
            if (obj == null) return "Xóa thất bại";
            var ghct = obj.GioHangChiTiet;

            if (_iGioHangChiTiet.Delete(ghct))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<ViewGioHangChiTiet> GetAll()
        {
            List<ViewGioHangChiTiet> list = new List<ViewGioHangChiTiet>();
            list = (
                from a in _iChiTietSP.GetAll()
                join b in _iGioHangChiTiet.GetAll() on a.Id equals b.IdChiTietSp
                select new ViewGioHangChiTiet()
                {
                    ChiTietSp = a,
                    GioHangChiTiet = b
                }).ToList();
            return list;
        }

        public string Update(ViewGioHangChiTiet obj)
        {
            if (obj == null) return "Sửa thất bại";
            var ghct = obj.GioHangChiTiet;

            if (_iGioHangChiTiet.Update(ghct))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
