using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
namespace ED
{
    /// <summary>
    /// Summary description for EDws
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EDws : System.Web.Services.WebService
    {
        
        [WebMethod]
        public System.Data.DataSet KurumlariGetir(string il)
        {
            DataSet ds = new DataSet();
            string sorgu = "SELECT adi FROM Kurum WHERE il LIKE '" + il + "'";
            SqlCommand sqlkomutu2 = new SqlCommand(sorgu, Varliklar.Baglanti.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sqlkomutu2);
            da.Fill(ds);

            return ds;

        }
        [WebMethod]
        public System.Data.DataSet DilekceGetir(string id)
        {
            int id2 = Convert.ToInt32(id);
            DataSet ds = new DataSet();
            string sorgu = "SELECT * FROM Dilekce WHERE id LIKE '" + id2 + "'";
            SqlCommand sqlkomutu2 = new SqlCommand(sorgu, Varliklar.Baglanti.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sqlkomutu2);
            da.Fill(ds);

            return ds;

        }
        [WebMethod]
        public System.Data.DataSet DilekceBul(string icerik)
        {
            DataSet ds = new DataSet();
            string sorgu = "SELECT * FROM Dilekce WHERE baslik LIKE '%" +icerik+ "%' ORDER BY Tarih";
            SqlCommand sqlkomutu2 = new SqlCommand(sorgu, Varliklar.Baglanti.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sqlkomutu2);
            da.Fill(ds);

            return ds;

        }
        [WebMethod]
        public string AndroidGorevliGiris(string TC_no, string sifre)
        {
            DataSet gorevli = new DataSet();
            string sorgu = "SELECT TC_no FROM Gorevli WHERE TC_no='" + TC_no + "' AND sifre='" + sifre + "'";
            SqlCommand sqlkomutu = new SqlCommand(sorgu, Varliklar.Baglanti.baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlkomutu);
            da2.Fill(gorevli);
            if (gorevli.Tables[0].Rows.Count == 0)
            {
                return "Giris Başarısız";
            }
            else return "Giris Başarılı";
        }
        [WebMethod]
        public string JSONGonderileriGetir(string kriter, string deger)
        {
            DataTable gonderiler = new DataTable();
            string sorgu = "SELECT * FROM Gonderi WHERE " + kriter + " LIKE '" + deger + "'";
            SqlCommand sqlkomutu = new SqlCommand(sorgu, Varliklar.Baglanti.baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlkomutu);
            da2.Fill(gonderiler);
            List<Varliklar.Gonderi> sonucgonderiler = new List<Varliklar.Gonderi>();
            foreach (DataRow rows in gonderiler.Rows)
            {
                sonucgonderiler.Add(new Varliklar.Gonderi { Id = Convert.ToInt32(rows["Id"].ToString()), Dilekce_id = Convert.ToInt32(rows["dilekce_id"].ToString()), Kurum_id = Convert.ToInt32(rows["kurum_id"].ToString()), Gonderen_tc_no = rows["gonderen_tc_no"].ToString(), Alici_tc_no = rows["alici_tc_no"].ToString(), Durum = rows["durum"].ToString(), Tarih = Convert.ToDateTime(rows["tarih"].ToString()) });
            }
            return JsonConvert.SerializeObject(sonucgonderiler);
        }
        [WebMethod]
        public string AndroidDilekceyiGetir(string deger)
        {
            DataSet gonderi = new DataSet();
            string sorgu = "SELECT dilekce_id FROM Gonderi WHERE Id LIKE '" + deger + "'";
            SqlCommand sqlkomutu = new SqlCommand(sorgu, Varliklar.Baglanti.baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlkomutu);
            da2.Fill(gonderi);
            DataRow satir = gonderi.Tables[0].Rows[0];
            string dilekce_id = satir["dilekce_id"].ToString();

            DataTable gonderi2 = new DataTable();
            string sorgu2 = "SELECT baslik,sehir,konu,govde,tarih,g_adsoyad FROM Dilekce WHERE id LIKE '" + dilekce_id + "'";
            SqlCommand sqlkomutu2 = new SqlCommand(sorgu2, Varliklar.Baglanti.baglanti);
            SqlDataAdapter da22 = new SqlDataAdapter(sqlkomutu2);
            da22.Fill(gonderi2);
            List<Varliklar.Dilekce2> sonucgonderi = new List<Varliklar.Dilekce2>();
            foreach (DataRow dilekcem in gonderi2.Rows)
            {
                sonucgonderi.Add(new Varliklar.Dilekce2 { Baslik = dilekcem["baslik"].ToString(), Sehir = dilekcem["sehir"].ToString(), Konu = dilekcem["konu"].ToString(), Govde = dilekcem["govde"].ToString(), Tarih = dilekcem["tarih"].ToString(), G_adsoyad = dilekcem["g_adsoyad"].ToString() });
            }
            return JsonConvert.SerializeObject(sonucgonderi);
        }
        [WebMethod]
        public System.Data.DataSet IlceleriCek(string il)
        {
            DataSet ilceler = new DataSet();

            DataSet il_id = new DataSet();
            string ilkodubul = "SELECT id FROM muh_iller WHERE baslik LIKE '" + il + "'";
            SqlCommand sqlkomutu2 = new SqlCommand(ilkodubul,Varliklar.Baglanti.baglanti2);


            Varliklar.Baglanti.baglanti2.Open();

            SqlDataAdapter da2 = new SqlDataAdapter(sqlkomutu2);
            da2.Fill(il_id);

            DataRow ilid = il_id.Tables[0].Rows[0];

            string sorgu = "SELECT baslik FROM muh_ilceler WHERE il_id=" + ilid["id"].ToString();
            SqlCommand sqlkomutu = new SqlCommand(sorgu, Varliklar.Baglanti.baglanti2);

            SqlDataAdapter da = new SqlDataAdapter(sqlkomutu);
            da.Fill(ilceler);

            Varliklar.Baglanti.baglanti2.Close();

            return ilceler;
        }
        [WebMethod]
        public string KurumEkle(Varliklar.Kurum kurum)
        {
            string sorgu = "INSERT INTO Kurum (adi,adres,sifre,ilce,il,mail) VALUES (@adi,@adres,@sifre,@ilce,@il,@mail)";

            SqlCommand sqlkomutu = new SqlCommand(sorgu, Varliklar.Baglanti.baglanti);
            sqlkomutu.Parameters.AddWithValue("@adi", kurum.Adi);
            sqlkomutu.Parameters.AddWithValue("@adres", kurum.Adres);
            sqlkomutu.Parameters.AddWithValue("@sifre", kurum.Sifre);
            sqlkomutu.Parameters.AddWithValue("@ilce", kurum.Ilce);
            sqlkomutu.Parameters.AddWithValue("@il", kurum.Il);
            sqlkomutu.Parameters.AddWithValue("@mail", kurum.Mail);

            Varliklar.Baglanti.baglanti.Open();
            sqlkomutu.ExecuteNonQuery();
            Varliklar.Baglanti.baglanti.Close();

            return "Kurum Eklendi !";
        }
        [WebMethod]
        public string DilekceEkle(Varliklar.Dilekce dilekce,string G_TC_NO)
        {
            DataSet dilekceDS = new DataSet();
            DataSet kurumDS = new DataSet();
            string sorgu = "INSERT INTO Dilekce (baslik, sehir, konu, govde, tarih, g_adsoyad, g_mevki) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7); SELECT SCOPE_IDENTITY() AS id";
            string sorgu2 = "INSERT INTO Gonderi (dilekce_id, kurum_id, gonderen_tc_no, durum, tarih, alici_tc_no) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)";
            string sorgu3 = "SELECT id FROM Kurum WHERE adi='"+dilekce.Baslik+"' AND  il='"+dilekce.Sehir+"'";

            SqlCommand sqlkomutu = new SqlCommand(sorgu, Varliklar.Baglanti.baglanti);
            SqlCommand sqlkomutu2 = new SqlCommand(sorgu2, Varliklar.Baglanti.baglanti);
            SqlCommand sqlkomutu3 = new SqlCommand(sorgu3, Varliklar.Baglanti.baglanti);

            sqlkomutu.Parameters.AddWithValue("@p1", dilekce.Baslik);
            sqlkomutu.Parameters.AddWithValue("@p2", dilekce.Sehir);
            sqlkomutu.Parameters.AddWithValue("@p3", dilekce.Konu);
            sqlkomutu.Parameters.AddWithValue("@p4", dilekce.Govde);
            sqlkomutu.Parameters.AddWithValue("@p5", dilekce.Tarih);
            sqlkomutu.Parameters.AddWithValue("@p6", dilekce.G_adsoyad);
            sqlkomutu.Parameters.AddWithValue("@p7", dilekce.G_mevki);

            
            SqlDataAdapter da2 = new SqlDataAdapter(sqlkomutu);
            da2.Fill(dilekceDS);
            SqlDataAdapter da3 = new SqlDataAdapter(sqlkomutu3);
            da3.Fill(kurumDS);

            DataRow dilekceid = dilekceDS.Tables[0].Rows[0];
            DataRow kurumid = kurumDS.Tables[0].Rows[0];

            sqlkomutu2.Parameters.AddWithValue("@p1", Convert.ToInt32(dilekceid["id"].ToString()));
            sqlkomutu2.Parameters.AddWithValue("@p2", Convert.ToInt32(kurumid["id"].ToString()));
            sqlkomutu2.Parameters.AddWithValue("@p3", G_TC_NO);
            sqlkomutu2.Parameters.AddWithValue("@p4", "Kuruma İletildi");
            sqlkomutu2.Parameters.AddWithValue("@p5",DateTime.Now);
            sqlkomutu2.Parameters.AddWithValue("@p6",00000000000);

            Varliklar.Baglanti.baglanti.Open();
            sqlkomutu2.ExecuteNonQuery();
            Varliklar.Baglanti.baglanti.Close();

            return "Dilekçe Eklendi !";
        }
        [WebMethod]
        public string GorevliEkle(Varliklar.Gorevli gorevli)
        {
            string sorgu = "INSERT INTO Gorevli (TC_no,kurum_id,rutbe,adi,soyadi,sifre) VALUES (@p1,@p2,@p3,@p4,@p4,@p5,@p6)";

            SqlCommand sqlkomutu = new SqlCommand(sorgu, Varliklar.Baglanti.baglanti);

            sqlkomutu.Parameters.AddWithValue("@p1", gorevli.Tc_no1);
            sqlkomutu.Parameters.AddWithValue("@p2", gorevli.Kurum_id);
            sqlkomutu.Parameters.AddWithValue("@p3", gorevli.Rutbe);
            sqlkomutu.Parameters.AddWithValue("@p4", gorevli.Adi);
            sqlkomutu.Parameters.AddWithValue("@p5", gorevli.Soyadi);
            sqlkomutu.Parameters.AddWithValue("@p6", gorevli.Sifre);

            Varliklar.Baglanti.baglanti.Open();
            sqlkomutu.ExecuteNonQuery();
            Varliklar.Baglanti.baglanti.Close();

            return "Görevli Eklendi !";
        }
        [WebMethod]
        public string GonderiEkle(Varliklar.Gonderi gonderi)
        {
            string sorgu = "INSERT INTO Gonderi (dilekce_id,kurum_id,gonderen_tc_no,durum,tarih) VALUES (@p1,@p2,@p3,@p4,@p5)";

            SqlCommand sqlkomutu = new SqlCommand(sorgu, Varliklar.Baglanti.baglanti);

            sqlkomutu.Parameters.AddWithValue("@p1", gonderi.Dilekce_id);
            sqlkomutu.Parameters.AddWithValue("@p2", gonderi.Kurum_id);
            sqlkomutu.Parameters.AddWithValue("@p3", gonderi.Gonderen_tc_no);
            sqlkomutu.Parameters.AddWithValue("@p4", gonderi.Durum);
            sqlkomutu.Parameters.AddWithValue("@p5", gonderi.Tarih);

            Varliklar.Baglanti.baglanti.Open();
            sqlkomutu.ExecuteNonQuery();
            Varliklar.Baglanti.baglanti.Close();

            return "Gonderi Eklendi !";
        }
        [WebMethod]
        public DataSet KurumGiris(string mail, string sifre)
        {
            DataSet kurum = new DataSet();
            string sorgu = "SELECT id FROM Kurum WHERE mail='"+mail+"' AND sifre='"+sifre+"'";
            SqlCommand sqlkomutu = new SqlCommand(sorgu, Varliklar.Baglanti.baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlkomutu);          
            da2.Fill(kurum);
            return kurum;
        }
        [WebMethod]
        public DataSet GorevliGiris(string tc_no, string sifre)
        {
            DataSet gorevli = new DataSet();
            string sorgu = "SELECT TC_no FROM Gorevli WHERE TC_no='" + tc_no + "' AND sifre='" + sifre + "'";
            SqlCommand sqlkomutu = new SqlCommand(sorgu, Varliklar.Baglanti.baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlkomutu);
            da2.Fill(gorevli);
            return gorevli;
        }
        [WebMethod]
        public DataSet GorevliBilgileriniGetir(string TC)
        {
            DataSet gorevli = new DataSet();
            string sorgu = "SELECT kurum_id,rutbe,adi,soyadi  FROM Gorevli WHERE TC_no='" + TC + "'";
            SqlCommand sqlkomutu = new SqlCommand(sorgu, Varliklar.Baglanti.baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlkomutu);
            da2.Fill(gorevli);
            return gorevli;
        }
        [WebMethod]
        public DataSet KurumBilgileriniGetir(string id)
        {
            DataSet kurum = new DataSet();
            string sorgu = "SELECT adi  FROM Kurum WHERE id='" + id + "'";
            SqlCommand sqlkomutu = new SqlCommand(sorgu, Varliklar.Baglanti.baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlkomutu);
            da2.Fill(kurum);
            return kurum;
        }

        [WebMethod]
        public DataSet GonderileriGetir(string kriter, string deger)
        {
            DataSet gonderiler = new DataSet();
            string sorgu = "SELECT * FROM Gonderi WHERE " + kriter + "='" + deger + "'";
            SqlCommand sqlkomutu = new SqlCommand(sorgu, Varliklar.Baglanti.baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlkomutu);
            da2.Fill(gonderiler);
            return gonderiler;
        }
        [WebMethod]
        public DataSet KurumGorevlileriniGetir(string kurumID)
        {
            DataSet gorevliler = new DataSet();
            string sorgu = "SELECT TC_no, adi+' '+soyadi AS Adi FROM Gorevli WHERE kurum_id=" + kurumID;
            SqlCommand sqlkomutu = new SqlCommand(sorgu, Varliklar.Baglanti.baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlkomutu);
            da2.Fill(gorevliler);
            return gorevliler;
        }
        [WebMethod]
        public DataSet GonderileriGetirKurum(string kriter, string deger)
        {
            DataSet gonderiler = new DataSet();
            string sorgu = "SELECT * FROM Gonderi WHERE " + kriter + "='" + deger + "' AND durum LIKE 'Kuruma İletildi' OR durum LIKE 'Kurum Tarafından Görüldü'";
            SqlCommand sqlkomutu = new SqlCommand(sorgu, Varliklar.Baglanti.baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(sqlkomutu);
            da2.Fill(gonderiler);
            return gonderiler;
        }
        [WebMethod]
        public void GonderiGuncelle(string kolon,string gonderiId,string durum)
        {
            string sorgu = "UPDATE Gonderi SET "+kolon+"=@p2 WHERE Id=@p1 ";

            SqlCommand sqlkomutu = new SqlCommand(sorgu, Varliklar.Baglanti.baglanti);
            sqlkomutu.Parameters.AddWithValue("@p1", gonderiId);
            sqlkomutu.Parameters.AddWithValue("@p2", durum);

            Varliklar.Baglanti.baglanti.Open();
            sqlkomutu.ExecuteNonQuery();
            Varliklar.Baglanti.baglanti.Close();
        }
    }
}