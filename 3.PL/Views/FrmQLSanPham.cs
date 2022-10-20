using _1.DAL.DomainClass;
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
    public partial class FrmQLSanPham : Form
    {
        IQLSanPhamService _qLSanPhamService;
        private Guid _idWhenclick;
        public FrmQLSanPham()
        {
            InitializeComponent();
            _qLSanPhamService = new QlSanPhamService() ;
            LoadData();
        }
        public void LoadData()
        {
            dgridSanPham.ColumnCount = 3;
            dgridSanPham.Columns[0].Name = "id";
            dgridSanPham.Columns[1].Name = "Mã";
            dgridSanPham.Columns[2].Name = "Tên";
            dgridSanPham.Rows.Clear();
            foreach (var x in _qLSanPhamService.GetAll())
            {
                dgridSanPham.Rows.Add(x.Id, x.Ma, x.Ten);
            }
        }
        public SanPham GetDataFromGui()
        {
            return new SanPham() { Ten = txtTen.Text, Ma = txtMa.Text };
        }

        private void dgridSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _qLSanPhamService.GetAll().Count || rowIndex == -1) return;
            _idWhenclick = Guid.Parse(dgridSanPham.Rows[rowIndex].Cells[0].Value.ToString());
            var mau = _qLSanPhamService.GetAll().FirstOrDefault(c => c.Id == _idWhenclick);
            txtMa.Text = mau.Ma;
            txtTen.Text = mau.Ten;

        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_qLSanPhamService.Add(GetDataFromGui()));
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = GetDataFromGui();
            obj.Id = _idWhenclick;
            MessageBox.Show(_qLSanPhamService.Update(obj));
            LoadData();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = GetDataFromGui();
            obj.Id = _idWhenclick;
            MessageBox.Show(_qLSanPhamService.Delete(obj));
            LoadData();

        }

    }
}
