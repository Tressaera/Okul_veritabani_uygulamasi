using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
namespace Okul_veritabani_uygulamasi
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Dersler> ders_listesi = new Dersler_dao().tum_dersleri_getir();
            foreach ( Dersler gelen_Ders    in ders_listesi)
            {
                DropDownList1.Items.Add(gelen_Ders.Ders_adi);
            }
        }
    }
}