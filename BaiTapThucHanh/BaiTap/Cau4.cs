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
    public partial class Cau4 : Form
    {
        public Cau4()
        {
            InitializeComponent();
        }

        private void btTotal_Click(object sender, EventArgs e)
        {


            try
            {
                int num1 = int.Parse(txtNumber1.Text);
                int num2 = int.Parse(txtNumber2.Text);

                // phép cộng
                if (rdAdd.Checked == true)
                {
                    lbResult.Text = (num1 + num2).ToString();
                }
                // phép trừ
                if (rdSub.Checked == true)
                {
                    lbResult.Text = (num1 - num2).ToString();
                }
                // phép nhân
                if (rdMul.Checked == true)
                {
                    lbResult.Text = (num1 * num2).ToString();
                }
                //phép chia

                // chia lấy nguyên
                if (rdDiv.Checked == true)
                {
                    if (num2 != 0)
                    {
                        double temp = (double)num1 / num2;
                        lbResult.Text = temp.ToString();
                    }
                    else
                    {
                        lbResult.Text = "Mẩu bằng 0";
                    }
                }
                // chia lấy dư
                if (rdMod.Checked == true)
                {
                    if (num2 != 0)
                    {
                        double temp = (double)num1 % num2;
                        lbResult.Text = temp.ToString();
                    }
                    else
                    {
                        lbResult.Text = "Mẩu bằng 0";
                    }
                }


            }
            catch
            {
                lbResult.Text = "Sai định dạng";
                //throw;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
