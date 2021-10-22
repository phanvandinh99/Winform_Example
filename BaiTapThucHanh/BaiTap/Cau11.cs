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
    public partial class Cau11 : Form
    {
        public Cau11()
        {
            InitializeComponent();
        }
        int Diem = 0;
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
        private void Cau11_Load(object sender, EventArgs e)
        {

        }



        private void btnChoiTiep_Click(object sender, EventArgs e)
        {
            Random rd = new Random();

            int rd_tu1 = rd.Next(1, 100);
            int rd_mau1 = rd.Next(1, 100);
            int rd_tu2 = rd.Next(1, 100);
            int rd_mau2 = rd.Next(1, 100);

            txtTuSo1.Text = rd_tu1.ToString();
            txtMauSo1.Text = rd_mau1.ToString();
            txtTuSo2.Text = rd_tu2.ToString();
            txtMauSo2.Text = rd_mau2.ToString();
            string pheptinhrd = "+-*/";
            for (int i = 0; i < 3; i++)
            {
                txtPhepTinh.Text = (pheptinhrd[rd.Next(0, pheptinhrd.Length)]).ToString();
            }

            txtTuSoKQ.Clear();
            txtTuSoKQ.Focus();
            txtMauSoKQ.Clear();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                switch (txtPhepTinh.Text)
                {
                    case "+":
                        int tu1 = int.Parse(txtTuSo1.Text);
                        int mau1 = int.Parse(txtMauSo1.Text);
                        int tu2 = int.Parse(txtTuSo2.Text);
                        int mau2 = int.Parse(txtMauSo2.Text);
                        PhanSo ps = new PhanSo();
                        int TU = ps.PhuongThucCongTuSo(tu1, mau1, tu2, mau2);
                        int MAU = ps.PhuongThucCongMauSo(tu1, mau1, tu2, mau2);

                        int NhapTu = int.Parse(txtTuSoKQ.Text);
                        int NhapMau = int.Parse(txtMauSoKQ.Text);
                        if(NhapTu==TU && NhapMau==MAU)
                        {
                            Diem = Diem + 1;
                            labKetQua.Text = ("Đúng, Bạn dược +1 điểm ");
                        }    
                        else
                        {
                            Diem = Diem - 1;
                            labKetQua.Text = ("Sai " + "Kết quả đúng =  " + TU +"/"+ MAU);
                        }
                        txtSoDiem.Text = Diem.ToString();
                        break;
                    case "-":
                        int tuTru1 = int.Parse(txtTuSo1.Text);
                        int mauTru1 = int.Parse(txtMauSo1.Text);
                        int tuTru2 = int.Parse(txtTuSo2.Text);
                        int mauTru2 = int.Parse(txtMauSo2.Text);
                        PhanSo psTru = new PhanSo();
                        int TUTru = psTru.PhuongThucCongTuSo(tuTru1, mauTru1, tuTru2, mauTru2);
                        int MAUTru = psTru.PhuongThucCongMauSo(tuTru1, mauTru1, tuTru2, mauTru2);

                        int NhapTuTru = int.Parse(txtTuSoKQ.Text);
                        int NhapMauTru = int.Parse(txtMauSoKQ.Text);
                        if (NhapTuTru == TUTru && NhapMauTru == MAUTru)
                        {
                            Diem = Diem + 1;
                            labKetQua.Text = ("Đúng, Bạn dược +1 điểm ");
                        }
                        else
                        {
                            Diem = Diem - 1;
                            labKetQua.Text = ("Sai " + "Kết quả đúng =  " + TUTru + "/" + MAUTru);
                        }
                        txtSoDiem.Text = Diem.ToString();
                        break;
                    case "*":
                        int tunhan1 = int.Parse(txtTuSo1.Text);
                        int maunhan1 = int.Parse(txtMauSo1.Text);
                        int tunhan2 = int.Parse(txtTuSo2.Text);
                        int maunhan2 = int.Parse(txtMauSo2.Text);
                        PhanSo psnhan = new PhanSo();
                        int TUnhan = psnhan.PhuongThucCongTuSo(tunhan1, maunhan1, tunhan2, maunhan2);
                        int MAUnhan = psnhan.PhuongThucCongMauSo(tunhan1, maunhan1, tunhan2, maunhan2);

                        int NhapTunhan = int.Parse(txtTuSoKQ.Text);
                        int NhapMaunhan = int.Parse(txtMauSoKQ.Text);
                        if (NhapTunhan == TUnhan && NhapMaunhan == MAUnhan)
                        {
                            Diem = Diem + 1;
                            labKetQua.Text = ("Đúng, Bạn dược +1 điểm ");
                        }
                        else
                        {
                            Diem = Diem - 1;
                            labKetQua.Text = ("Sai " + "Kết quả đúng =  " + TUnhan + "/" + MAUnhan);
                        }
                        txtSoDiem.Text = Diem.ToString();
                        break;
                    case "/":
                        int tuchia1 = int.Parse(txtTuSo1.Text);
                        int mauchia1 = int.Parse(txtMauSo1.Text);
                        int tuchia2 = int.Parse(txtTuSo2.Text);
                        int mauchia2 = int.Parse(txtMauSo2.Text);
                        PhanSo pschia = new PhanSo();
                        int TUchia = pschia.PhuongThucCongTuSo(tuchia1, mauchia1, tuchia2, mauchia2);
                        int MAUchia = pschia.PhuongThucCongMauSo(tuchia1, mauchia1, tuchia2, mauchia2);

                        int NhapTuchia = int.Parse(txtTuSoKQ.Text);
                        int NhapMauchia = int.Parse(txtMauSoKQ.Text);
                        if (NhapTuchia == TUchia && NhapMauchia == MAUchia)
                        {
                            Diem = Diem + 1;
                            labKetQua.Text = ("Đúng, Bạn dược +1 điểm ");
                        }
                        else
                        {
                            Diem = Diem - 1;
                            labKetQua.Text = ("Sai " + "Kết quả đúng =  " + TUchia + "/" + MAUchia);
                        }
                        txtSoDiem.Text = Diem.ToString();
                        break;
                    default:
                        labKetQua.Text = "Không hợp lệ";
                        break;
                }
            }
            catch (Exception)
            {
                labKetQua.Text = "Không bỏ trống hoặc sai định dạng";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
