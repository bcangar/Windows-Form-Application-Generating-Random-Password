using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru1_sifreUret
{
    public partial class Form1 : Form
    {
        bool kucukHarfVarMi, buyukHarfVarMi, rakamVarMi, ozelKarakterVarMi;
        int sifreUzunlugu, sifreSayisi;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            string seciliKarakterler = "";

            kucukHarfVarMi = chkKucukH.Checked;
            buyukHarfVarMi = chkBuyukH.Checked;
            rakamVarMi = chkRakam.Checked;
            ozelKarakterVarMi = chkOzel.Checked;

            sifreSayisi = (int)nudSifreSayi.Value;
            sifreUzunlugu = (int)nudSifreeUzunluk.Value;


            if (!(kucukHarfVarMi || buyukHarfVarMi || rakamVarMi || ozelKarakterVarMi))
            {
                MessageBox.Show("En az 1 parametre seçiniz!");
                return;
            }

            if (kucukHarfVarMi)
            {
                for (int i = 97; i <= 122; i++)
                    seciliKarakterler += Convert.ToChar(i);
            }

            if (buyukHarfVarMi)
            {
                for (int i = 65; i <= 90; i++)
                    seciliKarakterler += Convert.ToChar(i);
            }
            if (rakamVarMi)
            {
                for (int i = 48; i <= 57; i++)
                    seciliKarakterler += Convert.ToChar(i);
            }

            if (ozelKarakterVarMi)
            {
                for (int i = 33; i <= 47; i++)
                    seciliKarakterler += Convert.ToChar(i);
                for (int i = 58; i <= 64; i++)
                    seciliKarakterler += Convert.ToChar(i);
                for (int i = 91; i <= 96; i++)
                    seciliKarakterler += Convert.ToChar(i);
                for (int i = 123; i <= 126; i++)
                    seciliKarakterler += Convert.ToChar(i);
            }

            string yeniKelime = "";

            txtSifreler.Clear();

            for (int i = 0; i < sifreSayisi; i++)
            {

                yeniKelime = "";
                for (int j = 0; j < sifreUzunlugu; j++)
                {
                    yeniKelime += seciliKarakterler[random.Next(seciliKarakterler.Length)];

                }
                txtSifreler.Text += yeniKelime + "\r\n" + "\r\n";

            }
        }






    }
}
