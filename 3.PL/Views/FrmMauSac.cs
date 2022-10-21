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
using _1.DAL.DomainClass;

namespace _3.PresentationLayers
{
    public partial class FrmMauSac : Form
    {
        private IQlMauSacService iMauSacService;
        private Guid idClick;
        public FrmMauSac()
        {
            InitializeComponent();
            iMauSacService = new QlMauSacService();
            LoadData();
        }
        private void LoadData()
        {
            int stt = 1;
            dgrid_MauSac.ColumnCount = 4;
            dgrid_MauSac.Columns[0].Name = "STT";
            dgrid_MauSac.Columns[1].Name = "Id";
            dgrid_MauSac.Columns[2].Name = "Mã";
            dgrid_MauSac.Columns[3].Name = "Tên";
            dgrid_MauSac.Columns["Id"].Visible = false;
            dgrid_MauSac.Rows.Clear();
            foreach (var x in iMauSacService.GetAll())
            {
                dgrid_MauSac.Rows.Add(stt++, x.MauSac.Id, x.MauSac.Ma, x.MauSac.Ten);
            }
        }
        private MauSacView GetData()
        {
            return new MauSacView()
            {
                MauSac = new MauSac()
                {
                    Id = Guid.Empty,
                    Ma = tbx_Ma.Text,
                    Ten = tbx_Ten.Text
                }
            };
        }
        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iMauSacService.Add(GetData()));
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.MauSac.Id = idClick;
            MessageBox.Show(iMauSacService.Update(temp));
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.MauSac.Id = idClick;
            MessageBox.Show(iMauSacService.Delete(temp));
            LoadData();
        }

        private void dgrid_MauSac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            idClick = Guid.Parse(dgrid_MauSac.Rows[rowIndex].Cells[1].Value.ToString());
            var temp = iMauSacService.GetAll().FirstOrDefault(c => c.MauSac.Id == idClick);
            if (temp != null)
            {
                tbx_Ma.Text = temp.MauSac.Ma;
                tbx_Ten.Text = temp.MauSac.Ten;
            }
        }

        private void tbx_TimKiem_TextChanged(object sender, EventArgs e)
        {
            var temp = iMauSacService.GetAll().Where(c => c.MauSac.Ma.ToLower().StartsWith(tbx_TimKiem.Text.ToLower()));
            if (temp != null)
            {
                int stt = 1;
                dgrid_MauSac.ColumnCount = 4;
                dgrid_MauSac.Columns[0].Name = "STT";
                dgrid_MauSac.Columns[1].Name = "Id";
                dgrid_MauSac.Columns[2].Name = "Mã";
                dgrid_MauSac.Columns[3].Name = "Tên";
                dgrid_MauSac.Columns["Id"].Visible = false;
                dgrid_MauSac.Rows.Clear();
                foreach (var x in temp)
                {
                    dgrid_MauSac.Rows.Add(stt++, x.MauSac.Id, x.MauSac.Ma, x.MauSac.Ten);
                }
            }
            if(tbx_TimKiem.Text == null)
            { 
                    LoadData();
            }
        }
    }
}
