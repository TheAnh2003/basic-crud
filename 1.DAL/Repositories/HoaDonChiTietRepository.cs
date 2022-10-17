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
    public class HoaDonChiTietRepository : IHoaDonChiTietRepository
    {
        FpolyDBContext _dbContext;
        public HoaDonChiTietRepository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.HoaDonChiTiets.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.HoaDonChiTiets.FirstOrDefault(c => c.IdHoaDon == obj.IdHoaDon);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _dbContext.HoaDonChiTiets.ToList();
        }

        public HoaDonChiTiet GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.HoaDonChiTiets.FirstOrDefault(c => c.IdHoaDon == id);
        }

        public bool Update(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.HoaDonChiTiets.FirstOrDefault(c => c.IdHoaDon == obj.IdHoaDon);
            tempobj.IdChiTietSp = obj.IdChiTietSp;
            tempobj.SoLuong = obj.SoLuong;
            tempobj.DonGia = obj.DonGia;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
