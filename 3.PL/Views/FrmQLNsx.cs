using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace _3.PL.View
{
    public partial class FrmQLNsx : Form
    {
        IQLnsxService _iqLNsxService;
        private Guid _idWhenclick;
        public FrmQLNsx()
        {
            InitializeComponent();
            _iqLNsxService = new QLnsx();
            LoadData();
        }
        public void LoadData()
        {
            dgridNsx.ColumnCount = 3;
            dgridNsx.Columns[0].Name = "id";
            dgridNsx.Columns[1].Name = "Mã";
            dgridNsx.Columns[2].Name = "Tên";
            dgridNsx.Rows.Clear();
            foreach (var x in _iqLNsxService.GetAll())
            {
                dgridNsx.Rows.Add(x.Id, x.Ma, x.Ten);
            }
        }
        public Nsx GetDataFromGui()
        {
            return new Nsx() { Ten = txtTen.Text, Ma = txtMa.Text };
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iqLNsxService.Add(GetDataFromGui()));
            LoadData();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = GetDataFromGui();
            obj.Id = _idWhenclick;
            MessageBox.Show(_iqLNsxService.Update(obj));
            LoadData();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = GetDataFromGui();
            obj.Id = _idWhenclick;
            MessageBox.Show(_iqLNsxService.Delete(obj));
            LoadData();

        }

        private void dgridNsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _iqLNsxService.GetAll().Count || rowIndex == -1) return;
            _idWhenclick = Guid.Parse(dgridNsx.Rows[rowIndex].Cells[0].Value.ToString());
            var dong = _iqLNsxService.GetAll().FirstOrDefault(c => c.Id == _idWhenclick);
            txtMa.Text = dong.Ma;
            txtTen.Text = dong.Ten;

        }
    }
}
