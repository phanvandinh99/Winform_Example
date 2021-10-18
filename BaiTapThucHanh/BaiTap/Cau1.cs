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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtSoA.Text = "";
            txtSoA.Focus();
            txtSoB.Text = "";
            txtKetQua.Text = "";
        }

        private void btnSoSanh_Click(object sender, EventArgs e)
        {
            int soA = Convert.ToInt32(txtSoA.Text);
            int soB = Convert.ToInt32(txtSoB.Text);
            if (soA > soB)
            {
                txtKetQua.Text = soA.ToString();
            }
            else
            {
                txtKetQua.Text = soB.ToString();
            }

        }

        private void txtSoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbKetQua_Click(object sender, EventArgs e)
        {

        }

        private void lbNhapSoB_Click(object sender, EventArgs e)
        {

        }

        private void lbNhapSoA_Click(object sender, EventArgs e)
        {

        }
    }
}
