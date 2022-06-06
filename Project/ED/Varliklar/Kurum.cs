using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ED.Varliklar
{
    [Serializable]
    public class Kurum
    {
        string adi;
        string adres;
        string sifre;
        string ilce;
        string il;
        string mail;

        public Kurum()
        {
            
        }
        public Kurum(string text1, string text2, string text3, string text4, string text5, string text6)
        {
            this.Adi = text1;
            this.Adres = text2;
            this.Sifre = text3;
            this.Ilce = text4;
            this.Il = text5;
            this.Mail = text6;
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

        public string Adres
        {
            get
            {
                return adres;
            }

            set
            {
                adres = value;
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

        public string Ilce
        {
            get
            {
                return ilce;
            }

            set
            {
                ilce = value;
            }
        }

        public string Il
        {
            get
            {
                return il;
            }

            set
            {
                il = value;
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }
    }
}