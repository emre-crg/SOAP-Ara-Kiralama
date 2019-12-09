using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SirketClient.MusteriService;

namespace SirketClient.FormKlasörü.Kurumsal_İşlem_Formları
{
    public partial class K_MüsteriEkleme : Form
    {
        public K_MüsteriEkleme()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            MusteriServiceSoapClient client = new MusteriServiceSoapClient();

            MusteriResult musteri = new MusteriResult();
            OturumM oturum = new OturumM();

            musteri.Ad = txt_isim.Text;
            musteri.Soyad = txt_Soyad.Text;
            musteri.TCkimlik = txt_TCNo.Text;
            musteri.Adres = txt_Adres.Text;

            

            oturum.KullaniciAdi = txt_kullanıcıAdi.Text;
            oturum.Sifre = txt_sifre.Text;

            client.OturumEkle(oturum);
            client.MusteriEkle(musteri , oturum);


        }
    }
}
