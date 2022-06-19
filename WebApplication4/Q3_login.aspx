<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Q3_login.aspx.cs" Inherits="WebApplication4.Q3_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 170px;
        }
        .auto-style3 {
            width: 170px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
            width: 462px;
        }
        .auto-style5 {
            width: 462px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Login</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Remeber me" />
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="202px" />
                </td>
            </tr>
        </table>
    
    </div>
        <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Blue" NavigateUrl="~/Q2.aspx">Singup</asp:HyperLink>
        <p>
            <asp:Label ID="Label1" runat="server" Text="login passwrod incorect" Visible="False"></asp:Label>
        </p>
    </form>
</body>
</html>
