<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KurumSayfasi.aspx.cs" Inherits="ED.Gorunumler.KurumSayfasi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kurum Sayfası</title>
    <link href="../tasarim3.css" rel="stylesheet" />
</head>
<body>
    <table>
        <tr>
            <td>
                <a href="../AnaEkran.aspx"><img id="logo1" src="../Images/logo.png" /></a>
            </td>
        </tr>
    </table>
    <form id="form1" runat="server">
    <div>
        <b id="yazi1">KURUMUNUZA GELEN TÜM DİLEKÇELER</b>
    
        <asp:GridView ID="GridView1" Width="100%" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateSelectButton="True">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
