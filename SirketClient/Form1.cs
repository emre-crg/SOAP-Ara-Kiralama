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

namespace SirketClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriServiceSoapClient musteri = new MusteriServiceSoapClient();
            
            dataGridView1.DataSource = musteri.MusteriListele();

           
            

        }

        private void btn_must_ekle_Click(object sender, EventArgs e)
        {
            MusteriServiceSoapClient musteri = new MusteriServiceSoapClient();
            MusteriResult musteriRESULT = new MusteriResult();

            musteriRESULT.Ad = txt_isim.Text;
            musteriRESULT.Soyad = txt_soyisim.Text;
            musteriRESULT.TCkimlik = txt_tckimlik.Text;
            musteriRESULT.Adres = txt_Adres.Text;

          
             

        }
    }
}
