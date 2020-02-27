<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transactions.aspx.cs" Inherits="Homework9.Transactions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Transactions - Club Information System</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: center;
            background-color: #CCCCCC;
        }
    </style>
</head>
<body style="background-color: #FFFFFF">
    <form id="form1" runat="server">
    <div>
        <h1 class="auto-style2">Club Information System</h1>
        <p style="float: left;" >
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Main.aspx" style="left: 5px; position: relative; bottom: 10px;">Main Menu</asp:HyperLink>
            </p>
            <p style="float: right; text-align: right; bottom: 10px; position: relative;">
                <asp:Label ID="LabelUser" runat="server" Text="Hello, "></asp:Label> <br />
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButtonLogOut_Click" style="right: 2px; position: relative">Log-out</asp:LinkButton>
            </p>
        <div style="text-align: center; border-style: solid; border-width: 1px; padding: -15px">
            <h2 class="auto-style1">Transactions</h2>
            <center>
                <asp:GridView ID="GridViewTransactions" runat="server">
                </asp:GridView>
            </center>
            <p>
                <asp:Label ID="LabelMsg" runat="server" ForeColor="Red"></asp:Label>
            </p>
        </div>
    </div>
    </form>
</body>
</html>