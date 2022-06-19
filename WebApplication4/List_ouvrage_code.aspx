<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List_ouvrage_code.aspx.cs" Inherits="WebApplication4.List_ouvrage_code" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        table{
            border:1px solid ;
            border-collapse:collapse;
        }
        tr td{
            border:2px solid;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="mydiv" runat="server">
    

        <asp:TextBox ID="txt_find" runat="server"></asp:TextBox>
        <asp:Button ID="btn_fid" runat="server" Text="Rechercher" OnClick="btn_fid_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" Height="291px" PageSize="25" Width="613px" CellPadding="4" ForeColor="#333333" GridLines="None" OnDataBound="GridView1_DataBound" OnRowDeleting="GridView1_RowDeleting" AutoGenerateSelectButton="True" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                <asp:CommandField ButtonType="Button" ShowEditButton="True" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    
    </div>
       
        <p>
    

        <asp:TextBox ID="txt_idmarq" runat="server"></asp:TextBox>
        </p>
        <p>
    

        <asp:TextBox ID="txt_lib" runat="server"></asp:TextBox>
            </p>
        <p>
        <asp:Button ID="btn_update" runat="server" Text="Modifier" OnClick="btn_update_Click" />
        </p>
       
    </form>
</body>
</html>
