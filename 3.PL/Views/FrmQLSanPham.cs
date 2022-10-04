using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.Services;

namespace _3.PL.Views
{
    public partial class FrmQLSanPham : Form
    {
        private IQLSanPhamService iQLSanPhamService;
        public FrmQLSanPham()
        {
            InitializeComponent();
            iQLSanPhamService = new QLSanPhamService();
        }
    }
}
