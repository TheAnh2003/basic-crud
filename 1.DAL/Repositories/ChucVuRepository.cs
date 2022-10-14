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
    public class ChucVuRepository : IChucVuRepository
    {
        FpolyDBContext _dBContext;
        public ChucVuRepository()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(ChucVu obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dBContext.ChucVus.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.ChucVus.FirstOrDefault(c => c.Id == obj.Id);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _dBContext.ChucVus.ToList();
        }

        public ChucVu GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.ChucVus.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(ChucVu obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.MauSacs.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            _dBContext.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
