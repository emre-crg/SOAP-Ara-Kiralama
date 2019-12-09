using SirketClient.FormKlasörü.Kurumsal_İşlem_Formları;
using SirketClient.FormKlasörü.LoginFormları;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketClient
{
    public partial class K_Anasayfa : Form
    {
        public K_Anasayfa()
        {
            InitializeComponent();
        }

        public string KullaniciAdi { get; set; }

        private void kiralamaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void müşteriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            K_MüsteriEkleme frmMus = new K_MüsteriEkleme();
            frmMus.MdiParent = this;
            frmMus.Show();
        }

        private void müşteriListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            K_MusteriListeleme frm = new K_MusteriListeleme();
            frm.MdiParent = this;
            frm.Show();
        }

        private void K_Anasayfa_Load(object sender, EventArgs e)
        {
            this.Text = KullaniciAdi;
        }

        private void yeniAraçEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            K_AracEklemeForm frm = new K_AracEklemeForm();

            frm.MdiParent = this;
            frm.KullaniciAdi = this.KullaniciAdi;
            frm.Show();
        }

        private void araçListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            K_AracListelemeForm frm = new K_AracListelemeForm();

            frm.MdiParent = this;
            frm.KullaniciAdi = this.KullaniciAdi;
            frm.Show();
        }

        private void araçBilgisiGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            K_AracGuncelleForm frm = new K_AracGuncelleForm();

            frm.MdiParent = this;
            frm.KullaniciAdi = this.KullaniciAdi;
            frm.Show();
        }
    }
}
