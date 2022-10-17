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
    public class KhachHangRepository : IKhachHangRepository
    {
        FpolyDBContext _dBContext;
        public KhachHangRepository()
        {
            _dBContext = new FpolyDBContext();
        }
        public bool Add(KhachHang obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dBContext.KhachHangs.Add(obj);
            _dBContext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
            _dBContext.Remove(tempobj);
            _dBContext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return _dBContext.KhachHangs.ToList();
        }

        public KhachHang GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dBContext.KhachHangs.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dBContext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma=obj.Ma;
            tempobj.Ho = obj.Ho;
            tempobj.TenDem = obj.TenDem;
            tempobj.Ten = obj.Ten;
            tempobj.NgaySinh = obj.NgaySinh;
            tempobj.Sdt=obj.Sdt;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.ThanhPho=obj.ThanhPho;
            tempobj.QuocGia = obj.QuocGia;
            tempobj.MatKhau = obj.MatKhau;
            _dBContext.Update(tempobj);
            _dBContext.SaveChanges();
            return true;
        }
    }
}
