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
    public class QlMauSacService : IQlMauSacService
    {
        private IMauSacRepository _iMauSacRepo;
        public QlMauSacService()
        {
            _iMauSacRepo = new MauSacRepository();
        }
        public string Add(MauSacView obj)
        {
            if (obj == null) return "Thêm thất bại";
         
            if (_iMauSacRepo.Add(obj.MauSac))
                return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(MauSacView obj)
        {
            if (obj == null) return "Xóa thất bại";
            if (_iMauSacRepo.Delete(obj.MauSac))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<MauSacView> GetAll()
        {
            List<MauSacView> list = new List<MauSacView>();
            list = (from a in _iMauSacRepo.GetAll()
                    select new MauSacView()
                    {
                        MauSac = a
                    }).ToList();
            return list;
        }

        public string Update(MauSacView obj)
        {
            if (obj == null) return "Sửa thất bại";
            if (_iMauSacRepo.Update(obj.MauSac))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
