<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ogrenci_listele.aspx.cs" Inherits="Okul_veritabani_uygulamasi.Ogrenci_listele" %>
<%@ import Namespace="Okul_veritabani_uygulamasi"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <% List<Ogrenciler> ogrenci_listem = new Ogrenciler_dao().tum_ogrenciler();%>
        <table class="table table-striped">
            <tr>
                <td>Okul no</td>   
                <td>Ad Soyadı</td>  
                <td>Doğum Tarihi</td> 
                <td>adres</td>
            </tr>
            <% foreach(Ogrenciler gelen_ogr  in ogrenci_listem)
                {
             %>
           <tr>
               <td><%Response.Write(gelen_ogr.Og_no);%></td>
               <td><%Response.Write(gelen_ogr.Ad_soyad);%></td>
               <td><%=gelen_ogr.Dog_tar.ToShortDateString() %></td>
               <td><%=gelen_ogr.Adres %></td>
               <td><a href="ogrenci_sil.aspx?og_no=<%=gelen_ogr.Og_no %>" class="btn btn-danger">SİL</a></td>
               <td><a href="ogrenci_duzenle.aspx?og_no=<%=gelen_ogr.Og_no  %>" class="btn btn-success">DÜZENLE</a></td>
           </tr>
            
            <%   
               }
            %>
        </table>
        
        
        </div>
    </form>
    <script src="js/bootstrap.bundle.min.js"></script>
</body>
</html>