using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ED.Varliklar
{
    [Serializable]
    public class Gorevli
    {
        string Tc_no;
        int kurum_id;
        string rutbe;
        string adi;
        string soyadi;
        string sifre;

        public string Tc_no1
        {
            get
            {
                return Tc_no;
            }

            set
            {
                Tc_no = value;
            }
        }

        public int Kurum_id
        {
            get
            {
                return kurum_id;
            }

            set
            {
                kurum_id = value;
            }
        }

        public string Rutbe
        {
            get
            {
                return rutbe;
            }

            set
            {
                rutbe = value;
            }
        }

        public string Adi
        {
            get
            {
                return adi;
            }

            set
            {
                adi = value;
            }
        }

        public string Soyadi
        {
            get
            {
                return soyadi;
            }

            set
            {
                soyadi = value;
            }
        }

        public string Sifre
        {
            get
            {
                return sifre;
            }

            set
            {
                sifre = value;
            }
        }

        public Gorevli() { }

        public Gorevli(string TC_no, int kurum_id, string rutbe, string adi, string soyadi, string sifre)
        {
            this.Tc_no1 = TC_no;
            this.Kurum_id = kurum_id;
            this.Rutbe = rutbe;
            this.Adi = adi;
            this.Soyadi = soyadi;
        }


    }
}