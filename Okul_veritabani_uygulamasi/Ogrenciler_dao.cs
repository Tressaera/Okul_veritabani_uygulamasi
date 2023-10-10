using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections;
namespace Okul_veritabani_uygulamasi
{
    public class Ogrenciler_dao
    {
        public List<Ogrenciler> tum_ogrenciler()
        {
            List<Ogrenciler> ogrenci_listem = new List<Ogrenciler>();
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source = ntc; Initial Catalog = okul; Integrated Security = True";
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from ogrenciler order by ad_soyad asc";
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read() == true)
            {
                Ogrenciler ogrenci = new Ogrenciler()
                {
                    Og_no = Convert.ToInt32(oku["og_no"]),
                    Ad_soyad = oku["ad_soyad"].ToString(),
                    Adres = oku["adres"].ToString(),
                    Dog_tar = Convert.ToDateTime(oku["dog_tar"])
                };
                ogrenci_listem.Add(ogrenci);
            }
            oku.Close();
            baglanti.Close();
            return ogrenci_listem;
        }

        public void ogrenci_sil(int og_no)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source = ntc; Initial Catalog = okul; Integrated Security = True";
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "delete from ogrenciler where og_no=@og_no";
            komut.Parameters.AddWithValue("@og_no", og_no);
            komut.ExecuteNonQuery();//insert delete,update işleminde kullanılır

            baglanti.Close();
        }


        public int ogrenci_kaydet(Ogrenciler yeni_ogr)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source = ntc; Initial Catalog = okul; Integrated Security = True";
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "insert into ogrenciler (og_no,ad_soyad,dog_tar,adres) values (@og_no,@ad_soyad,@dog_tar,@adres)";
            komut.Parameters.AddWithValue("@og_no", yeni_ogr.Og_no); 
            komut.Parameters.AddWithValue("@ad_soyad", yeni_ogr.Ad_soyad); 
            komut.Parameters.AddWithValue("@dog_tar", yeni_ogr.Dog_tar);  
            komut.Parameters.AddWithValue("@adres", yeni_ogr.Adres);
            int sayi= komut.ExecuteNonQuery();
            baglanti.Close();
            return sayi;

        }
    }
}