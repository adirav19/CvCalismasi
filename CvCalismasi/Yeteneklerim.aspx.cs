using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvCalismasi
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dbCVreEntities db = new dbCVreEntities();
            Repeater1.DataSource = db.TblYeteneklerim.ToList();
            Repeater1.DataBind();

        }
    }
}