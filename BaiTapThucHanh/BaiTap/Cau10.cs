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
    public partial class Cau10 : Form
    {
        public Cau10()
        {
            InitializeComponent();
        }
        class PhanSo
        {
            public int tuso { get; set; }
            public int mauso { get; set; }

            public int ucln(int mau1, int mau2)
            {
                int r = 1;
                while (r != 0)
                {
                    r = mau1 % mau2;
                    mau1 = mau2;
                    mau2 = r;
                }
                return mau1;
            }
            private PhanSo PhuongThucCong(PhanSo ps1, PhanSo ps2)
            {
                PhanSo ps3 = new PhanSo();
                ps3.tuso = ps1.tuso * ps2.mauso + ps2.tuso * ps1.tuso;
                ps3.mauso = ps1.mauso * ps2.mauso;
                int uc = ucln(ps3.tuso, ps3.mauso);
                ps3.tuso = ps3.tuso / uc;
                ps3.tuso = ps3.mauso / uc;
                return ps3;
            }
        }
        private void Cau10_Load(object sender, EventArgs e)
        {

        }

    }
}
