using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLSanPhamService : IQLSanPhamService
    {
        private IChiTietSPRepository _iChiTietSPRepository;
        private INsxRepository _iNsxRepo;
        private ISanPhamRepository _iSpRepo;
        private IMauSacRepository _iMauSacRepo;
        private IDongSPRepository _iDongSPRepo;

        public QLSanPhamService()
        {
            _iChiTietSPRepository = new ChiTietSPRepository();
            _iNsxRepo = new NsxRepository();
            _iMauSacRepo = new MauSacRepository();
            _iSpRepo = new SanPhamRepository();
            _iDongSPRepo = new DongSPRepository();
        }
        public string Add(ViewSP obj)
        {
            if (obj == null) return "Thêm thất bại";
            var ctsp = obj.ChiTietSp;
            if (_iChiTietSPRepository.Add(ctsp))
            return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(ViewSP obj)
        {
            if (obj == null) return "Xóa thất bại";
            var ctsp = obj.ChiTietSp;
            if (_iChiTietSPRepository.Delete(ctsp))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<ViewSP> GetAll()
        {
            List<ViewSP> lstPhamViews = new List<ViewSP>();
            //Viết 1 câu linq để gán giá trị cho từng prop của spView
             lstPhamViews = 
                (from a in _iChiTietSPRepository.GetAll()
                 join b in _iMauSacRepo.GetAll() on a.IdMauSac equals b.Id
                 join c in _iNsxRepo.GetAll() on a.IdNsx equals c.Id
                 join d in _iSpRepo.GetAll() on a.IdSp equals d.Id
                 join e in _iDongSPRepo.GetAll() on a.IdDongSp equals e.Id
                 select new ViewSP()
                 {
                     ChiTietSp = a,
                     MauSac = b,
                     SanPham = d,
                     Nsx = c,
                     DongSp = e
                 }).ToList();
            return lstPhamViews;
        }

        public string Update(ViewSP obj)
        {
            if (obj == null) return "Sửa thất bại";
            var ctsp = obj.ChiTietSp;
            if (_iChiTietSPRepository.Update(ctsp))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
