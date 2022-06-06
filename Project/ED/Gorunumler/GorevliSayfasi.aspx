<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GorevliSayfasi.aspx.cs" Inherits="ED.Gorunumler.GorevliSayfasi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Görevli Sayfası</title>
    <link href="../tasarim3.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            left: 380px;
            top: 0px;
            width: 396px;
            height: 57px;
        }
        .auto-style2 {
            left: 81px;
            top: 0px;
            width: 720px;
        }
        </style>
    </head>
<body>
    <table width="100%">
        <tr>
            <td>
                <a href="../AnaEkran.aspx"><img id="logo1" src="../Images/logo.png" /></a>
                
            </td>
            <td>
                <a href="../AnaEkran.aspx" id="cikis">Çıkış</a>
            </td>
        </tr>
    </table>
    
    <form id="form1" runat="server">
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Dilekçe Oluştur</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Gelen Kutusu</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Gönderilen Dilekçeler</asp:LinkButton>
        
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Örn:Valilik"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Height="30px" Text="Dilekçe Örneği Bul" Width="188px" OnClick="Button1_Click" /><br />
        <asp:Label ID="Label10" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        
        <br />
        <br />
        <asp:MultiView ID="MultiView1" runat="server" OnActiveViewChanged="MultiView1_ActiveViewChanged">
            <asp:View ID="View1" runat="server" OnActivate="View1_Activate" OnDeactivate="View1_Deactivate">
        <div id="anadiv">
        
                    <table class="auto-style1">
            <tr>
                
                <td class="auto-style7">
                    <asp:Label ID="Label3" runat="server" Text="Şehir Seçiniz"></asp:Label><br />
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="Iller" DataTextField="baslik" DataValueField="baslik" Height="17px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="165px">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="Iller" runat="server" ConnectionString="<%$ ConnectionStrings:IllerIlcelerConnectionString2 %>" SelectCommand="SELECT [baslik] FROM [muh_iller]"></asp:SqlDataSource>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                
                <td class="auto-style7">
                    <asp:Label ID="Label2" runat="server" Text="Gönderilecek Kurumu Seçiniz"></asp:Label><br />
                    <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                
                <td class="auto-style8">
                    <asp:Label ID="Label4" runat="server" Text="Dilekçenin Konusunu Giriniz"></asp:Label><br />
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style1"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Dilekçenizi Yazınız"></asp:Label><br>
                    <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine" Height="439px" CssClass="auto-style2"></asp:TextBox>
                </td>
            </tr>
            <tr>
                
                <td class="auto-style9">
                    <asp:Label ID="Label6" runat="server" Text="Tarih Seçiniz"></asp:Label><br />
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                        <NextPrevStyle VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#808080" />
                        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                        <SelectorStyle BackColor="#CCCCCC" />
                        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <WeekendDayStyle BackColor="#FFFFCC" />
                    </asp:Calendar>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label7" runat="server" Text="Gönderen Ad-Soyad :"></asp:Label><asp:TextBox ID="TextBox5" runat="server" Enabled="False"></asp:TextBox>
                </td>
                
                
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label8" runat="server" Text="Mevki :"></asp:Label><asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
                        <asp:ListItem>arz ederim</asp:ListItem>
                        <asp:ListItem>rica ederim</asp:ListItem>
                    </asp:DropDownList>
                </td>
                
                
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server"></asp:Label><asp:Button ID="Button2" runat="server" Text="EKLE" OnClick="Button2_Click" />
                </td>
                
               
            </tr>
        </table>
                </div>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:GridView ID="GridView1" runat="server" Width="100%" HorizontalAlign="Left" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowSorting="True" AutoGenerateSelectButton="True" DataKeyNames="id" AutoGenerateColumns="True" OnRowDataBound="GridView1_RowDataBound1">
                </asp:GridView>
            </asp:View>
        </asp:MultiView>
            
    </form>
        
</body>
</html>
