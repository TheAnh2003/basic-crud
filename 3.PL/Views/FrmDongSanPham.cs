using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;

namespace _3.PresentationLayers
{
    public partial class FrmDongSanPham : Form
    {
        private IQLDongSpService _iDongSpService;
        private Guid idClick;
        public FrmDongSanPham()
        {
            _iDongSpService = new QLDongSpService();
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_DongSp.ColumnCount = 4;
            dgrid_DongSp.Columns[0].Name = "Stt";
            dgrid_DongSp.Columns[1].Name = "Id";
            dgrid_DongSp.Columns[2].Name = "Mã";
            dgrid_DongSp.Columns[3].Name = "Tên";
            dgrid_DongSp.Rows.Clear();
            dgrid_DongSp.Columns["Id"].Visible = false;
            foreach (var x in _iDongSpService.GetAll())
            {
                dgrid_DongSp.Rows.Add(stt++, x.DongSp.Id, x.DongSp.Ma, x.DongSp.Ten);
            }

        }
        private DongSpView GetData()
        {
            return new DongSpView()
            {
                DongSp = new()
                {
                    Ma = tbx_Ma.Text,
                    Ten = tbx_Ten.Text,
                }
            };
        }
        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iDongSpService.Add(GetData()));
            LoadData();

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.DongSp.Id = idClick;
            MessageBox.Show(_iDongSpService.Update(temp));
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.DongSp.Id = idClick;
            MessageBox.Show(_iDongSpService.Delete(temp));
            LoadData();
        }

        private void tbx_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if(tbx_TimKiem.Text == null)
            {
                GetData();
            }
            var temp = _iDongSpService.GetAll().Where(c => c.DongSp.Ma.ToLower() == tbx_TimKiem.Text.ToLower());
            if(temp == null)
            {
                dgrid_DongSp.ColumnCount = 4;
                dgrid_DongSp.Columns[0].Name = "Stt";
                dgrid_DongSp.Columns[1].Name = "Id";
                dgrid_DongSp.Columns[2].Name = "Mã";
                dgrid_DongSp.Columns[3].Name = "Tên";
                dgrid_DongSp.Rows.Clear();
                dgrid_DongSp.Columns["Id"].Visible = false;
            }
            else
            {
                int stt = 1;
                dgrid_DongSp.ColumnCount = 4;
                dgrid_DongSp.Columns[0].Name = "Stt";
                dgrid_DongSp.Columns[1].Name = "Id";
                dgrid_DongSp.Columns[2].Name = "Mã";
                dgrid_DongSp.Columns[3].Name = "Tên";
                dgrid_DongSp.Rows.Clear();
                dgrid_DongSp.Columns["Id"].Visible = false;
                foreach (var x in temp)
                {
                    dgrid_DongSp.Rows.Add(stt++, x.DongSp.Id, x.DongSp.Ma, x.DongSp.Ten);
                }
            }
        }

        private void dgrid_DongSp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            idClick = Guid.Parse(dgrid_DongSp.Rows[rowIndex].Cells[1].Value.ToString());
            var dongSp = _iDongSpService.GetAll().FirstOrDefault(c => c.DongSp.Id == idClick);
            tbx_Ma.Text = dongSp.DongSp.Ma;
            tbx_Ten.Text = dongSp.DongSp.Ten;
        }
    }
}
