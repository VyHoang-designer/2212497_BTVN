using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class frmBai3 : Form
    {
        List<string> mang=new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnThemTU_Click(object sender, EventArgs e)
        {
            string nhap = txtTu.Text;
            string nghia=txtTV.Text;
            listBox1.Items.Add(nhap);

            mang.Add(nghia);
            //sau khi thêm con trỏ quay lại ô nhập
            txtTu.Focus();
            txtTu.Text = "";
            txtTV.Text = "";
            listBox1.SelectedIndex=listBox1.Items.Count-1;  //chọn phần tử cuối cùng vừa thêm
            txtNghia.Text = nghia;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNghia.Text = mang[listBox1.SelectedIndex];
        }

        private void txtNghia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
