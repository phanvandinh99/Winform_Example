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
        #region class PhanSo
        private class PhanSo
        {
            private int tuso { get; set; }
            private int mauso { get; set; }


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
            #region Cộng hai phân số
            public int PhuongThucCongTuSo(int tuso1, int mauso1, int tuso2, int mauso2)
            {
                PhanSo ps3 = new PhanSo();
                ps3.tuso = tuso1 * mauso2 + tuso2 * mauso1;
                ps3.mauso = mauso1 * mauso2;
                int uc = ucln(ps3.tuso, ps3.mauso);
                ps3.tuso = ps3.tuso / uc;
                ps3.mauso = ps3.mauso / uc;
                //return ps3.tuso;
                return ps3.tuso;
            }
            public int PhuongThucCongMauSo(int tuso1, int mauso1, int tuso2, int mauso2)
            {
                PhanSo ps3 = new PhanSo();
                ps3.tuso = tuso1 * mauso2 + tuso2 * mauso1;
                ps3.mauso = mauso1 * mauso2;
                int uc = ucln(ps3.tuso, ps3.mauso);
                ps3.tuso = ps3.tuso / uc;
                ps3.mauso = ps3.mauso / uc;
                return ps3.mauso;
            }
            #endregion
            #region trừ hai phân số
            public int PhuongThucTruTuSo(int tuso1, int mauso1, int tuso2, int mauso2)
            {
                PhanSo ps3 = new PhanSo();
                ps3.tuso = tuso1 * mauso2 - tuso2 * mauso1;
                ps3.mauso = mauso1 * mauso2;
                int uc = ucln(ps3.tuso, ps3.mauso);
                ps3.tuso = ps3.tuso / uc;
                ps3.mauso = ps3.mauso / uc;
                //return ps3.tuso;
                return ps3.tuso;
            }
            public int PhuongThucTruMauSo(int tuso1, int mauso1, int tuso2, int mauso2)
            {
                PhanSo ps3 = new PhanSo();
                ps3.tuso = tuso1 * mauso2 - tuso2 * mauso1;
                ps3.mauso = mauso1 * mauso2;
                int uc = ucln(ps3.tuso, ps3.mauso);
                ps3.tuso = ps3.tuso / uc;
                ps3.mauso = ps3.mauso / uc;
                return ps3.mauso;
            }
            #endregion
            #region nhân hai phân số
            public int PhuongThucNhanTuSo(int tuso1, int mauso1, int tuso2, int mauso2)
            {
                PhanSo ps3 = new PhanSo();
                ps3.tuso = tuso1 * tuso2;
                ps3.mauso = mauso1 * mauso2;
                int uc = ucln(ps3.tuso, ps3.mauso);
                ps3.tuso = ps3.tuso / uc;
                ps3.mauso = ps3.mauso / uc;
                //return ps3.tuso;
                return ps3.tuso;
            }
            public int PhuongThucNhanMauSo(int tuso1, int mauso1, int tuso2, int mauso2)
            {
                PhanSo ps3 = new PhanSo();
                ps3.tuso = tuso1 * tuso2;
                ps3.mauso = mauso1 * mauso2;
                int uc = ucln(ps3.tuso, ps3.mauso);
                ps3.tuso = ps3.tuso / uc;
                ps3.mauso = ps3.mauso / uc;
                return ps3.mauso;
            }
            #endregion
            #region chia hai phân số
            public int PhuongThucChiaTuSo(int tuso1, int mauso1, int tuso2, int mauso2)
            {
                PhanSo ps3 = new PhanSo();
                ps3.tuso = tuso1 * mauso2;
                ps3.mauso = mauso1 * tuso2;
                int uc = ucln(ps3.tuso, ps3.mauso);
                ps3.tuso = ps3.tuso / uc;
                ps3.mauso = ps3.mauso / uc;
                //return ps3.tuso;
                return ps3.tuso;
            }
            public int PhuongThucChiaMauSo(int tuso1, int mauso1, int tuso2, int mauso2)
            {
                PhanSo ps3 = new PhanSo();
                ps3.tuso = tuso1 * mauso2;
                ps3.mauso = mauso1 * tuso2;
                int uc = ucln(ps3.tuso, ps3.mauso);
                ps3.tuso = ps3.tuso / uc;
                ps3.mauso = ps3.mauso / uc;
                return ps3.mauso;
            }
            #endregion

        }
        #endregion

        private void Cau10_Load(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                int tu1 = int.Parse(txtTuSo1.Text);
                int mau1 = int.Parse(txtMauSo1.Text);
                int tu2 = int.Parse(txtTuSo2.Text);
                int mau2 = int.Parse(txtMauSo2.Text);
                PhanSo ps = new PhanSo();
                txtTuSoKQ.Text = ps.PhuongThucCongTuSo(tu1, mau1, tu2, mau2).ToString();
                txtMauSoKQ.Text = ps.PhuongThucCongMauSo(tu1, mau1, tu2, mau2).ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi rồi!", "Thông báo");
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                int tu1 = int.Parse(txtTuSo1.Text);
                int mau1 = int.Parse(txtMauSo1.Text);
                int tu2 = int.Parse(txtTuSo2.Text);
                int mau2 = int.Parse(txtMauSo2.Text);
                PhanSo ps = new PhanSo();
                txtTuSoKQ.Text = ps.PhuongThucTruTuSo(tu1, mau1, tu2, mau2).ToString();
                txtMauSoKQ.Text = ps.PhuongThucTruMauSo(tu1, mau1, tu2, mau2).ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi rồi!", "Thông báo");
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                int tu1 = int.Parse(txtTuSo1.Text);
                int mau1 = int.Parse(txtMauSo1.Text);
                int tu2 = int.Parse(txtTuSo2.Text);
                int mau2 = int.Parse(txtMauSo2.Text);
                PhanSo ps = new PhanSo();
                txtTuSoKQ.Text = ps.PhuongThucNhanTuSo(tu1, mau1, tu2, mau2).ToString();
                txtMauSoKQ.Text = ps.PhuongThucNhanMauSo(tu1, mau1, tu2, mau2).ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi rồi!", "Thông báo");
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                int tu1 = int.Parse(txtTuSo1.Text);
                int mau1 = int.Parse(txtMauSo1.Text);
                int tu2 = int.Parse(txtTuSo2.Text);
                int mau2 = int.Parse(txtMauSo2.Text);
                PhanSo ps = new PhanSo();
                txtTuSoKQ.Text = ps.PhuongThucChiaTuSo(tu1, mau1, tu2, mau2).ToString();
                txtMauSoKQ.Text = ps.PhuongThucChiaMauSo(tu1, mau1, tu2, mau2).ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi rồi!", "Thông báo");
            }
        }
    }
}
