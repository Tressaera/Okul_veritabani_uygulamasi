using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;
namespace Okul_veritabani_uygulamasi
{
    public partial class Ogrenci_kaydet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Ogrenciler yeni_ogr = new Ogrenciler()
            {
                 Og_no=Convert.ToInt32 (ogno_txt.Text),
                  Ad_soyad =ad_soyad_txt.Text ,
                  Dog_tar =Convert.ToDateTime (dog_tar_txt.Text),
                  Adres =adres_txt.Text
            };

         int sayi=   new Ogrenciler_dao().ogrenci_kaydet(yeni_ogr);
            if (sayi == 1) Interaction.MsgBox("kayıt başarılı");
            else Interaction.MsgBox("kayıt yapılamadı");
        }
    }
}