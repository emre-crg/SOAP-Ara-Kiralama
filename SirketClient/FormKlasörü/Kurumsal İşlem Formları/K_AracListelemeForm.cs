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
    public partial class K_AracListelemeForm : Form
    {
        public K_AracListelemeForm()
        {
            InitializeComponent();
        }

        public string KullaniciAdi { get; set; }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            AracServiceSoapClient client = new AracServiceSoapClient();

            dataGridView1.DataSource = client.AracListele(KullaniciAdi); 

        }
    }
}
