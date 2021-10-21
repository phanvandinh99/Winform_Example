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
    public partial class Cau7 : Form
    {
        public Cau7()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int total = 0;
            int rangtram = (int)nudTramRang.Value;
            if(txtTenKhachHang.Text=="")
            {
                MessageBox.Show("Bạn không được bỏ trống tên");
            }
            else
            {
                if(ckCaoVoi.Checked==true)
                {
                    total = total + 100;
                }
                if(ckTayTrang.Checked == true)
                {
                    total = total + 1200;
                }
                if (ckChupHinhRang.Checked == true)
                {
                    total = total + 200;
                }
                total = total + (rangtram * 80);
                txtTotal.Text = total.ToString();
                
            }    
        }
    }
}
