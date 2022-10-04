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

        public QLSanPhamService()
        {
            _iChiTietSPRepository = new ChiTietSPRepository();
            _iNsxRepo = new NsxRepository();
            _iMauSacRepo = new MauSacRepository();
            _iSpRepo = new SanPhamRepository();
        }
        public string Add(SanPhamView obj)
        {
            if (obj == null) return "Thêm thất bại";
            var ctsp = obj.ChiTietSp;
            if (_iChiTietSPRepository.Add(ctsp))
            return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(SanPhamView obj)
        {
            if (obj == null) return "Xóa thất bại";
            var ctsp = obj.ChiTietSp;
            if (_iChiTietSPRepository.Delete(ctsp))
                return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<SanPhamView> GetAll()
        {
            List<SanPhamView> lstPhamViews = new List<SanPhamView>();
            //Viết 1 câu linq để gán giá trị cho từng prop của spView
             
            return lstPhamViews;
        }

        public string Update(SanPhamView obj)
        {
            if (obj == null) return "Sửa thất bại";
            var ctsp = obj.ChiTietSp;
            if (_iChiTietSPRepository.Update(ctsp))
                return "Sửa thành công";
            return "Thêm thất bại";
        }
    }
}
