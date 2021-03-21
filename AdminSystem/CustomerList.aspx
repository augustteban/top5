<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            width: 363px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomers" runat="server" Height="756px" Width="855px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <br />
        <br />
        Enter a name
         <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
    </form>
</body>
</html>
