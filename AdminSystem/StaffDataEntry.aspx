<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

    </form>
</body>
<form id="form1" runat="server">
    <asp:Label ID="lblStaffID" runat="server" Text="Staff ID"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" Width="213px"></asp:TextBox>
    <br />
    <asp:Label ID="lblStaffName" runat="server" Text="Staff Name"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblJobRole" runat="server" Text="Job Role"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblDateAdded" runat="server" Text="Date Added"></asp:Label>
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <br />
    <asp:Label ID="lblIsManager" runat="server" Text="Manager?"></asp:Label>
&nbsp;<asp:CheckBox ID="CheckBox1" runat="server" />
    <br />
    <asp:Label ID="lblError" runat="server"></asp:Label>
    <br />
    <asp:Button ID="bntOK" runat="server" OnClick="bntOK_Click" Text="OK" />
    <asp:Button ID="btnCancel" runat="server" style="margin-left: 35px" Text="Cancel" />
</form>
</html>
