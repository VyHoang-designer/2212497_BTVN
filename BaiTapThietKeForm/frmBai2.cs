﻿using System;
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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            var chon=listBox1.SelectedItem;
            listBox2.Items.Add(chon);

        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            var chon = listBox2.SelectedItem;
            listBox2.Items.Remove(chon);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soTien = 0;
            foreach(var item in listBox2.Items)
            {
                switch (item)
                {
                    case "Chuột":
                        soTien+= 100000 ;
                        break;
                    case "Bàn phím":
                        soTien += 150000;
                        break;
                    case "Máy in":
                        soTien += 2000000;
                        break;
                    case "USB Kingmax":
                        soTien += 200000;
                        break;
                }
            }
            label2.Text = soTien.ToString()+" Đồng";
        }
    }
}
