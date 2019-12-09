using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data.SqlClient;

namespace SoaProje
{
    /// <summary>
    /// Summary description for MusteriService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MusteriService : System.Web.Services.WebService
    {
        DBSOADataContext dc = new DBSOADataContext();

        [WebMethod]
        public void MusteriEkle(MusteriResult musteri, OturumM otr )
        {
            Müsteri m = new Müsteri();       //Yeni müşteri 
            
            m.İsim = musteri.Ad;
            m.Soyisim = musteri.Soyad;
            m.TCNo = musteri.TCkimlik;
            m.Adres = musteri.Adres;


            var sorgu = from o in dc.Oturums
                        where o.KullanıcıAdı == otr.KullaniciAdi
                        select new { o.ID };


            foreach (var i in sorgu)
            {
                m.OturumID = i.ID;
            }

            

            dc.Müsteris.InsertOnSubmit(m);           
            dc.SubmitChanges();
        }

        [WebMethod]
        public void OturumEkle(OturumM oturum)
        {
            Oturum o = new Oturum();

            o.KullanıcıAdı = oturum.KullaniciAdi;
            o.Sifre = oturum.Sifre;

            dc.Oturums.InsertOnSubmit(o);
            dc.SubmitChanges();
        }


        [WebMethod]
        public List<MusteriResult> MusteriListele()
        {
            return dc.Müsteris.Select(x => new MusteriResult
            {
                MusteriID = x.MüsteriID,
                Ad = x.İsim,
                Soyad = x.Soyisim,
                TCkimlik = x.TCNo,
                Adres = x.Adres

            }).ToList();
        }
      
      


    }

    public class MusteriResult
    {
        public int MusteriID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCkimlik { get; set; }
        public string Adres { get; set; }

    }

    public class OturumM
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }

}
