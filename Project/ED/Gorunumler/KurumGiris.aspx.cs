using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ED
{
    public partial class KurumGiris : System.Web.UI.Page
    {
        EDservisReferans.EDwsSoapClient ws = new EDservisReferans.EDwsSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           DataSet ds= ws.KurumGiris(TextBox1.Text,TextBox2.Text);
            try {
                DataRow dr = ds.Tables[0].Rows[0];
                Session.Add("kurum_id", dr["id"]);
                Response.Redirect("KurumSayfasi.aspx");
            }
            catch (Exception) {
                Label3.Text = "Hatalı Giriş! E-Mail Adresinizi ve Şifrenizi kontrol ediniz.";
            }

        }
     }
}
