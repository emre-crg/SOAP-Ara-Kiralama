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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void müsteriGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriLogin musteriLog = new MusteriLogin();

            musteriLog.MdiParent = this;
            musteriLog.Show();
        }

        private void kurumsalGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {

            KurumsalLogin kurumsalLog = new KurumsalLogin();

            kurumsalLog.MdiParent = this;
            kurumsalLog.Show();
        }
    }
}
