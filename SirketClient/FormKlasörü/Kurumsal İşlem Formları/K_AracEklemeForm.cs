using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SirketClient.AracService;

namespace SirketClient.FormKlasörü.Kurumsal_İşlem_Formları
{
    public partial class K_AracEklemeForm : Form
    {
        public K_AracEklemeForm()
        {
            InitializeComponent();
        }

        public string KullaniciAdi { get; set; }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            AracServiceSoapClient client = new AracServiceSoapClient();
            AracResult arac = new AracResult();

            arac.Marka = txt_marka.Text;
            arac.Model = txt_model.Text;
            arac.AracYasi = Convert.ToInt32(txt_aracYasi.Text);
            arac.BagajHacmi = Convert.ToInt32(txt_bagajHacmi.Text);
            arac.KoltukSayisi = Convert.ToInt32(txt_koltukSayisi.Text);
            arac.GunlukFiyat = Convert.ToInt32(txt_gunlukFiyat.Text);
            arac.KiralanmaDurumu = radio_Kiralama.Checked;
            arac.AirbagDurum = radioAirbag.Checked;

            client.YeniAracEkle(arac, KullaniciAdi);



        }
    }
}
