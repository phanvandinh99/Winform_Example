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
    public partial class Cau8 : Form
    {
        public Cau8()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCode.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCode.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCode.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCode.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCode.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCode.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCode.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCode.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCode.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCode.Text += "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtCode.Focus();
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtCode.Text);
                // Technocians
                if (1645 <= a && a <= 1689)
                {
                    MessageBox.Show("Successful access Technicians");
                    lstLog.Items.Add(DateTime.Now + "   Technicians");
                }
                else if (a == 8345)
                {
                    MessageBox.Show("Successful access Custodians");
                    lstLog.Items.Add(DateTime.Now + "   Custodians");
                }
                else if (a == 9998 || a <= 1008 & a >= 1006)
                {
                    MessageBox.Show("Successful access Scientist");
                    lstLog.Items.Add(DateTime.Now + "   Scientist");
                }
                else
                {
                    MessageBox.Show("Unlimited Access");
                    lstLog.Items.Add(DateTime.Now + "   Restricted Access");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
    }
}
