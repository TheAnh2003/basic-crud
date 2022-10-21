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
    public partial class FrmSanPham : Form
    {
        private IQLSanPhamService iSanPhamService;
        private Guid idClick;
        public FrmSanPham()
        {
            InitializeComponent();
            iSanPhamService = new QlSanPhamService();
            LoadData();
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_SanPham.ColumnCount = 4;
            dgrid_SanPham.Columns[0].Name = "STT";
            dgrid_SanPham.Columns[1].Name = "Id";
            dgrid_SanPham.Columns[2].Name = "Mã";
            dgrid_SanPham.Columns[3].Name = "Tên";
            dgrid_SanPham.Rows.Clear();
            dgrid_SanPham.Columns["Id"].Visible = false;
            foreach (var x in iSanPhamService.GetAll())
            {
                dgrid_SanPham.Rows.Add(stt++, x.SanPham.Id, x.SanPham.Ma, x.SanPham.Ten);
            }

        }
        private SanPhamView GetData()
        {
            SanPhamView spv = new SanPhamView();
            spv.SanPham = new SanPham()
            {
                Id = Guid.Empty,
                Ma = tbx_Ma.Text,
                Ten = tbx_Ten.Text
            };
            return spv;
        }
        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iSanPhamService.Add(GetData()));
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.SanPham.Id = idClick;
            MessageBox.Show(iSanPhamService.Update(temp));
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.SanPham.Id = idClick;
            MessageBox.Show(iSanPhamService.Delete(temp));
            LoadData();
        }

        private void dgrid_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            idClick = Guid.Parse(dgrid_SanPham.Rows[rowIndex].Cells[1].Value.ToString());
            if (idClick == Guid.Empty) return;
            var temp = iSanPhamService.GetAll().FirstOrDefault(c => c.SanPham.Id == idClick);
            if (temp != null)
            {
                tbx_Ma.Text = temp.SanPham.Ma;
                tbx_Ten.Text = temp.SanPham.Ten;
            }
        }

        private void tbx_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if(tbx_TimKiem.Text == null)
            {
                LoadData();
            }
            var temp = iSanPhamService.GetAll().Where(c => c.SanPham.Ma.ToLower() == tbx_TimKiem.Text.ToLower());
            if(temp == null)
            {
                int stt = 1;
                dgrid_SanPham.ColumnCount = 4;
                dgrid_SanPham.Columns[0].Name = "STT";
                dgrid_SanPham.Columns[1].Name = "Id";
                dgrid_SanPham.Columns[2].Name = "Mã";
                dgrid_SanPham.Columns[3].Name = "Tên";
                dgrid_SanPham.Rows.Clear();
                dgrid_SanPham.Columns["Id"].Visible = false;
            }
            else
            {
                int stt = 1;
                dgrid_SanPham.ColumnCount = 4;
                dgrid_SanPham.Columns[0].Name = "STT";
                dgrid_SanPham.Columns[1].Name = "Id";
                dgrid_SanPham.Columns[2].Name = "Mã";
                dgrid_SanPham.Columns[3].Name = "Tên";
                dgrid_SanPham.Rows.Clear();
                dgrid_SanPham.Columns["Id"].Visible = false;
                foreach (var x in temp)
                {
                    dgrid_SanPham.Rows.Add(stt++, x.SanPham.Id, x.SanPham.Ma, x.SanPham.Ten);
                }
            }
        }
    }
}
