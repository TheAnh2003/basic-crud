﻿using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
   public interface IQLHoaDonService
    {
        string Add(ViewHoaDon obj);
        string Update(ViewHoaDon obj);
        string Delete(ViewHoaDon obj);
        List<ViewHoaDon> GetAll();
    }
}
