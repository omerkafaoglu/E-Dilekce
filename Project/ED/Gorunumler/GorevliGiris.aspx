<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GorevliGiris.aspx.cs" Inherits="ED.Gorunumler.GorevliGiris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link href="../tasarim2.css" rel="stylesheet" />

    <title> Görevli Giriş Sayfası</title>
    <style type="text/css">
    </style>

</head>
<body id="gorevligiris">
    <a href="../AnaEkran.aspx"><img id="logo" src="../Images/logo.png" /></a>
    <form runat="server">
            <div id="container">
                     <table>
                         <tr>
                                    <p id="gorevli">GÖREVLİ GİRİŞİ</p>
                                 <b id="giris">T.C. Kimlik Numaranızı ve Şifrenizi kullanarak kimliğiniz doğrulandıktan sonra<br />işleminize kaldığınız yerden devam edebilirsiniz.</b>

                         </tr>
                         <tr>
                    <h1><asp:Label ID="Label1" runat="server" Text="TC Kimlik No :"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></h1>
                             </tr>
                         <tr>
                    <h1><asp:Label ID="Label2" runat="server" Text="Şifre :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></h1>
                         </tr>
                             
                             <tr>
                                 
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                             </tr>
                         
                    </table>
                
                                    <div id="div2">
                                     
                             <asp:Button CssClass="girisbuton2" ID="Button1" runat="server" ForeColor="Black" Text="GİRİŞ" OnClick="Button1_Click"/>
                                 </div>
            </div>



    
    </form>
    <div id="footer2">
    <table id="footable" width="100%">
        <tr>
                    <td align="center" bgcolor="dcdcdc" >
                        <p> <font size="2" face="Times-New Roman" color="363636"><b>E-Dilekçe © 2016 – 2017 - Kayseri</b></p>
                    </td>
                
            </tr>
    </table>
        </div>
    
</body>
    
</html>
