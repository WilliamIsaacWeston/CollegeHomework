<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="Homework9.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Change Password - Club Information System</title>
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
    <form id="form2" runat="server">
    <div>
        <h1 class="auto-style2">Club Information System</h1>
        <div style="text-align: center; border-style: solid; border-width: 1px; padding: -15px">
            <p style="float: left;" >
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Main.aspx" style="left: 5px; position: relative; bottom: 10px;">Main Menu</asp:HyperLink>
            </p>
            <p style="float: right; text-align: right; bottom: 10px; position: relative;">
                <asp:Label ID="LabelUser" runat="server" Text="Hello, "></asp:Label> <br />
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButtonLogOut_Click" style="right: 2px; position: relative">Log-out</asp:LinkButton>
            </p>
            <h2 class="auto-style1">Change Password</h2>
            <p>
            <asp:Label ID="Label1" runat="server" Text="Current Password: " style="position: relative; top: 0px; bottom: 4px; left: 51px;"></asp:Label>
            <asp:TextBox ID="TextBoxOld" TextMode="Password" runat="server" BorderStyle="Solid" BorderWidth="1px" style="left: 51px; position: relative"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="New Password:" style="bottom: 0px; position: relative; left: 11px;"></asp:Label>
            <asp:TextBox ID="TextBoxNew" TextMode="Password" runat="server" style="left: 10px; position: relative" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Confirm Password: " style="bottom: 0px; position: relative"></asp:Label>
            <asp:TextBox ID="TextBoxConfirm" TextMode="Password" runat="server" BorderStyle="Solid" BorderWidth="1px" style="right: 1px; position: relative"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" BackColor="#CCCCCC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Height="30px" Width="85px" />
        </p>
            <p>
            <asp:RequiredFieldValidator id="RequiredFieldValidator1" 
                runat="server" 
                ControlToValidate="TextBoxOld"  
                ErrorMessage="The Current Password field must contain a value"
                Display="Dynamic" style="position: relative"/>
            <asp:RequiredFieldValidator id="RequiredFieldValidator2" 
                runat="server" 
                ControlToValidate="TextBoxNew"  
                ErrorMessage="The New Password field must contain a value" 
                Display="Dynamic"/>
            <asp:RequiredFieldValidator id="RequiredFieldValidator3" 
                runat="server" 
                ControlToValidate="TextBoxConfirm"  
                ErrorMessage="The Confirm Password field must contain a value" 
                Display="Dynamic"/>
            <asp:CompareValidator id="CompareValidator1" runat="server"
                ControlToValidate="TextBoxConfirm"
                Operator="Equal"
                ErrorMessage="The New Password field must match the Confirm Password field"
                Type="String"
                ControlToCompare="TextBoxNew"
                Display="dynamic" />
            <asp:Label ID="LabelMsg" runat="server" ForeColor="Red"></asp:Label>

            </p>
        </div>
    </div>
    </form>
</body>
</html>