using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CvCalismasi
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        dbCVreEntities db = new dbCVreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);

            if (Page.IsPostBack == false)
            {
                var ytnk = db.TblYeteneklerim.Find(x);
                TextBox1.Text = ytnk.Yetenekler;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            var ytnk = db.TblYeteneklerim.Find(x);
            ytnk.Yetenekler = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}