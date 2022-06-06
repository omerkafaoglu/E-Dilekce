using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ED.Gorunumler
{
    public partial class GorevliSayfasi : System.Web.UI.Page
    {
        EDservisReferans.EDwsSoapClient ws = new EDservisReferans.EDwsSoapClient();
        DataSet gorevlibilgileri;
        DataRow dr;
        string G_TC_NO;
        protected void Page_Load(object sender, EventArgs e)
        {
             
             G_TC_NO = Session["gorevliTC"].ToString();
             gorevlibilgileri = ws.GorevliBilgileriniGetir(G_TC_NO);
             dr = gorevlibilgileri.Tables[0].Rows[0];
             TextBox5.Text = dr["adi"] + " " + dr["soyadi"];
            // MultiView1.ActiveViewIndex = 0;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
            //Label1.Text=null;
            GridView1.DataSource = ws.GonderileriGetir("alici_tc_no", G_TC_NO);
            GridView1.DataBind();

        }

        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Equals("")) {
                Label10.Text = "Aramak için bir kelime girin !";
            } else {
                MultiView1.ActiveViewIndex = 1;
                Label10.Text = null;
                GridView1.DataSource = ws.DilekceBul(TextBox1.Text);
                GridView1.DataBind();
                    }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Add("DilekceID", GridView1.SelectedDataKey.Value.ToString());
            Session.Add("GorevliID",G_TC_NO);
            Session.Add("gorevliTC", G_TC_NO);
            /*ws.GonderiGuncelle("durum", GridView1.SelectedRow.Cells[1].Text.ToString(),"İlgili Kişi Tarafından Görüldü");*/
            Response.Redirect("Dilekce.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList3.DataSource = ws.KurumlariGetir(DropDownList1.SelectedValue);
            DropDownList3.DataTextField = "adi";
            DropDownList3.DataBind();
        }

        protected void View1_Activate(object sender, EventArgs e)
        {
           // DropDownList1.Items[0].Selected = true;
           // DropDownList2.Items[0].Selected = true;
        }

        protected void View1_Deactivate(object sender, EventArgs e)
        {
            DropDownList1.ClearSelection();
            DropDownList2.ClearSelection();
            DropDownList3.ClearSelection();
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            
            MultiView1.ActiveViewIndex = 1;
            //Label1.Text=null;
            GridView1.DataSource = ws.GonderileriGetir("gonderen_tc_no", G_TC_NO);
            GridView1.DataBind();
            
        }

        protected void GridView1_RowDataBound1(object sender, GridViewRowEventArgs e)
        {
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            EDservisReferans.Dilekce dilekce = new EDservisReferans.Dilekce();

            dilekce.Baslik =DropDownList3.SelectedValue;
            dilekce.Govde =TextBox4.Text +" "+ DropDownList2.SelectedValue;
            dilekce.G_adsoyad =TextBox5.Text;
            dilekce.G_mevki =DropDownList2.SelectedValue;
            dilekce.Konu =TextBox3.Text;
            dilekce.Sehir =DropDownList1.SelectedValue;
            dilekce.Tarih =Calendar1.SelectedDate;

            string durum2 = ws.DilekceEkle(dilekce,G_TC_NO);

            Label9.Text = durum2;
            Button2.Visible = false;
        }
    }
}