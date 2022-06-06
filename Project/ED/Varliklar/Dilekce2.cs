using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ED.Varliklar
{
       [Serializable]
        public class Dilekce2
        {
            string baslik;
            string sehir;
            string konu;
            string govde;
            string tarih;
            string g_adsoyad;
            string g_mevki;

            public Dilekce2()
            { }

            public Dilekce2(string text1, string selectedValue1, string text2, string text3, string v, string text4, string selectedValue2)
            {
                this.Baslik = text1;
                this.Sehir = selectedValue1;
                this.Konu = text2;
                this.Govde = text3;
                this.Tarih = v;
                this.G_adsoyad = text4;
                this.G_mevki = selectedValue2;
            }

            public string Baslik
            {
                get
                {
                    return baslik;
                }

                set
                {
                    baslik = value;
                }
            }

            public string Sehir
            {
                get
                {
                    return sehir;
                }

                set
                {
                    sehir = value;
                }
            }

            public string Konu
            {
                get
                {
                    return konu;
                }

                set
                {
                    konu = value;
                }
            }

            public string Govde
            {
                get
                {
                    return govde;
                }

                set
                {
                    govde = value;
                }
            }

            public string Tarih
            {
                get
                {
                    return tarih;
                }

                set
                {
                    tarih = value;
                }
            }

            public string G_adsoyad
            {
                get
                {
                    return g_adsoyad;
                }

                set
                {
                    g_adsoyad = value;
                }
            }

            public string G_mevki
            {
                get
                {
                    return g_mevki;
                }

                set
                {
                    g_mevki = value;
                }
            }
        }
    }