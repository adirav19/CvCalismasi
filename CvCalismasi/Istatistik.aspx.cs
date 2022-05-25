using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvCalismasi
{
    public partial class Istatistik : System.Web.UI.Page
    {
        dbCVreEntities db = new dbCVreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TblYeteneklerim.Count().ToString();
            Label2.Text = db.TblIletisim.Count().ToString();
            Label3.Text = "" + Convert.ToInt32(db.TblYeteneklerim.Average(x => x.Derece));
            Label4.Text = db.TblYeteneklerim.Max(x => x.Derece).ToString();
           
        }
    }
}