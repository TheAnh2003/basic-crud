using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;

namespace _3.PresentationLayers
{
    public partial class FrmKhachHang : Form
    {
        private IQLKhachHangService iKhachHangService;
        private Guid idClick;
        public FrmKhachHang()
        {
            InitializeComponent();
            iKhachHangService = new QLKhachHangService();
            LoadData();
        }
        private KhachHangView GetData()
        {
            return new KhachHangView()
            {
                KhachHang = new KhachHang()
                {
                    Id = Guid.Empty,
                    Ma = tbx_Ma.Text,
                    Ten = tbx_Ten.Text,
                    TenDem = tbx_TenDem.Text,
                    Ho = tbx_Ho.Text,
                    NgaySinh = dtp_NgaySinh.Value,
                    Sdt = tbx_SDT.Text,
                    DiaChi = tbx_DiaChi.Text,
                    ThanhPho = tbx_ThanhPho.Text,
                    QuocGia = tbx_QuocGia.Text,
                    MatKhau = tbx_MatKhau.Text
                }
            };
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_KhachHang.ColumnCount = 12;
            dgrid_KhachHang.Columns[0].Name = "STT";
            dgrid_KhachHang.Columns[1].Name = "Id";
            dgrid_KhachHang.Columns[2].Name = "Mã";
            dgrid_KhachHang.Columns[3].Name = "Tên";
            dgrid_KhachHang.Columns[4].Name = "Tên Đệm";
            dgrid_KhachHang.Columns[5].Name = "Họ";
            dgrid_KhachHang.Columns[6].Name = "Ngày Sinh";
            dgrid_KhachHang.Columns[7].Name = "SDT";
            dgrid_KhachHang.Columns[8].Name = "Dịa chỉ";
            dgrid_KhachHang.Columns[9].Name = "Thành Phố";
            dgrid_KhachHang.Columns[10].Name = "Quốc gia";
            dgrid_KhachHang.Columns[11].Name = "Mật Khẩu";
            dgrid_KhachHang.Rows.Clear();
            dgrid_KhachHang.Columns["Id"].Visible = false;
            foreach (var x  in iKhachHangService.GetAll())
            {
                dgrid_KhachHang.Rows.Add(stt++, x.KhachHang.Id, x.KhachHang.Ma, x.KhachHang.Ten, x.KhachHang.TenDem, x.KhachHang.Ho, x.KhachHang.NgaySinh, x.KhachHang.Sdt, x.KhachHang.DiaChi, x.KhachHang.ThanhPho, x.KhachHang.QuocGia, x.KhachHang.MatKhau);
            }
        }
        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iKhachHangService.Add(GetData()));
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.KhachHang.Id = idClick;
            MessageBox.Show(iKhachHangService.Update(temp));
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.KhachHang.Id = idClick;
            MessageBox.Show(iKhachHangService.Delete(temp));
            LoadData();
        }

        private void tbx_TimKiem_TextChanged(object sender, EventArgs e)
        {
            var temp = iKhachHangService.GetAll().Where(c => c.KhachHang.Ma.ToLower().Contains(tbx_Ma.Text.ToLower()));
            if(temp.Count() == 0)
            {
                GetData();
            }
            else
            {
                int stt = 1;
                dgrid_KhachHang.ColumnCount = 12;
                dgrid_KhachHang.Columns[0].Name = "STT";
                dgrid_KhachHang.Columns[1].Name = "Id";
                dgrid_KhachHang.Columns[2].Name = "Mã";
                dgrid_KhachHang.Columns[3].Name = "Tên";
                dgrid_KhachHang.Columns[4].Name = "Tên Đệm";
                dgrid_KhachHang.Columns[5].Name = "Họ";
                dgrid_KhachHang.Columns[6].Name = "Ngày Sinh";
                dgrid_KhachHang.Columns[7].Name = "SDT";
                dgrid_KhachHang.Columns[8].Name = "Dịa chỉ";
                dgrid_KhachHang.Columns[9].Name = "Thành Phố";
                dgrid_KhachHang.Columns[10].Name = "Quốc gia";
                dgrid_KhachHang.Columns[11].Name = "Mật Khẩu";
                dgrid_KhachHang.Rows.Clear();
                dgrid_KhachHang.Columns["Id"].Visible = false;
                foreach (var x in temp)
                {
                    dgrid_KhachHang.Rows.Add(stt++, x.KhachHang.Id, x.KhachHang.Ma, x.KhachHang.Ten, x.KhachHang.TenDem, x.KhachHang.Ho, x.KhachHang.NgaySinh, x.KhachHang.Sdt, x.KhachHang.DiaChi, x.KhachHang.ThanhPho, x.KhachHang.QuocGia, x.KhachHang.MatKhau);
                }
            }
        }

        private void dgrid_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            idClick = Guid.Parse(dgrid_KhachHang.Rows[rowIndex].Cells[1].Value.ToString());
            var temp = iKhachHangService.GetAll().FirstOrDefault(c => c.KhachHang.Id == idClick);
            tbx_Ma.Text = temp.KhachHang.Ma;
            tbx_Ten.Text = temp.KhachHang.Ten;
            tbx_TenDem.Text = temp.KhachHang.TenDem;
            tbx_Ho.Text = temp.KhachHang.Ho;
            dtp_NgaySinh.Value = temp.KhachHang.NgaySinh.Value;
            tbx_SDT.Text = temp.KhachHang.Sdt;
            tbx_DiaChi.Text = temp.KhachHang.DiaChi;
            tbx_ThanhPho.Text = temp.KhachHang.ThanhPho;
            tbx_QuocGia.Text = temp.KhachHang.QuocGia;
            tbx_MatKhau.Text = temp.KhachHang.MatKhau;
        }
    }
}
