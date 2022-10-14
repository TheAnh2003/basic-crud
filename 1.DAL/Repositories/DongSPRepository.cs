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
    public class DongSPRepository : IDongSPRepository
    {
        FpolyDBContext _dBContext;
        public DongSPRepository()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(DongSp obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//Tự động rend khóa chính
            _dBContext.DongSps.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(DongSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.DongSps.FirstOrDefault(c => c.Id == obj.Id);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<DongSp> GetAll()
        {
            return _dBContext.DongSps.ToList();
        }

        public DongSp GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.DongSps.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(DongSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.Nsxes.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ten = obj.Ten;
            tempobj.Ma = obj.Ma;
            _dBContext.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
