using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CvCalismasi
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        dbCVreEntities db = new dbCVreEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TblAdmin
                        where x.Kullaniciadi == TextBox1.Text
  && x.Sifre == TextBox2.Text
                        select x;
            if (sorgu.Any())
            {
                Response.Redirect("Iletisim.aspx");
            }
            else
            {
                Response.Write("Hatalı kullanıcı adı yada şifre");
            }
        }
    }
}