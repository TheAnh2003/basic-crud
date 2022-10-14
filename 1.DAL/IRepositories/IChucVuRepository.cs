﻿using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
   public interface IChucVuRepository
    {
        bool Add(ChucVu obj);
        bool Update(ChucVu obj);
        bool Delete(ChucVu obj);
        ChucVu GetById(Guid id);//Phương thức tìm sản phẩm theo id
        List<ChucVu> GetAll();
    }
}
