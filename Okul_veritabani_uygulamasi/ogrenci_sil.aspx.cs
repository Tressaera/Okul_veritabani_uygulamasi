using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Okul_veritabani_uygulamasi
{
    public partial class ogrenci_sil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          int og_no=Convert.ToInt32(Request.QueryString["og_no"]);
            new Ogrenciler_dao().ogrenci_sil(og_no);
            Response.Redirect("Ogrenci_listele.aspx");
        }
    }
}