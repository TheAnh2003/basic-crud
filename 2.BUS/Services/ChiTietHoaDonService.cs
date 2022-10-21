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
    public class ChiTietHoaDonService : IChiTietHoaDonService
    {
        private IHoaDonChiTietRepository _iHoaDonCTRepo;
        private IChiTietSPRepository _iChiTietSpRepo;
        public ChiTietHoaDonService()
        {
            _iHoaDonCTRepo = new HoaDonChiTietRepository();
            _iChiTietSpRepo = new ChiTietSPRepository();
        }
        public string Add(ViewHoaDonChiTiet obj)
        {
            if (obj == null) return "Thêm thất bại";
            var hdct = obj.HoaDonChiTiet;
            if (_iHoaDonCTRepo.Add(hdct))
                return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(ViewHoaDonChiTiet obj)
        {
            if (obj == null) return "Xóa thất bại";
            var hdct = obj.HoaDonChiTiet;

            if (_iHoaDonCTRepo.Delete(hdct))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<ViewHoaDonChiTiet> GetAll()
        {
            List<ViewHoaDonChiTiet> lstPhamViews = new List<ViewHoaDonChiTiet>();
            //Viết 1 câu linq để gán giá trị cho từng prop của ViewSP
            lstPhamViews =
               (from b in _iHoaDonCTRepo.GetAll()
                join c in _iChiTietSpRepo.GetAll() on b.IdChiTietSp equals c.Id
                select new ViewHoaDonChiTiet()
                {
                    HoaDonChiTiet = b,
                    ChiTietSp = c
                    
                }).ToList();
            return lstPhamViews;
        }

        public string Update(ViewHoaDonChiTiet obj)
        {
            if (obj == null) return "Sửa thất bại";
            var hdct = obj.HoaDonChiTiet;

            if (_iHoaDonCTRepo.Update(hdct))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
