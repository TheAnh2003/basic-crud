
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
    public partial class FrmQLCuaHang : Form
    { 
        IQLCuaHangService _qLCuaHangService;
        private Guid _idWhenclick;
        public FrmQLCuaHang()
        {
            InitializeComponent();
            _qLCuaHangService = new QLCuaHangService();
            LoadData();
        }
        public void LoadData()
        {
            dgridCuaHang.ColumnCount = 6;
            dgridCuaHang.Columns[0].Name = "id";
            dgridCuaHang.Columns[1].Name = "Mã";
            dgridCuaHang.Columns[2].Name = "Tên";
            dgridCuaHang.Columns[3].Name = "Địa chỉ";
            dgridCuaHang.Columns[4].Name = "Thành Phố";
            dgridCuaHang.Columns[5].Name = "Quốc gia";
            dgridCuaHang.Rows.Clear();
            foreach (var x in _qLCuaHangService.GetAll())
            {
                dgridCuaHang.Rows.Add(x.Id, x.Ma, x.DiaChi, x.ThanhPho, x.QuocGia);
            }
        }
        public CuaHang GetDataFromGui()
        {
            return new CuaHang() { Ten = txtTen.Text, Ma = txtMa.Text, DiaChi = txtDiaChi.Text, ThanhPho = txtThanhPho.Text, QuocGia = txtQuocGia.Text };
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_qLCuaHangService.Add(GetDataFromGui()));
            LoadData();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = GetDataFromGui();
            obj.Id = _idWhenclick;
            MessageBox.Show(_qLCuaHangService.Update(obj));
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var obj = GetDataFromGui();
            obj.Id = _idWhenclick;
            MessageBox.Show(_qLCuaHangService.Delete(obj));
            LoadData();

        }

        private void dgridCuaHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _qLCuaHangService.GetAll().Count || rowIndex == -1) return;
            _idWhenclick = Guid.Parse(dgridCuaHang.Rows[rowIndex].Cells[0].Value.ToString());
            var cuahang = _qLCuaHangService.GetAll().FirstOrDefault(c => c.Id == _idWhenclick);
            txtMa.Text = cuahang.Ma;
            txtTen.Text = cuahang.Ten;
            txtDiaChi.Text = cuahang.DiaChi;
            txtQuocGia.Text = cuahang.QuocGia;
            txtThanhPho.Text = cuahang.ThanhPho;
        }

    }
}
