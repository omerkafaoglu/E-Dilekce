using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ED.Gorunumler
{
    public partial class GorevliGiris : System.Web.UI.Page
    {
        EDservisReferans.EDwsSoapClient ws = new EDservisReferans.EDwsSoapClient();

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = ws.GorevliGiris(TextBox1.Text, TextBox2.Text);
             try
             {
                 DataRow dr = ds.Tables[0].Rows[0];
                 Session.Add("gorevliTC", dr["TC_no"]);
                 Response.Redirect("GorevliSayfasi.aspx");
             }
             catch (Exception)
             {
                 Label3.Text = "Hatalı Giriş! TC Kimlik Numaranızı ve Şifrenizi kontrol ediniz.";
             }

         }
        
    }
    }
