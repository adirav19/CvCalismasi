using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvCalismasi
{
    public partial class Iletisim : System.Web.UI.Page
    {
        dbCVreEntities db = new dbCVreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var mesajlar = db.TblIletisim.ToList();
            Repeater1.DataSource = mesajlar;
            Repeater1.DataBind();
        }
    }
}