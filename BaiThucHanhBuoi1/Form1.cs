using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhBuoi1
{
    public partial class v : Form
    {
        public v()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            var tenNhap=txtTen.Text;
            MessageBox.Show($"Chào bạn {tenNhap}, rất vui được gặp bạn");
        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            txtBanNhap.Text=txtTen.Text;
        }

     

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtBanNhap.Text = txtTen.Text;
        }
    }
}
