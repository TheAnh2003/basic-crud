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
    public class QLHoaDonService : IQLHoaDonService
    {
        private IHoaDonReposirory _iHoaDonRepo;
        private IKhachHangRepository _iKhachHangRepo;
        private INhanVienRepository _iNhanVienRepo;
        public QLHoaDonService()
        {
            _iHoaDonRepo = new HoaDonRepository();
            _iKhachHangRepo = new KhachHangRepository();
            _iNhanVienRepo = new NhanVienRepository();
        }
        public string Add(ViewHoaDon obj)
        {
            if (obj == null) return "Thêm thất bại";
            var hd = obj.HoaDon;

            if (_iHoaDonRepo.Add(hd))
                return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(ViewHoaDon obj)
        {
            if (obj == null) return "Xóa thất bại";
            var hd = obj.HoaDon;

            if (_iHoaDonRepo.Delete(hd))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<ViewHoaDon> GetAll()
        {
            List<ViewHoaDon> lst = new List<ViewHoaDon>();
            //Viết 1 câu linq để gán giá trị cho từng prop của ViewSP
            lst =
               (from b in _iHoaDonRepo.GetAll()
                join c in _iKhachHangRepo.GetAll() on b.IdKh equals c.Id
                join d in _iNhanVienRepo.GetAll() on b.IdNv equals d.Id
                select new ViewHoaDon()
                {
                    HoaDon = b,
                    KhachHang = c,
                    NhanVien = d,
                }).ToList();
            return lst;
        }

        public string Update(ViewHoaDon obj)
        {
            if (obj == null) return "Sửa thất bại";
            var hd = obj.HoaDon;

            if (_iHoaDonRepo.Update(hd))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
