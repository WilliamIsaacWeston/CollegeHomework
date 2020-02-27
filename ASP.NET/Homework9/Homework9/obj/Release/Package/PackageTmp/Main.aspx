<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Homework9.Main" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Menu - Club Information System</title>
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
            <h2 class="auto-style1"><asp:Label ID="LabelHeader" runat="server" Text="'s Profile"></asp:Label></h2>
            <p style="float: right; bottom: 78px; position: relative; text-align: right;">
                <asp:Label ID="LabelUser" runat="server" Text="Hello, "></asp:Label> <br />
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButtonLogOut_Click" style="right: 2px; position: relative">Log-out</asp:LinkButton>
            </p>
            <p style="text-align: left; position: relative; float: left; bottom: 78px; left: 2px">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="ChangePassword.aspx" >Change Password</asp:HyperLink>
            </p>
            <div>
                <h3 style="left: 0px; position: relative; right: 20px">Personal Information</h3>
                    <center>
                <asp:Panel ID="Panel1" runat="server" Width="250" BoarderStyle="None" style="text-align: left" BorderStyle="None">
                <p>
                    <asp:Label ID="LabelFirstName1" runat="server" Text="First Name: " style="right: 20px"></asp:Label>
                    <asp:Label ID="LabelFirstName" runat="server" Text="First Name: " style="right: 20px; left: 50px; position: relative;"></asp:Label>
                </p>
                <p>
                    <asp:Label ID="LabelLastName1" runat="server" Text="Last Name: "></asp:Label>
                    <asp:Label ID="LabelLastName" runat="server" Text="Last Name: " style="left: 50px; position: relative"></asp:Label>
                </p>
                <p>
                    <asp:Label ID="LabelCellPhone1" runat="server" Text="Cell Phone: "></asp:Label>
                    <asp:Label ID="LabelCellPhone" runat="server" Text="Cell Phone: " style="left: 50px; position: relative"></asp:Label>
                </p>
                <p>
                    <asp:Label ID="LabelHomePhone1" runat="server" Text="Home Phone: "></asp:Label>
                    <asp:Label ID="LabelHomePhone" runat="server" Text="Home Phone: " style="left: 37px; position: relative"></asp:Label>
                </p>
                <p>
                    <asp:Label ID="LabelEmail1" runat="server" Text="Email: "></asp:Label>
                    <asp:Label ID="LabelEmail" runat="server" Text="Email: " style="left: 80px; position: relative"></asp:Label>
                </p>
                <p>
                    <asp:Label ID="LabelDOB1" runat="server" Text="Date of Birth: "></asp:Label>
                    <asp:Label ID="LabelDOB" runat="server" Text="Date of Birth: " style="left: 35px; position: relative"></asp:Label>
                </p>
                </asp:Panel></center>
                <h3>Mother's Information</h3>
                    <center>
                <asp:Panel ID="Panel2" runat="server" Width="250" BoarderStyle="None" style="text-align: left" BorderStyle="None">
                <p>
                    <asp:Label ID="LabelMomFName1" runat="server" Text="First Name: "></asp:Label>
                    <asp:Label ID="LabelMomFName" runat="server" Text="First Name: " style="left: 50px; position: relative"></asp:Label>
                </p>
                <p>
                    <asp:Label ID="LabelMomLName1" runat="server" Text="Last Name: "></asp:Label>
                    <asp:Label ID="LabelMomLName" runat="server" Text="Last Name: " style="left: 50px; position: relative"></asp:Label>
                </p>
                <p>
                    <asp:Label ID="LabelMomCell1" runat="server" Text="Cell Phone: "></asp:Label>
                    <asp:Label ID="LabelMomCell" runat="server" Text="Cell Phone: " style="left: 50px; position: relative"></asp:Label>
                </p>
                </asp:Panel></center>
                <h3>Father's Information</h3>
                    <center>
                <asp:Panel ID="Panel4" runat="server" Width="250" BoarderStyle="None" style="text-align: left" BorderStyle="None">
                <p>
                    <asp:Label ID="LabelDadFName1" runat="server" Text="First Name: "></asp:Label>
                    <asp:Label ID="LabelDadFName" runat="server" Text="First Name: " style="left: 50px; position: relative"></asp:Label>
                </p>
                <p>
                    <asp:Label ID="LabelDadLName1" runat="server" Text="Last Name: "></asp:Label>
                    <asp:Label ID="LabelDadLName" runat="server" Text="Last Name: " style="left: 50px; position: relative"></asp:Label>
                </p>
                <p>
                    <asp:Label ID="LabelDadCell1" runat="server" Text="Cell Phone: "></asp:Label>
                    <asp:Label ID="LabelDadCell" runat="server" Text="Cell Phone: " style="left: 50px; position: relative"></asp:Label>
                </p>
                </asp:Panel></center>
                <h3>Other</h3>
                    <center>
                <asp:Panel ID="Panel3" runat="server" Width="250" BoarderStyle="None" style="text-align: left" BorderStyle="None">
                <p>
                    <asp:Label ID="LabelUSATFnum1" runat="server" Text="USATF Number: " style="text-align: left"></asp:Label>
                    <asp:Label ID="LabelUSATFnum" runat="server" Text="USATF Number: " style="text-align: left; left: 10px; position: relative;"></asp:Label>
                </p>
                <p>
                    <asp:Label ID="LabelProof1" runat="server" Text="Proof of Insurance: "></asp:Label>
                    <asp:Label ID="LabelProof" runat="server" Text="Proof of Insurance: "></asp:Label>
                </p>
                <p>
                    <asp:Label ID="LabelBalance1" runat="server" Text="Balance Due: "></asp:Label>
                    <asp:Label ID="LabelBalance" runat="server" Text="Balance Due: " style="left: 35px; position: relative"></asp:Label>
                </p>
                </asp:Panel></center>
            </div>
            <p>
                <asp:Button ID="ButtonSubmit" runat="server" Text="View Transactions" BackColor="#CCCCCC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Height="30px" Width="125px" style="left: 0px; position: relative; left: -50px" OnClick="ButtonSubmit_Click" />
                <asp:Button ID="ButtonEdit" runat="server" Text="Edit" BackColor="#CCCCCC" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Height="30px" Width="85px" style="left: 50px; position: relative" OnClick="ButtonEdit_Click" />
            </p>
            <p>
                <asp:Label ID="LabelMsg" runat="server" ForeColor="Red"></asp:Label>
            </p>
        </div>
    </div>
    </form>
</body>
</html>
