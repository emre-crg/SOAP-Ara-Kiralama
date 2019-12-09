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
namespace SirketClient.FormKlasörü.LoginFormları
{
    public partial class K_MusteriListeleme : Form
    {
        public K_MusteriListeleme()
        {
            InitializeComponent();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            MusteriServiceSoapClient service = new MusteriServiceSoapClient();

            dataGridView1.DataSource = service.MusteriListele();
        }
    }
}
