using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SirketClient.LoginService;

namespace SirketClient.FormKlasörü.LoginFormları
{
    public partial class KurumsalLogin : Form
    {
        public KurumsalLogin()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            LoginServiceSoapClient log = new LoginServiceSoapClient();
            OturumResult otr = new OturumResult();

            otr.KullaniciAdi = txb_kullanıcıAdi.Text;
            otr.Sifre = txt_Sifre.Text;


            if (log.KurumsalGiris(otr))
            {               
                K_Anasayfa frm = new K_Anasayfa();
                frm.KullaniciAdi = otr.KullaniciAdi;
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Hatalı Giris..");
            }

        }
    }
}
