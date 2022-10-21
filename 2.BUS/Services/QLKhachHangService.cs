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
    public class QLKhachHangService : IQLKhachHangService
    {
        private IKhachHangRepository _iKhachHangRepo;
        public QLKhachHangService()
        {
            _iKhachHangRepo = new KhachHangRepository();
        }
        public string Add(KhachHangView obj)
        {
            if (obj == null) return "Thêm thất bại";

            if (_iKhachHangRepo.Add(obj.KhachHang))
                return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(KhachHangView obj)
        {
            if (obj == null) return "Xóa thất bại";
            if (_iKhachHangRepo.Delete(obj.KhachHang))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<KhachHangView> GetAll()
        {
            List<KhachHangView> lst = new List<KhachHangView>();
            lst = (from a in _iKhachHangRepo.GetAll()
                   select new KhachHangView()
                   {
                       KhachHang = a
                   }).OrderBy(x => x.KhachHang.Ma).ToList();
            return lst;
        }

        public string Update(KhachHangView obj)
        {
            if (obj == null) return "Sửa thất bại";
            if (_iKhachHangRepo.Update(obj.KhachHang))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
