<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication4.login" %>

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
            height: 111px;
        }
        .auto-style3 {
            width: 168px;
        }
        .auto-style4 {
            height: 111px;
            width: 168px;
        }
        .auto-style5 {
            width: 168px;
            height: 72px;
        }
        .auto-style6 {
            height: 72px;
        }
        .auto-style7 {
            position: absolute;
            top: 61px;
            left: 192px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 125px;
            left: 195px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 102px;
            left: 197px;
            z-index: 1;
            height: 22px;
            width: 76px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Login</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style7"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" CssClass="auto-style8" Display="Dynamic" ErrorMessage="champ vide" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" CssClass="auto-style9" Display="Dynamic" ErrorMessage="erroor" ForeColor="#CC3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Mot de passe</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Le mot de passe incorecte" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="connexion" Width="122px" />
                </td>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="garder my secion ouvert" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Label ID="lbl_error" runat="server" ForeColor="Red" Text="login ou mot de passe incorect" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
