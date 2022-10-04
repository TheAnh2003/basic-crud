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
    public class MauSacRepository:IMauSacRepository
    {
        FpolyDBContext _dBContext;

        public MauSacRepository()
        {
            _dBContext = new FpolyDBContext();

        }

        public bool Add(MauSac obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();//Tự động rend khóa chính
            _dBContext.MauSacs.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(MauSac obj)
        {
            if(obj == null) return false;
            var tempobj = _dBContext.MauSacs.FirstOrDefault(c => c.Id == obj.Id);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<MauSac> GetAll()
        {
            return _dBContext.MauSacs.ToList();
        }

        public MauSac GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.MauSacs.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(MauSac obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.MauSacs.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma=obj.Ma;
            tempobj.Ten = obj.Ten;
            _dBContext.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
