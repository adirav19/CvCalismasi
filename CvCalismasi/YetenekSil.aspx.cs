using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvCalismasi
{
    public partial class YetenekSil : System.Web.UI.Page
    {
        dbCVreEntities db = new dbCVreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var ytnk = db.TblYeteneklerim.Find(x);
            db.TblYeteneklerim.Remove(ytnk);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.aspx");
        }
    }
}