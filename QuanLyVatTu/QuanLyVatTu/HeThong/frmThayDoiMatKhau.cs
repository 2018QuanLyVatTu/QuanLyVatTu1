using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatTu.HeThong
{
    public partial class frmThayDoiMatKhau : Form
    {
        public frmThayDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            this.txtMatKhauMoi.ResetText();
            this.txtMauKhauCu.ResetText();
            this.txtXacNhan.ResetText();
        }
    }
}
