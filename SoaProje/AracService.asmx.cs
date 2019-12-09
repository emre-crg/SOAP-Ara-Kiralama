using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SoaProje
{
    /// <summary>
    /// Summary description for AracService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AracService : System.Web.Services.WebService
    {
        DBSOADataContext dc = new DBSOADataContext();

        [WebMethod]
        public void YeniAracEkle(AracResult arac, string KullaniciAdi)  //String KullanıcıAdı Almalı
        {
            Arac x = new Arac();      //Yeni araç

            var sorgu = from o in dc.Oturums
                        join s in dc.Sirkets on o.ID equals s.OturumID
                        where o.KullanıcıAdı == KullaniciAdi                        
                        select new { s.SirketID };              //Bu şirketin şirketID'si.

            foreach (var item in sorgu)
            {
               x.SirketID = item.SirketID;
            }

            x.Marka = arac.Marka;
            x.Model = arac.Model;
            x.Yasi = arac.AracYasi;
            x.BagajHacmi = arac.BagajHacmi;
            x.KoltukSayisi = arac.KoltukSayisi;
            x.GunlukFiyat = arac.GunlukFiyat;
          //x.SirketID = SirketID;
            x.KiralanmaDurumu = arac.KiralanmaDurumu;
            x.airbag = arac.AirbagDurum;

            dc.Aracs.InsertOnSubmit(x);
            dc.SubmitChanges();
        }

        [WebMethod]
        public List<AracResult> AracListele(string KullaniciAdi) //Kurumun araclarını listeler.
        {
            AracResult aracResult = new AracResult();
            List<AracResult> LİSTresults = new List<AracResult>();

            var sorgu = from o in dc.Oturums
                        join s in dc.Sirkets on o.ID equals s.OturumID
                        join a in dc.Aracs on s.SirketID equals a.SirketID
                        where o.KullanıcıAdı == KullaniciAdi
                        select a;


            int sayac = 0;
            foreach (var i in sorgu)
            {
                AracResult a = new AracResult(); //Hahahha pointerın amq ..:)

                a.AracID = i.AracID;
                a.Marka = i.Marka;
                a.Model = i.Model;
                a.AracYasi = i.Yasi;
                a.BagajHacmi = i.BagajHacmi;
                a.KoltukSayisi = i.KoltukSayisi;
                a.GunlukFiyat = i.GunlukFiyat;
                a.KiralanmaDurumu = i.KiralanmaDurumu;
                a.AirbagDurum = i.airbag;

                

                LİSTresults.Add(a);                  
                sayac++;
            }
            
            return LİSTresults;
        }


        [WebMethod]
        public void AracGuncelle(AracResult arac,int aracID)
        {
            Arac araba = dc.Aracs.First(x => x.AracID == aracID);

            araba.Marka = arac.Marka;
            araba.Model = arac.Model;
            araba.Yasi = arac.AracYasi;
            araba.BagajHacmi = arac.BagajHacmi;
            araba.KoltukSayisi = arac.KoltukSayisi;
            araba.GunlukFiyat = arac.GunlukFiyat;
            araba.KiralanmaDurumu = arac.KiralanmaDurumu;
            araba.airbag = arac.AirbagDurum;

            dc.SubmitChanges();
        }

        [WebMethod]
        public void AracSil(int aracID)
        {
            Arac arac = dc.Aracs.First(x => x.AracID ==aracID);

            dc.Aracs.DeleteOnSubmit(arac);
            dc.SubmitChanges();

        }

        /*
                [WebMethod]
                public List<AracResult> AracListele2(string KullaniciAdi)       
                {
                    DBSOADataContext yeniDB = new DBSOADataContext();

                    var sorgu = from o in dc.Oturums
                                join s in dc.Sirkets on o.ID equals s.OturumID
                                join a in dc.Aracs on s.SirketID equals a.SirketID
                                where o.KullanıcıAdı == KullaniciAdi
                                select new { a};




                    return dc.Aracs.Select(x => new AracResult
                    {
                        Marka = x.Marka,
                        Model = x.Model,
                        AracYasi = x.Yasi,
                        BagajHacmi = x.BagajHacmi,
                        KoltukSayisi = x.KoltukSayisi,
                        GunlukFiyat = x.GunlukFiyat,
                        KiralanmaDurumu = x.KiralanmaDurumu,
                        AirbagDurum = x.airbag

                    }).ToList();
                }
*/

    }



    public class AracResult
    {
        public int AracID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int? AracYasi { get; set; }
        public int? BagajHacmi { get; set; }
        public int? KoltukSayisi { get; set; }
        public decimal? GunlukFiyat { get; set; }
        public bool? KiralanmaDurumu { get; set; }
        public bool? AirbagDurum { get; set; }

    }


}
