using SirketClient.LoginService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketClient.FormKlasörü.LoginFormları
{
    public partial class MusteriLogin : Form
    {
        public MusteriLogin()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            LoginServiceSoapClient log = new LoginServiceSoapClient();
            OturumResult otr = new OturumResult();

            otr.KullaniciAdi = txb_kullanıcıAdi.Text;
            otr.Sifre = txt_Sifre.Text;


            if (log.MusteriGiris(otr))
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Hatalı Giris..");
            }

        }
    }
}
