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
    public partial class FrmChucVu : Form
    {
        private IQLChucVuService iChucVuService;
        private Guid idClick;
        public FrmChucVu()
        {
            InitializeComponent();
            iChucVuService = new QLChucVuService();
            LoadData();
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_ChucVu.ColumnCount = 4;
            dgrid_ChucVu.Columns[0].Name = "STT";
            dgrid_ChucVu.Columns[1].Name = "Id";
            dgrid_ChucVu.Columns[2].Name = "Mã";
            dgrid_ChucVu.Columns[3].Name = "Tên";
            dgrid_ChucVu.Rows.Clear();
            dgrid_ChucVu.Columns["Id"].Visible = false;
            foreach (var x in iChucVuService.GetAll())
            {
                dgrid_ChucVu.Rows.Add(stt++, x.ChucVu.Id, x.ChucVu.Ma, x.ChucVu.Ten);
            }

        }
        private ChucVuView GetData()
        {
            return new ChucVuView()
            {
                ChucVu = new ChucVu()
                {
                    Id = Guid.Empty,
                    Ma = tbx_Ma.Text,
                    Ten = tbx_Ten.Text
                }
            };
        }
        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iChucVuService.Add(GetData()));
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.ChucVu.Id = idClick;
            MessageBox.Show(iChucVuService.Update(temp));
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.ChucVu.Id = idClick;
            MessageBox.Show(iChucVuService.Delete(temp));
            LoadData();
        }

        private void dgrid_ChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == iChucVuService.GetAll().Count) return;
            idClick = Guid.Parse(dgrid_ChucVu.Rows[rowIndex].Cells[1].Value.ToString());
            var nSxV = iChucVuService.GetAll().FirstOrDefault(c => c.ChucVu.Id == idClick);
            tbx_Ma.Text = nSxV.ChucVu.Ma;
            tbx_Ten.Text = nSxV.ChucVu.Ten;
        }

        private void tbx_TimKiem_TextChanged(object sender, EventArgs e)
        {
            var temp = iChucVuService.GetAll().Where(c => c.ChucVu.Ma.ToLower().Contains(tbx_TimKiem.Text.ToLower()));
            if(tbx_TimKiem.Text == null)
            {
                GetData();
            }
            else
            {
                int stt = 1;
                dgrid_ChucVu.ColumnCount = 4;
                dgrid_ChucVu.Columns[0].Name = "STT";
                dgrid_ChucVu.Columns[1].Name = "Id";
                dgrid_ChucVu.Columns[2].Name = "Mã";
                dgrid_ChucVu.Columns[3].Name = "Tên";
                dgrid_ChucVu.Rows.Clear();
                dgrid_ChucVu.Columns["Id"].Visible = false;
                foreach (var x in temp)
                {
                    dgrid_ChucVu.Rows.Add(stt++, x.ChucVu.Id, x.ChucVu.Ma, x.ChucVu.Ten);
                }
            }
        }
    }
}
