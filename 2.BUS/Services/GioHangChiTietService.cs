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
    public class GioHangChiTietService : IQLGioHangChiTietService
    {
        private IGioHangChiTietRepository _iGioHangChiTiet;
        private IChiTietSPRepository _iChiTietSP;

        private IGioHangRepository iGioHangRepository;

        private ISanPhamRepository iSanPhamRepository;
        public GioHangChiTietService()
        {
            _iGioHangChiTiet = new GioHangChiTietRepository();
            _iChiTietSP = new ChiTietSPRepository();
            iSanPhamRepository = new SanPhamRepository();
            iGioHangRepository = new GioHangRepository();
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
            List<ViewGioHangChiTiet> lst = new List<ViewGioHangChiTiet>();
            lst = (from a in _iGioHangChiTiet.GetAll()
                   join b in iGioHangRepository.GetAll() on a.IdGioHang equals b.Id
                   join c in _iChiTietSP.GetAll() on a.IdChiTietSp equals c.Id
                   join d in iSanPhamRepository.GetAll() on c.IdSp equals d.Id
                   select new ViewGioHangChiTiet()
                   {
                       GioHangChiTiet = a,
                       GioHang = b,
                       ChiTietSp = c,
                       SanPham = d
                   }).ToList();
            return lst;
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
