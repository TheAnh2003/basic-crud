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
    public class QLKhachHangService : IQLKhachHangService
    {
        private IKhachHangRepository _iKhachHangRepo;
        public QLKhachHangService()
        {
            _iKhachHangRepo = new KhachHangRepository();
        }
        public string Add(KhachHang obj)
        {
            if (obj == null) return "Thêm thất bại";

            if (_iKhachHangRepo.Add(obj))
                return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(KhachHang obj)
        {
            if (obj == null) return "Xóa thất bại";
            if (_iKhachHangRepo.Delete(obj))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<KhachHang> GetAll()
        {
            return _iKhachHangRepo.GetAll().ToList();
        }

        public string Update(KhachHang obj)
        {
            if (obj == null) return "Sửa thất bại";
            if (_iKhachHangRepo.Update(obj))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
