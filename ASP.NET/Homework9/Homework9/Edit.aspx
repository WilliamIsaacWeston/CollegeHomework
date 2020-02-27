<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Homework9.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit - Club Information System</title>
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
            <h2 class="auto-style1">Edit Profile</h2>
            <h3 style="left: 0px; position: relative; right: 20px">Personal Information</h3>
                <p>
                    <asp:Label ID="LabelFirstName" runat="server" Text="First Name: " style="right: 10px; position: relative;"></asp:Label>
                    <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="LabelLastName" runat="server" Text="Last Name: " style="right: 10px; position: relative"></asp:Label>
                    <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="LabelCellPhone" runat="server" Text="Cell Phone: " style="right: 10px; position: relative"></asp:Label>
                    <asp:TextBox ID="TextBoxCellPhone" runat="server"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="LabelHomePhone" runat="server" Text="Home Phone: " style="right: 5px; position: relative"></asp:Label>
                    <asp:TextBox ID="TextBoxHomePhone" runat="server" style="right: 5px; position: relative"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="LabelEmail" runat="server" Text="Email: " style="right: 27px; position: relative"></asp:Label>
                    <asp:TextBox ID="TextBoxEmail" runat="server" style="left: 18px; position: relative"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="LabelDOB" runat="server" Text="Date of Birth: " style="right: 5px; position: relative"></asp:Label>
                    <asp:TextBox ID="TextBoxDOB" runat="server" style="right: 5px; position: relative"></asp:TextBox>
                </p>
                <h3>Mother's Information</h3>
                <p>
                    <asp:Label ID="LabelMomFName" runat="server" Text="First Name: " style="right: 10px; position: relative"></asp:Label>
                    <asp:TextBox ID="TextBoxMomFName" runat="server"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="LabelMomLName" runat="server" Text="Last Name: " style="right: 10px; position: relative"></asp:Label>
                    <asp:TextBox ID="TextBoxMomLName" runat="server"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="LabelMomCell" runat="server" Text="Cell Phone: " style="right: 10px; position: relative"></asp:Label>
                    <asp:TextBox ID="TextBoxMomCell" runat="server"></asp:TextBox>
                </p>
                <h3>Father's Information</h3>
                <p>
                    <asp:Label ID="LabelDadFName" runat="server" Text="First Name: " style="right: 10px; position: relative"></asp:Label>
                    <asp:TextBox ID="TextBoxDadFName" runat="server"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="LabelDadLName" runat="server" Text="Last Name: " style="right: 10px; position: relative"></asp:Label>
                    <asp:TextBox ID="TextBoxDadLName" runat="server"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="LabelDadCell" runat="server" Text="Cell Phone: " style="right: 10px; position: relative"></asp:Label>
                    <asp:TextBox ID="TextBoxDadCell" runat="server"></asp:TextBox>
                </p>
                <h3>Other</h3>
                <p>
                    <asp:Label ID="LabelUSATFnum" runat="server" Text="USATF Number: " style="text-align: left; right: 15px; position: relative;"></asp:Label>
                    <asp:TextBox ID="TextBoxUSATFnum" runat="server" style="right: 17px; position: relative"></asp:TextBox>
                </p>
            <p class="auto-style1">
                <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" BorderStyle="Solid" BackColor="#CCCCCC" Font-Bold="True" Height="30px" Width="85px" />
            </p>
            <p>
                <asp:Label ID="LabelMsg" runat="server" ForeColor="Red"></asp:Label>
            </p>
        </div>
    </div>
    </form>
</body>
</html>
