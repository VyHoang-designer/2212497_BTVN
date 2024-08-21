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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
           
        }

        private void rdXanh_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGIa.Text = "22000";
        }

        private void rdDo_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGIa.Text = "21000";
        }

        private void rdTrang_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGIa.Text = "20000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soTien=int.Parse(txtDonGIa.Text) * int.Parse(txtSoLuong.Text);
            label1.Text= soTien.ToString();
        }
    }
}
