using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class NhanVienRepository : INhanVienRepository
    {
        FpolyDBContext _dBContext;
        public NhanVienRepository()
        {
            _dBContext =new FpolyDBContext();
        }
        public bool Add(NhanVien obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dBContext.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _dBContext.NhanViens.ToList();
        }

        public NhanVien GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.NhanViens.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.TenDem = obj.TenDem;
            tempobj.Ho = obj.Ho;
            tempobj.GioiTinh = obj.GioiTinh;
            tempobj.NgaySinh = obj.NgaySinh;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.Sdt = obj.Sdt;
            tempobj.MatKhau = obj.MatKhau;
            tempobj.TrangThai = obj.TrangThai;
            tempobj.IdGuiBc = obj.IdGuiBc;
            tempobj.IdCh = obj.IdCh;
            tempobj.IdCv = obj.IdCv;
            _dBContext.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
