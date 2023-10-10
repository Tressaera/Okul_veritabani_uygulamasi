using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;
namespace Okul_veritabani_uygulamasi
{
    public class Dersler_dao
    {
        public List<Dersler> tum_dersleri_getir()
        {
            List<Dersler> ders_listesi = new List<Dersler>();
            SqlConnection bag = new SqlConnection();//vt ye bağlantı nesnesi 
            bag.ConnectionString = "Data Source=ntc;Initial Catalog=okul;Integrated Security=True";
            bag.Open();
            SqlCommand komut = new SqlCommand();//sql cümleleri için
            komut.CommandText = "select * from dersler order by ders_adi asc";
            komut.Connection = bag;
           SqlDataReader oku= komut.ExecuteReader();//reader gelen kayıtları tutar
            while (oku.Read()==true)//sırayla gelen kayıtların sonuna kadar oku
            {
                Dersler ders = new Dersler()//her kaydı bir ders nesnesi haline getir
                {
                    Ders_no = Convert.ToInt32(oku["ders_no"]),
                     Ders_adi=oku["ders_adi"].ToString (),
                };
                ders_listesi.Add(ders);//dersi listeye ekle
            }
            oku.Close();
            bag.Close();
            return ders_listesi;
        }

    }
}