using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Okul_veritabani_uygulamasi
{
    public class Ogrenciler
    {
        public Ogrenciler()
        {
        }

        public Ogrenciler(int og_no, string ad_soyad, DateTime dog_tar, string adres)
        {
            Og_no = og_no;
            Ad_soyad = ad_soyad;
            Dog_tar = dog_tar;
            Adres = adres;
        }

        public int Og_no { get; set; }
        public string Ad_soyad { get; set; }
        public DateTime Dog_tar { get; set; }
        public string Adres { get; set; }


    }
}