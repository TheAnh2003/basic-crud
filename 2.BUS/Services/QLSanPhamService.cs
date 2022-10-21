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
    public class QlSanPhamService : IQLSanPhamService
    {
        private ISanPhamRepository _iSanPhamRepo;
        public QlSanPhamService()
        {
            _iSanPhamRepo = new SanPhamRepository();
        }
        public string Add(SanPhamView obj)
        {
            if (obj == null) return "Thêm thất bại";

            if (_iSanPhamRepo.Add(obj.SanPham))
                return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(SanPhamView obj)
        {
            if (obj == null) return "Xóa thất bại";
            if (_iSanPhamRepo.Delete(obj.SanPham))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<SanPhamView> GetAll()
        {
            List<SanPhamView> _lst = new List<SanPhamView>();
            _lst = (from a in _iSanPhamRepo.GetAll()
                    select new SanPhamView()
                    {
                        SanPham = a
                    }).ToList();
            return _lst;
        }

        public string Update(SanPhamView obj)
        {
            if (obj == null) return "Sửa thất bại";
            if (_iSanPhamRepo.Update(obj.SanPham))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
