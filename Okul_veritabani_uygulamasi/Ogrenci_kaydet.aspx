<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ogrenci_kaydet.aspx.cs" Inherits="Okul_veritabani_uygulamasi.Ogrenci_kaydet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            display: block;
            font-size: 1rem;
            font-weight: 400;
            line-height: 1.5;
            color: var(--bs-body-color);
            -webkit-appearance: none;
            -moz-appearance: none;
            appearance: none;
            background-clip: padding-box;
            border-radius: var(--bs-border-radius);
            transition: none;
            background-color: var(--bs-body-bg);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td>Öğrenci Numarası:</td>
                    <td>
                        <asp:TextBox ID="ogno_txt" runat="server" Width="207px"  CssClass="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Ad soyadı:</td>
                    <td>
                        <asp:TextBox ID="ad_soyad_txt" runat="server" Width="207px" CssClass="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Doğum Tarihi:</td>
                    <td>
                        <asp:TextBox ID="dog_tar_txt" runat="server"  Width="207px" CssClass="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Adres:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="adres_txt" runat="server" Height="109px" TextMode="MultiLine" Width="239px" CssClass="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="2">
                     <center> <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="Button1_Click" /></center>  
                    </td>
                </tr>
            </table>
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Ogrenci_listele.aspx">Tüm Öğrecileri Göster</asp:HyperLink>
    </form>
</body>
</html>
