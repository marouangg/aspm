<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication4.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Test des variable sesion</h1>
    <table class="auto-style6">
        <tr>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox1" runat="server" Width="275px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server"  Text="Button" Width="267px" OnClick="Button1_Click"  />
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                <asp:Button ID="Button2" runat="server"  Text="Button" Width="267px" OnClick="Button2_Click"  />
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Button ID="Button3" runat="server"  Text="Supprimer" Width="267px"  />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
