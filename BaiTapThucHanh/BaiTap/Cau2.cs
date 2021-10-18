using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class Cau2 : Form
    {
        public Cau2()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            int soN = Convert.ToInt32(txtN.Text);
            int tong = 0;
            for (int i = 0; i <= soN; i++)
            {
                tong = tong + i;
            }
            txtTong.Text = tong.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtN.Text = "";
            txtN.Focus();
            txtTong.Text = "";
        }
    }
}
