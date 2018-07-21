using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatTu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.MdiParent = this;
            frmDangNhap.Show();
            //test
            //rtyrt
            //test lần thứ 9999999999999999
            //test tiếp
        }
    }
}
