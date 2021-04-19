<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<script runat="server">

    protected void btn_Click(object sender, EventArgs e)
    {
        Session["OrderId"] = -1;
        Response.Redirect("AnOrder.aspx");
    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server" Height="382px" Width="517px"></asp:ListBox>
            <br />
            <asp:Button ID="btn" runat="server" OnClick="btn_Click" Text="Add" />
        </div>
    </form>
</body>
</html>
