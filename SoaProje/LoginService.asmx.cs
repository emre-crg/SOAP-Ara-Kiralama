using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SoaProje
{
    /// <summary>
    /// Summary description for LoginService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LoginService : System.Web.Services.WebService
    {
        DBSOADataContext db = new DBSOADataContext();

        [WebMethod]
        public bool MusteriGiris(OturumResult oturum)
        {
            
            var sorgu = from o in db.Oturums join m in db.Müsteris on o.ID equals m.OturumID
                        where o.KullanıcıAdı == oturum.KullaniciAdi
                        && o.Sifre == oturum.Sifre && o.ID == m.OturumID
                        select new {o , m};

            if (sorgu.Any())
            {             
                return true;
            }

            else
            {
                return false;
            }

        }


        [WebMethod]
        public bool KurumsalGiris(OturumResult oturum)
        {
             
            var sorgu = from o in db.Oturums join s in db.Sirkets on o.ID equals s.OturumID
                        where o.KullanıcıAdı == oturum.KullaniciAdi
                        && o.Sifre == oturum.Sifre && o.ID == s.OturumID
                        select new {o , s};

            if (sorgu.Any())
            {             
                return true;
            }

            else
            {
                return false;
            }

        }

    }

    public class OturumResult
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

    }
}
