using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chọn giới tính Nam", "Thông báo");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chọn giới tính Nam", "Thông báo");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (rdDo.Checked)
            {
                panel1.BackColor = Color.Red;
            }
            else
            {
                panel1.BackColor = Color.Green;
            }
        }
    }
}
