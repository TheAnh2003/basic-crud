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
    public class ChiTietSPRepository : IChiTietSPRepository
    {
        FpolyDBContext _dBContext;
        public ChiTietSPRepository()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(ChiTietSp obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dBContext.ChiTietSps.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }
        public bool Update(ChiTietSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.ChiTietSps.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.GiaBan = obj.GiaBan;
            tempobj.GiaNhap = obj.GiaNhap;
            tempobj.IdDongSp = obj.IdDongSp;
            tempobj.IdMauSac = obj.IdMauSac;
            tempobj.IdNsx=obj.IdNsx;
            tempobj.IdSp=obj.IdSp;
            tempobj.NamBh=obj.NamBh;
            tempobj.MoTa = obj.MoTa;
            tempobj.SoLuongTon = obj.SoLuongTon;
            _dBContext.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.ChiTietSps.FirstOrDefault(c => c.Id == obj.Id);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;

        }

        public List<ChiTietSp> GetAll()
        {
            return _dBContext.ChiTietSps.ToList();
        }

        public ChiTietSp GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.ChiTietSps.FirstOrDefault(c => c.Id == id);
        }

    }
}
