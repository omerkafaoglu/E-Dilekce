using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ED
{
    public partial class KurumEkleme : System.Web.UI.Page
    {
        EDservisReferans.EDwsSoapClient ws = new EDservisReferans.EDwsSoapClient();

        protected void Eklebtn_Click(object sender, EventArgs e)
        {
            EDservisReferans.Kurum kurum = new EDservisReferans.Kurum();
            kurum.Adi = TextBox1.Text;
            kurum.Adres = TextBox4.Text;
            kurum.Il = DropDownList1.SelectedValue;
            kurum.Ilce = DropDownList2.SelectedValue;
            kurum.Mail = TextBox2.Text;
            kurum.Sifre = TextBox4.Text;

            //string durum = ws.KurumEkle2(TextBox1.Text, TextBox4.Text, TextBox3.Text, DropDownList2.SelectedItem.Text, DropDownList1.SelectedItem.Text, TextBox2.Text);

            string durum2 = ws.KurumEkle(kurum);

            Label6.Text = durum2;
        }

        protected void ttt_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.DataSource = ws.IlceleriCek(DropDownList1.SelectedValue);
            DropDownList2.DataTextField = "baslik";
            DropDownList2.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
           // DropDownList1.Items[0].Selected = true;
        }
    }
}