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
    public partial class FrmNsx : Form
    {
        private IQLnsxService _iNsxService;
        private Guid idClick;
        public FrmNsx()
        {
            InitializeComponent();
            _iNsxService = new QLnsx();
            LoadData();
            
        }
        private NsxView GetData()
        {
            NsxView nsxView = new NsxView();

            return new NsxView()
            {
                Nsx = new Nsx()
                {
                    Id = Guid.Empty,
                    Ma = tbx_Ma.Text,
                    Ten = tbx_Ten.Text
                }
            };
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_Nsx.ColumnCount = 4;
            dgrid_Nsx.Columns[0].Name = "STT";
            dgrid_Nsx.Columns[1].Name = "Id";
            dgrid_Nsx.Columns[2].Name = "Mã";
            dgrid_Nsx.Columns[3].Name = "Tên";
            dgrid_Nsx.Rows.Clear();
            dgrid_Nsx.Columns["Id"].Visible = false;
            foreach (var x in _iNsxService.GetAll())
            {
                dgrid_Nsx.Rows.Add(stt++,x.Nsx.Id, x.Nsx.Ma, x.Nsx.Ten);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iNsxService.Add(GetData()));
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Nsx.Id = idClick;
            MessageBox.Show(_iNsxService.Update(temp));
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Nsx.Id = idClick;
            MessageBox.Show(_iNsxService.Delete(temp));
            LoadData();
        }

        private void dgrid_Nsx_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _iNsxService.GetAll().Count) return;
            idClick = Guid.Parse(dgrid_Nsx.Rows[rowIndex].Cells[1].Value.ToString());
            var nSxV = _iNsxService.GetAll().FirstOrDefault(c=>c.Nsx.Id == idClick);
            tbx_Ma.Text = nSxV.Nsx.Ma;
            tbx_Ten.Text = nSxV.Nsx.Ten;
        }

        private void tbx_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (tbx_TimKiem.Text == null)
            {
                LoadData();
            }
            var _lstNsx = _iNsxService.GetAll().FirstOrDefault(c => c.Nsx.Ma == tbx_TimKiem.Text);
            if (_lstNsx == null)
            {
                dgrid_Nsx.ColumnCount = 4;
                dgrid_Nsx.Columns[0].Name = "STT";
                dgrid_Nsx.Columns[1].Name = "Id";
                dgrid_Nsx.Columns[2].Name = "Mã";
                dgrid_Nsx.Columns[3].Name = "Tên";
                dgrid_Nsx.Rows.Clear();
                dgrid_Nsx.Columns["Id"].Visible = false;
            }
            else
            {
                int stt = 1;
                dgrid_Nsx.ColumnCount = 4;
                dgrid_Nsx.Columns[0].Name = "STT";
                dgrid_Nsx.Columns[1].Name = "Id";
                dgrid_Nsx.Columns[2].Name = "Mã";
                dgrid_Nsx.Columns[3].Name = "Tên";
                dgrid_Nsx.Rows.Clear();
                dgrid_Nsx.Columns["Id"].Visible = false;
                foreach (var x in _iNsxService.GetById(_lstNsx.Nsx.Id))
                {
                    dgrid_Nsx.Rows.Add(stt++, x.Nsx.Id, x.Nsx.Ma, x.Nsx.Ten);
                }
            };
        }
    }
}
