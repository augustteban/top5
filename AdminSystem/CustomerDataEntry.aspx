<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID" width="205px"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <br />
        <asp:Label ID="lblName" runat="server" Text="Full Name" width="205px"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblEmailAddress" runat="server" Text="Email" width="205px"></asp:Label>
        <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address" width="205px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="Password" width="205px"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblLoyaltyPoints" runat="server" Text="Loyalty Points" width="205px"></asp:Label>
        <asp:TextBox ID="txtLoyaltyPoints" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCreatedAt" runat="server" Text="Date Created" width="205px"></asp:Label>
        <asp:TextBox ID="txtCreatedAt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkIsEmailConfirmed" runat="server" Text="Email Confirmed" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <br />
    </form>
</body>
</html>
