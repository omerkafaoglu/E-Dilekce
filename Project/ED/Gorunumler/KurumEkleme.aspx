<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KurumEkleme.aspx.cs" Inherits="ED.KurumEkleme" %>

<!DOCTYPE html>
<script runat="server">
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 58px;
        }
        .auto-style3 {
            width: 58px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
            width: 164px;
        }
        .auto-style5 {
            width: 58px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
            width: 164px;
        }
        .auto-style7 {
            width: 165px;
        }
        .auto-style8 {
            height: 23px;
            width: 165px;
        }
        .auto-style9 {
            height: 26px;
            width: 165px;
        }
        .auto-style10 {
            width: 164px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Kurum Adı :"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style10">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    Adres:</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Şehir :"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="Iller" DataTextField="baslik" DataValueField="baslik" OnSelectedIndexChanged="ttt_SelectedIndexChanged" AutoPostBack="true" />
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="Iller" runat="server" ConnectionString="<%$ ConnectionStrings:IllerIlcelerConnectionString %>" SelectCommand="SELECT [baslik] FROM [muh_iller]"></asp:SqlDataSource>
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label3" runat="server" Text="İlçe :"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:DropDownList ID="DropDownList2" runat="server" Width="178px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Mail :"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style10">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label5" runat="server" Text="Şifre :"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style7">
                    <asp:Button ID="Eklebtn" runat="server" OnClick="Eklebtn_Click" Text="Ekle" />
                </td>
                <td class="auto-style10">
                    <asp:Label ID="Label6" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>