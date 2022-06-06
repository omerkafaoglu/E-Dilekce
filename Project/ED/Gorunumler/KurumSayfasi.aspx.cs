using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ED.Gorunumler
{
    public partial class KurumSayfasi : System.Web.UI.Page
    {
        EDservisReferans.EDwsSoapClient ws = new EDservisReferans.EDwsSoapClient();
        int KurumID;
        protected void Page_Load(object sender, EventArgs e)
        {
            KurumID = Convert.ToInt32(Session["kurum_id"].ToString());
            GridView1.DataSource = ws.GonderileriGetirKurum("kurum_id",KurumID.ToString());
            GridView1.DataBind();
          
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        { 
            /*
            GridView1.Columns[1].Visible = false;
            GridView1.Columns[2].Visible = false;
            GridView1.Columns[3].Visible = false;
            GridView1.Columns[5].Visible = false;
            GridView1.Columns[7].Visible = false; */
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string gonderiNo=GridView1.SelectedRow.Cells[1].Text.ToString();
            Session.Add("dilekceId", GridView1.SelectedRow.Cells[2].Text.ToString());
            Session.Add("gonderiNo", gonderiNo);

            ws.GonderiGuncelle("durum",gonderiNo,"Kurum Tarafından Görüldü");
            Session.Add("kurumId", KurumID);
            Session.Add("gonderiId",gonderiNo);
            Response.Redirect("Dilekce.aspx");
        }
    }
}