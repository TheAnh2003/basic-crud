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
    public class SanPhamRepository:ISanPhamRepository
    {
        FpolyDBContext _dBContext;
        public SanPhamRepository()
        {
            _dBContext = new FpolyDBContext();

        }

        public bool Add(SanPham obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dBContext.SanPhams.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(SanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.SanPhams.FirstOrDefault(c => c.Id == obj.Id);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<SanPham> GetAll()
        {
            return _dBContext.SanPhams.ToList();
        }

        public SanPham GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.SanPhams.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(SanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.SanPhams.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ten = obj.Ten;
            tempobj.Ma = obj.Ma;
            _dBContext.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
