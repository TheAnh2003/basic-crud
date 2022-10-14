using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class GioHangChiTietRepository : IGioHangChiTietRepository
    {
        FpolyDBContext _dbContext;
        public GioHangChiTietRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(GioHangChiTiet obj)
        {
            if(obj== null)return false;
            _dbContext.GioHangChiTiets.Add(obj);
            _dbContext.SaveChanges();
            return true;
            
        }

        public bool Delete(GioHangChiTiet obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.GioHangChiTiets.FirstOrDefault(c => c.IdGioHang == obj.IdGioHang);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
            
        }

        public List<GioHangChiTiet> GetAll()
        {
            return _dbContext.GioHangChiTiets.ToList();
        }

        public GioHangChiTiet GetById(Guid id)
        {
            if(id==Guid.Empty) return null;
            return _dbContext.GioHangChiTiets.FirstOrDefault(c => c.IdGioHang == id);
        }

        public bool Update(GioHangChiTiet obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.GioHangChiTiets.FirstOrDefault(c => c.IdGioHang == obj.IdGioHang);
            tempobj.IdChiTietSp=obj.IdChiTietSp;
            tempobj.SoLuong = obj.SoLuong;
            tempobj.DonGia = obj.DonGia;
            tempobj.DonGiaKhiGiam = obj.DonGiaKhiGiam;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
