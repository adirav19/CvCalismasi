using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvCalismasi
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        dbCVreEntities db = new dbCVreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            var mesaj = db.TblIletisim.Find(x);
            TextAdsoyad.Text = mesaj.Adsoyad;
            TextMail.Text = mesaj.Mail;
            TextKonu.Text = mesaj.Konu;
            TextMesaj.Text = mesaj.Mesaj;
                
        }
    }
}