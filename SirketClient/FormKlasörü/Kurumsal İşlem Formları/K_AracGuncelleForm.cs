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
    public partial class K_AracGuncelleForm : Form
    {
        public K_AracGuncelleForm()
        {
            InitializeComponent();
        }

       public string KullaniciAdi { get; set; }

       private void DataGridGüncelle()
        {
            AracServiceSoapClient client = new AracServiceSoapClient();

            dataGrid.DataSource = client.AracListele(KullaniciAdi);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void K_AracGuncelleForm_Load(object sender, EventArgs e)
        {
            DataGridGüncelle();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracServiceSoapClient clientSil = new AracServiceSoapClient();
            int id = int.Parse(dataGrid.CurrentRow.Cells[0].Value.ToString());

            clientSil.AracSil(id);

            DataGridGüncelle();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {                                            //TextBox'lar Doldurulur...

            txt_marka.Text = dataGrid.CurrentRow.Cells[1].Value.ToString();
            txt_model.Text = dataGrid.CurrentRow.Cells[2].Value.ToString();
            txt_aracyasi.Text = dataGrid.CurrentRow.Cells[3].Value.ToString();
            txt_bagajHacmi.Text = dataGrid.CurrentRow.Cells[4].Value.ToString();
            txt_koltukSayisi.Text = dataGrid.CurrentRow.Cells[5].Value.ToString();
            txt_GünlükFiyat.Text = dataGrid.CurrentRow.Cells[6].Value.ToString();
            


        }

        private void button2_Click(object sender, EventArgs e) //Güncelleme Buttonu..
        {
            AracServiceSoapClient clientArac = new AracServiceSoapClient();
            AracResult arac = new AracResult();

            int id = int.Parse(dataGrid.CurrentRow.Cells[0].Value.ToString());

            arac.Marka = txt_marka.Text;
            arac.Model = txt_model.Text;
            arac.AracYasi = Convert.ToInt32(txt_aracyasi.Text);
            arac.BagajHacmi = Convert.ToInt32(txt_bagajHacmi.Text);
            arac.KoltukSayisi = Convert.ToInt32(txt_koltukSayisi.Text);
            arac.GunlukFiyat = Convert.ToDecimal(txt_GünlükFiyat.Text);

            if (comKiralanmaD.SelectedIndex == 0) { arac.KiralanmaDurumu = false; }
            else arac.KiralanmaDurumu = true;

            if (comAirbag.SelectedIndex == 0) { arac.AirbagDurum = false; }
            else arac.AirbagDurum = true;

            clientArac.AracGuncelle(arac, id);

            DataGridGüncelle();
        }
    }
}
