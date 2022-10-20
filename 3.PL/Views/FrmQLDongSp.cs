using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.Services;
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
    public partial class FrmQLDongSp : Form
    {
        IQLDongSpService _qlDongSpService;
        private Guid _idWhenclick;
        public FrmQLDongSp()
        {
            InitializeComponent();
            _qlDongSpService = new QLDongSpService();
            LoadData();
        }
        public void LoadData()
        {
            dgridDongSp.ColumnCount = 3;
            dgridDongSp.Columns[0].Name = "id";
            dgridDongSp.Columns[1].Name = "Mã";
            dgridDongSp.Columns[2].Name = "Tên";
            dgridDongSp.Rows.Clear();
            foreach (var x in _qlDongSpService.GetAll())
            {
                dgridDongSp.Rows.Add(x.Id, x.Ma, x.Ten);
            }
        }
        public DongSp GetDataFromGui()
        {
            return new DongSp() { Ten = txtTen.Text, Ma = txtMa.Text };
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_qlDongSpService.Add(GetDataFromGui()));
            LoadData();
        }

        private void dgridDongSp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _qlDongSpService.GetAll().Count || rowIndex == -1) return;
            _idWhenclick = Guid.Parse(dgridDongSp.Rows[rowIndex].Cells[0].Value.ToString());
            var dong = _qlDongSpService.GetAll().FirstOrDefault(c => c.Id == _idWhenclick);
            txtMa.Text = dong.Ma;
            txtTen.Text = dong.Ten;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = GetDataFromGui();
            obj.Id = _idWhenclick;
            MessageBox.Show(_qlDongSpService.Delete(obj));
            LoadData();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = GetDataFromGui();
            obj.Id = _idWhenclick;
            MessageBox.Show(_qlDongSpService.Update(obj));
            LoadData();

        }
    }
}

