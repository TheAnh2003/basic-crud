﻿using _1.DAL.DomainClass;
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
    public class QlSanPhamService : IQLSanPhamService
    {
        private ISanPhamRepository _iSanPhamRepo;
        public QlSanPhamService()
        {
            _iSanPhamRepo = new SanPhamRepository();
        }
        public string Add(SanPham obj)
        {
            if (obj == null) return "Thêm thất bại";

            if (_iSanPhamRepo.Add(obj))
                return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(SanPham obj)
        {
            if (obj == null) return "Xóa thất bại";
            if (_iSanPhamRepo.Delete(obj))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<SanPham> GetAll()
        {
            return _iSanPhamRepo.GetAll().ToList();
        }

        public string Update(SanPham obj)
        {
            if (obj == null) return "Sửa thất bại";
            if (_iSanPhamRepo.Update(obj))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
