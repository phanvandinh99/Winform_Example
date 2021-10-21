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
    public partial class Cau6 : Form
    {
        public Cau6()
        {
            InitializeComponent();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            txtSo1.Text = rd.Next(0, 99).ToString();
            txtSo2.Text = rd.Next(0, 99).ToString();
            string pheptinhrd = "+-*/";
            for (int i = 0; i < 3; i++)
            {
                txtPhepTinh.Text = (pheptinhrd[rd.Next(0, pheptinhrd.Length)]).ToString();
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text = txtTraLoi.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text = txtTraLoi.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text = txtTraLoi.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text = txtTraLoi.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text = txtTraLoi.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text = txtTraLoi.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text = txtTraLoi.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text = txtTraLoi.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text = txtTraLoi.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTraLoi.Text = txtTraLoi.Text + "9";
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            txtPhepTinh.Text = "-";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtSo1.Text);
                int b = int.Parse(txtSo2.Text);
                switch (txtPhepTinh.Text)
                {
                    case "+":
                        int ketquacong = a + b;
                        if (ketquacong == int.Parse(txtTraLoi.Text))
                        {
                            txtKetQua.Text = "Đúng";
                        }
                        else
                        {
                            txtKetQua.Text = "Sai";
                        }
                        break;
                    case "-":
                        int ketquatru = a + b;
                        if (ketquatru == int.Parse(txtTraLoi.Text))
                        {
                            txtKetQua.Text = "Đúng";
                        }
                        else
                        {
                            txtKetQua.Text = "Sai";
                        }
                        break;
                    case "*":
                        int ketquanhan = a + b;
                        if (ketquanhan == int.Parse(txtTraLoi.Text))
                        {
                            txtKetQua.Text = "Đúng";
                        }
                        else
                        {
                            txtKetQua.Text = "Sai";
                        }
                        break;
                    case "/":
                        double ketquachia = (double)a + b;
                        if (ketquachia == double.Parse(txtTraLoi.Text))
                        {
                            txtKetQua.Text = "Đúng";
                        }
                        else
                        {
                            txtKetQua.Text = "Sai";
                        }
                        break;
                    default:
                        txtKetQua.Text = "Không hợp lệ";
                        break;
                }
            }
            catch (Exception)
            {
                txtKetQua.Text = "Không bỏ trống hoặc sai định dạng";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = "";
            txtPhepTinh.Text = "";
            txtSo1.Text = "";
            txtSo2.Text = "";
            txtTraLoi.Text = "";
            txtSo1.Focus();
        }
    }
}