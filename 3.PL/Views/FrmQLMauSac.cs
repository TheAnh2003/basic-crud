using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.View
{
    public partial class FrmQLMauSac : Form
    {
        IQlMauSacService _qLMauSacservice;
        private Guid _idWhenclick;
        public FrmQLMauSac()
        {
            InitializeComponent();
            _qLMauSacservice = new QlMauSacService();
            LoadData();
        }
        public void LoadData()
        {
            dgridMauSac.ColumnCount = 3;
            dgridMauSac.Columns[0].Name = "id";
            dgridMauSac.Columns[1].Name = "Mã";
            dgridMauSac.Columns[2].Name = "Tên";
            dgridMauSac.Rows.Clear();
            foreach (var x in _qLMauSacservice.GetAll())
            {
                dgridMauSac.Rows.Add(x.Id,x.Ma, x.Ten);
            }
        }
        public MauSac GetDataFromGui()
        {
            return new MauSac() { Ten = txtTen.Text, Ma = txtMa.Text };
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_qLMauSacservice.Add(GetDataFromGui()));
            LoadData();
        }

        private void dgridMauSac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _qLMauSacservice.GetAll().Count || rowIndex==-1) return;
            _idWhenclick = Guid.Parse( dgridMauSac.Rows[rowIndex].Cells[0].Value.ToString());
            var mau = _qLMauSacservice.GetAll().FirstOrDefault(c => c.Id == _idWhenclick);
            txtMa.Text = mau.Ma;
            txtTen.Text = mau.Ten;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj=GetDataFromGui();
            obj.Id = _idWhenclick;
            MessageBox.Show(_qLMauSacservice.Delete(obj));
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = GetDataFromGui();
            obj.Id = _idWhenclick;
            MessageBox.Show(_qLMauSacservice.Update(obj));
            LoadData();
        }
    }
}
