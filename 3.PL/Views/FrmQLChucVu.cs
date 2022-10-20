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
    public partial class FrmQLChucVu : Form
    {
        IQLChucVuService _qLChucVuService;
        private Guid _idWhenclick;
        public FrmQLChucVu()
        {
            InitializeComponent();
            _qLChucVuService = new QLChucVuService();
            LoadData();
        }
        public void LoadData()
        {
            dgridChucVu.ColumnCount = 3;
            dgridChucVu.Columns[0].Name = "id";
            dgridChucVu.Columns[1].Name = "Mã";
            dgridChucVu.Columns[2].Name = "Tên";
            dgridChucVu.Rows.Clear();
            foreach (var x in _qLChucVuService.GetAll())
            {
                dgridChucVu.Rows.Add(x.Id, x.Ma, x.Ten);
            }
        }
        public ChucVu GetDataFromGui()
        {
            return new ChucVu() { Ten = txtTen.Text, Ma = txtMa.Text };
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_qLChucVuService.Add(GetDataFromGui()));
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = GetDataFromGui();
            obj.Id = _idWhenclick;
            MessageBox.Show(_qLChucVuService.Update(obj));
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = GetDataFromGui();
            obj.Id = _idWhenclick;
            MessageBox.Show(_qLChucVuService.Delete(obj));
            LoadData();
        }

        private void dgridChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _qLChucVuService.GetAll().Count || rowIndex == -1) return;
            _idWhenclick = Guid.Parse(dgridChucVu.Rows[rowIndex].Cells[0].Value.ToString());
            var dong = _qLChucVuService.GetAll().FirstOrDefault(c => c.Id == _idWhenclick);
            txtMa.Text = dong.Ma;
            txtTen.Text = dong.Ten;

        }
    }
}
