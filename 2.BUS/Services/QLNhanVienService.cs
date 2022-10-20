using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Service
{
    public class QLNhanVienService:IQLNhanVienService
    {
        INhanVienRepository _nhanVienRepository;
        ICuaHangRepository _cuaHangRepository;
        IChucVuRepository _chucVuRepository;
        public QLNhanVienService()
        {
            _nhanVienRepository = new NhanVienRepository();
            _cuaHangRepository = new CuaHangRepository();
            _chucVuRepository = new ChucVuRepository();
        }

        public string Add(ViewNhanVien obj)
        {
            if (obj == null) return "thêm không thành công";
            var nv = obj.NhanVien;
            if (_nhanVienRepository.Add(nv)) return "thêm thành công";
            return "thêm không thành công";
        }

        public string Delete(ViewNhanVien obj)
        {
            if (obj == null) return "xóa không thành công";
            var nv = obj.NhanVien;
            if (_nhanVienRepository.Delete(nv)) return "xóa thành công";
            return "xóa không thành công";
        }

        public List<ViewNhanVien> GetAll()
        {
            List<ViewNhanVien> LstNv = new List<ViewNhanVien>();
            LstNv =
                (from a in _nhanVienRepository.GetAll()
                 join b in _cuaHangRepository.GetAll() on a.IdCh equals b.Id
                 join c in _chucVuRepository.GetAll() on a.IdCv equals c.Id
                 select new ViewNhanVien()
                 {
                     NhanVien = a,
                     ChucVu=c,
                     CuaHang=b
                 }).ToList();
            return LstNv;
        }

        public string Update(ViewNhanVien obj)
        {
            if (obj == null) return "sửa không thành công";
            var nv = obj.NhanVien;
            if (_nhanVienRepository.Update(nv)) return "sửa thành công";
            return "sửa không thành công";
        }


    }
}
