using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ED.Varliklar
{
    [Serializable]
    public class Gonderi
    {
        int id;
        int dilekce_id;
        int kurum_id;
        string gonderen_tc_no;
        string alici_tc_no;
        string durum;
        DateTime tarih;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Dilekce_id
        {
            get
            {
                return dilekce_id;
            }

            set
            {
                dilekce_id = value;
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


        public string Durum
        {
            get
            {
                return durum;
            }

            set
            {
                durum = value;
            }
        }

        public DateTime Tarih
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

        public string Gonderen_tc_no
        {
            get
            {
                return gonderen_tc_no;
            }

            set
            {
                gonderen_tc_no = value;
            }
        }

        public string Alici_tc_no
        {
            get
            {
                return alici_tc_no;
            }

            set
            {
                alici_tc_no = value;
            }
        }

        public Gonderi() { }

        public Gonderi(int Id, int dilekce_id, int kurum_id, string gonderen_tc_no, string alici_tc_no, string durum, DateTime tarih)
        {
            this.Id = Id;
            this.Dilekce_id = dilekce_id;
            this.Kurum_id = kurum_id;
            this.gonderen_tc_no = gonderen_tc_no;
            this.alici_tc_no = alici_tc_no;
            this.Durum = durum;
            this.tarih = tarih;
        }


    }
}