using System;
using System.IO;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class Cau9 : Form
    {
        public Cau9()
        {
            InitializeComponent();
            Display_Log();
        }
        string path = @"C:\Users\phanv\OneDrive\Máy tính\Winform_Example\BaiTapThucHanh\Assets\Cau9_log.txt";

        private void btnThang_Click(object sender, EventArgs e)
        {


            try
            {
                StreamWriter stream = File.AppendText(path);
                int a = int.Parse(txtCode.Text);
                // Technocians
                if (1645 <= a && a <= 1689)
                {
                    MessageBox.Show("Successful access Technicians", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        stream.WriteLine(DateTime.Now + "   Technicians");
                        stream.Dispose();
                }
                else if (a == 8345)
                {
                    MessageBox.Show("Successful access Custodians", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stream.WriteLine(DateTime.Now + "   Custodians");
                    stream.Dispose();
                }
                else if (a == 9998 || a <= 1008 & a >= 1006)
                {
                    MessageBox.Show("Successful access Scientist", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stream.WriteLine(DateTime.Now + "   Scientist");
                    stream.Dispose();
                }
                else
                {
                    MessageBox.Show("Unlimited Access", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stream.WriteLine(DateTime.Now + "   Restricted Access");
                    stream.Dispose();
                }
                Display_Log();
            }
            catch
            {
                MessageBox.Show("Error", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        // hiển thị lên form log
        private void Display_Log()
        {
            lstLog.Items.Clear();
            string[] loglist = File.ReadAllLines(path);
            foreach (string line in loglist)
            {
                lstLog.Items.Add(line);
            }
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
    }
}
