using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ED.Varliklar
{
    public class Baglanti
    {
        public static string conn = "Data Source=OMERKAFAOGLU;Initial Catalog=ED;Persist Security Info=True;User ID=sa;Password=Omer.2014";
        public static SqlConnection baglanti = new SqlConnection(conn);

        public static string conn2 = "Data Source = OMERKAFAOGLU; Initial Catalog = IllerIlceler; Persist Security Info=True;User ID = sa;Password=Omer.2014";
        public static SqlConnection baglanti2 = new SqlConnection(conn2);


        
    }
}