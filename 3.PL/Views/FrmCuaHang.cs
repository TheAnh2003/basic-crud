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
    public partial class FrmCuaHang : Form
    {
        private IQLCuaHangService iCuaHangService;
        private Guid idClick;
        public FrmCuaHang()
        {
            InitializeComponent();
            iCuaHangService = new QLCuaHangService();
            LoadData();
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_CuaHang.ColumnCount = 7;
            dgrid_CuaHang.Columns[0].Name = "STT";
            dgrid_CuaHang.Columns[1].Name = "Id";
            dgrid_CuaHang.Columns[2].Name = "Mã";
            dgrid_CuaHang.Columns[3].Name = "Tên";
            dgrid_CuaHang.Columns[4].Name = "Địa chỉ";
            dgrid_CuaHang.Columns[5].Name = "Thành phố";
            dgrid_CuaHang.Columns[6].Name = "Quốc gia";
            dgrid_CuaHang.Columns[1].Visible = false;
            dgrid_CuaHang.Rows.Clear();
            
            foreach (var x in iCuaHangService.GetAll())
            {
                dgrid_CuaHang.Rows.Add(stt++, x.CuaHang.Id, x.CuaHang.Ma, x.CuaHang.Ten, x.CuaHang.DiaChi, x.CuaHang.ThanhPho, x.CuaHang.QuocGia);
            }
        }
        private CuaHangView GetData()
        {
            return new CuaHangView()
            {
                CuaHang = new CuaHang()
                {
                    Id = Guid.Empty,
                    Ma = tbx_Ma.Text,
                    Ten = tbx_Ten.Text,
                    DiaChi = tbx_DiaChi.Text,
                    ThanhPho = tbx_ThanhPho.Text,
                    QuocGia = tbx_QuocGia.Text,
                }
            };
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iCuaHangService.Add(GetData()));
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.CuaHang.Id = idClick;
            MessageBox.Show(iCuaHangService.Update(temp));
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.CuaHang.Id = idClick;
            MessageBox.Show(iCuaHangService.Delete(temp));
            LoadData();
        }

        private void tbx_TimKiem_TextChanged(object sender, EventArgs e)
        {
            var temp = iCuaHangService.GetAll().Where(c => c.CuaHang.Ma.ToLower().Contains(tbx_TimKiem.Text.ToLower()));
            if(tbx_TimKiem.Text == null)
            {
                LoadData();
            }
            else
            {
                int stt = 1;
                dgrid_CuaHang.ColumnCount = 7;
                dgrid_CuaHang.Columns[0].Name = "STT";
                dgrid_CuaHang.Columns[1].Name = "Id";
                dgrid_CuaHang.Columns[2].Name = "Mã";
                dgrid_CuaHang.Columns[3].Name = "Tên";
                dgrid_CuaHang.Columns[4].Name = "Địa chỉ";
                dgrid_CuaHang.Columns[5].Name = "Thành phố";
                dgrid_CuaHang.Columns[6].Name = "Quốc gia";
                dgrid_CuaHang.Rows.Clear();
                dgrid_CuaHang.Columns["Id"].Visible = false;
                foreach (var x in temp)
                {
                    dgrid_CuaHang.Rows.Add(stt++, x.CuaHang.Id, x.CuaHang.Ma, x.CuaHang.Ten, x.CuaHang.DiaChi, x.CuaHang.ThanhPho, x.CuaHang.QuocGia);
                }
            }
        }

        private void dgrid_CuaHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndext = e.RowIndex;
            idClick = Guid.Parse(dgrid_CuaHang.Rows[rowIndext].Cells[1].Value.ToString());
            var temp = iCuaHangService.GetAll().FirstOrDefault(c => c.CuaHang.Id == idClick);
            tbx_Ma.Text = temp.CuaHang.Ma;
            tbx_Ten.Text = temp.CuaHang.Ten;
            tbx_DiaChi.Text = temp.CuaHang.DiaChi;
            tbx_ThanhPho.Text = temp.CuaHang.ThanhPho;
            tbx_QuocGia.Text = temp.CuaHang.QuocGia;
        }
    }
}
