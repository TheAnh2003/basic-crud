﻿using _1.DAL.DomainClass;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLKhachHangService
    {
        string Add(KhachHangView obj);
        string Update(KhachHangView obj);
        string Delete(KhachHangView obj);
        List<KhachHangView> GetAll();
    }
}
