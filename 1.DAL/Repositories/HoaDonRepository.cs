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
    public class HoaDonRepository : IHoaDonReposirory
    {
        FpolyDBContext _dBContext;
        public HoaDonRepository()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(HoaDon obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dBContext.HoaDons.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<HoaDon> GetAll()
        {
            return _dBContext.HoaDons.ToList();
        }

        public HoaDon GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.HoaDons.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(HoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.IdKh = obj.IdKh;
            tempobj.IdNv = obj.IdNv;
            tempobj.Ma = obj.Ma;
            tempobj.NgayTao = obj.NgayTao;
            tempobj.NgayThanhToan = obj.NgayThanhToan;
            tempobj.NgayShip = obj.NgayShip;
            tempobj.NgayNhan = obj.NgayNhan;
            tempobj.TenNguoiNhan = obj.TenNguoiNhan;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.Sdt = obj.Sdt;
            tempobj.TinhTrang = obj.TinhTrang;
            _dBContext.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
