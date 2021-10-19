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
    public partial class Cau5 : Form
    {
        public Cau5()
        {
            InitializeComponent();
        }

        private void btnQuaySo_Click(object sender, EventArgs e)
        {
            int diem = 0;
            Random rd = new Random();

            lbSo1.Text = (rd.Next(0, 9)).ToString();
            lbSo2.Text = (rd.Next(0, 9)).ToString();
            lbSo3.Text = (rd.Next(0, 9)).ToString();
            // gán giá trị vào biến
            int a = int.Parse(lbSo1.Text);
            int b = int.Parse(lbSo2.Text);
            int c = int.Parse(lbSo3.Text);

            int Tong = (a + b + c);
            if(Tong>=3 && Tong<=10)
            {
                diem = diem + 10;
                lbDiem.Text = diem.ToString();
            }
            else
            {

            }
            if (Tong >= 11 && Tong <= 18)
            {
                diem = diem + 10;
                lbDiem.Text = diem.ToString();
            }
        }
    }
}
