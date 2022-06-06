<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dilekce.aspx.cs" Inherits="ED.Gorunumler.Dilekce" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>Dilekçe</title>
    <link href="../tasarim4.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <table width="100%">
        <tr>
            <td>
                <img id="logo1" src="../Images/logo.png" />
                
            </td>
            
        </tr>
    </table>

    <div id="anadiv"><br /><br /><br /><br /><br /><br />
        <asp:Label ID="Baslik" runat="server" Text="Baslik"></asp:Label><br /><br />
        <asp:Label ID="Sehir" runat="server" Text="Sehir"></asp:Label><br /><br /><br /><br />
        <b>Konu:</b><asp:Label ID="Konu" runat="server" Text="Konu"></asp:Label><br />
        <br /><br /><br />
        <asp:Label ID="Govde" runat="server" Text="Govde"></asp:Label><br />
        <asp:Label ID="Tarih" runat="server" Text="Tarih"></asp:Label><br />
        <asp:Label ID="GAdSoyad" runat="server" Text="GAdSoyad"></asp:Label>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Yönlendir" />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" Enabled="False" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Visible="False">
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Enabled="False" OnClick="Button1_Click" Text="Bu Dilekçeyi Yönlendir" Visible="False" />
&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
