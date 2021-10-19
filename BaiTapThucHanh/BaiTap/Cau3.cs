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
    public partial class Cau3 : Form
    {
        public Cau3()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txtSoThu1.Text);
            int so2 = int.Parse(txtSoThu2.Text);
            txtKetQua.Text = (so1 + so2).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txtSoThu1.Text);
            int so2 = int.Parse(txtSoThu2.Text);
            txtKetQua.Text = (so1 - so2).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txtSoThu1.Text);
            int so2 = int.Parse(txtSoThu2.Text);
            txtKetQua.Text = (so1 * so2).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txtSoThu1.Text);
            int so2 = int.Parse(txtSoThu2.Text);
            double kq = (double) so1 / so2;
            txtKetQua.Text = kq.ToString();
        }
    }
}
