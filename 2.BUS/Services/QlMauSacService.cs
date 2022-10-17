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
    public class QlMauSacService : IQlMauSacService
    {
        private IMauSacRepository _iMauSacRepo;
        public QlMauSacService()
        {
            _iMauSacRepo = new MauSacRepository();
        }
        public string Add(MauSac obj)
        {
            if (obj == null) return "Thêm thất bại";
         
            if (_iMauSacRepo.Add(obj))
                return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(MauSac obj)
        {
            if (obj == null) return "Xóa thất bại";
            if (_iMauSacRepo.Delete(obj))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<MauSac> GetAll()
        {
            return _iMauSacRepo.GetAll().ToList();
        }

        public string Update(MauSac obj)
        {
            if (obj == null) return "Sửa thất bại";
            if (_iMauSacRepo.Update(obj))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
