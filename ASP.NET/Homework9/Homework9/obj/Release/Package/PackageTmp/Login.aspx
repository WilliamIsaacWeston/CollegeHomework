<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Homework9.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log-In - Club Information System</title>
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
        <div style="text-align: center; border-style: solid; border-width: 1px; padding: -15px">
            <h2 class="auto-style1">Log-In</h2>
            <p class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Username: " height="22px" style="bottom: 0px; position: relative"></asp:Label>
                <asp:TextBox ID="TextBoxUsername" runat="server" BorderStyle="Solid" BorderWidth="1px" Height="20px"></asp:TextBox>
            </p>
            <p class="auto-style1">
                <asp:Label ID="LabelPassword" runat="server" Text="Password: " height="22px" style="bottom: 0px; position: relative"></asp:Label>
                <asp:TextBox ID="TextBoxPassword" TextMode="Password" runat="server" BorderStyle="Solid" BorderWidth="1px" Height="20px"></asp:TextBox>
            </p>
            <p class="auto-style1">
                <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" BorderStyle="Solid" BackColor="#CCCCCC" Font-Bold="True" Height="30px" Width="85px" />
            </p>
            <p style="text-align: center">
                <asp:Label ID="LabelMsg" runat="server" ForeColor="Red"></asp:Label>
            </p>
        </div>
    </div>
    </form>
</body>
</html>
