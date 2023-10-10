using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Okul_veritabani_uygulamasi
{
    public class Notlar
    {
        public Notlar()
        {
        }

        public Notlar(Ogrenciler og_no, Dersler ders_no, byte yaz1, byte yaz2, byte perf, int id)
        {
            Og_no = og_no;
            Ders_no = ders_no;
            Yaz1 = yaz1;
            Yaz2 = yaz2;
            Perf = perf;
            this.id = id;
        }

        public Ogrenciler Og_no { get; set; }
        public Dersler Ders_no { get; set; }
        public byte Yaz1 { get; set; }
        public byte Yaz2 { get; set; }
        public byte Perf { get; set; }
        public int id { get; set; }

    }
}