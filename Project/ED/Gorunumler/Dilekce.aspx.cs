using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ED.Gorunumler
{
    public partial class Dilekce : System.Web.UI.Page
    {
        EDservisReferans.EDwsSoapClient ws = new EDservisReferans.EDwsSoapClient();
        string kurumId = "kurumdegil";
        string gorevliId = "gorevlidegil";
        string gonderiId = null;
        string gorevlidenGelenTc;
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                kurumId = Session["kurumId"].ToString();
                gonderiId = Session["gonderiId"].ToString();
                gorevliId = Session["gorevliID"].ToString();
                gorevlidenGelenTc = Session["gorevliTC"].ToString();
            }
            catch {

            }
                      
            string a= Session["dilekceId"].ToString();
            DataSet ds= ws.DilekceGetir(a);
            DataRow dr = ds.Tables[0].Rows[0];
            Baslik.Text = dr["baslik"].ToString();
            Sehir.Text = dr["sehir"].ToString();
            Konu.Text = dr["konu"].ToString();
            Govde.Text = dr["govde"].ToString();
            Tarih.Text = dr["tarih"].ToString();
            GAdSoyad.Text = dr["g_adsoyad"].ToString();

            if (kurumId.Equals("kurumdegil")) {
                Button2.Visible = false;
                Button2.Enabled = false;
            }
            
        }
        

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button1.Visible = true;
            Button1.Enabled = true;

            DropDownList1.Visible = true;
            DropDownList1.Enabled = true;

            DropDownList1.DataValueField = "TC_no";
            DropDownList1.DataTextField = "Adi";
            DropDownList1.DataSource =ws.KurumGorevlileriniGetir(kurumId);
            DropDownList1.DataBind();

            Button2.Visible = false;
            Button2.Enabled = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {   if (DropDownList1.SelectedValue.ToString()=="")
                Label1.Text = "Kurumda Yetkili Kişi Yok !";
            else {
                ws.GonderiGuncelle("alici_tc_no", gonderiId, DropDownList1.SelectedValue.ToString());
                ws.GonderiGuncelle("durum", gonderiId, "İlgili Kişiye İletildi");
                Label1.Text = "Yönlendirildi !";
            }
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}