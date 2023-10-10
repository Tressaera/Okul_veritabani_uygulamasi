using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Okul_veritabani_uygulamasi
{
    public class Dersler
    {
        public Dersler()
        {
        }

        public Dersler(int ders_no, string ders_adi)
        {
            Ders_no = ders_no;
            Ders_adi = ders_adi;
        }

        public int Ders_no { get; set; }
        public string  Ders_adi { get; set; }

    }
}