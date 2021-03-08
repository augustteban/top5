<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderId" runat="server" Text="Order ID"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtOrderId" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerId" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblShippingAddress" runat="server" Text="Shipping Address"></asp:Label>
&nbsp;<asp:TextBox ID="txtShippingAddress" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblShippingDate" runat="server" Text="Shipping Date "></asp:Label>
            <asp:TextBox ID="txtShippingDate" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPayment" runat="server" Text="Payment"></asp:Label>
&nbsp;<asp:TextBox ID="txtPayment" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price"></asp:Label>
&nbsp;<asp:TextBox ID="txtTotalPrice" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <br />
        </div>
    </form>
</body>
</html>
