using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;


namespace CvCalismasi
{
    public partial class Default : System.Web.UI.Page
    {
        dbCVreEntities db = new dbCVreEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TblHakkimda.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = db.TblHakkimda.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = db.TblHakkimda.ToList();
            Repeater3.DataBind();
            Repeater4.DataSource = db.TblYeteneklerim.ToList();
            Repeater4.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TblIletisim t = new TblIletisim();
            t.ID = 1;
            t.Adsoyad = TextBox1.Text;
            t.Mail = TextBox2.Text;
            t.Konu = TextBox3.Text;
            t.Mesaj = TextBox4.Text;
            db.TblIletisim.Add(t);
            db.SaveChanges();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}