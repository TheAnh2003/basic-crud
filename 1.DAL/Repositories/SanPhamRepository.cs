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

        }

        public bool Add(SanPham obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(SanPham obj)
        {
            throw new NotImplementedException();
        }

        public List<SanPham> GetAll()
        {
            throw new NotImplementedException();
        }

        public SanPham GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(SanPham obj)
        {
            throw new NotImplementedException();
        }
    }
}
