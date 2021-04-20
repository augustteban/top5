<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>
<script runat="server">

    protected void btn_Click(object sender, EventArgs e)
    {
        Session["OrderId"] = -1;
        Response.Redirect("AnOrder.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // var to store the primary key value of the record to be edited
        Int32 OrderId;

        // if a record has been selected from the list 
        if (lstOrderList.SelectedIndex != -1)
        {
            // get the primary key value of the record to edit 
            OrderId = Convert.ToInt32(lstOrderList.SelectedIndex);

            // store the data in the session object
            Session["OrderId"] = OrderId;

            // redirect to the edit page
            Response.Redirect("AnOrder.aspx");
        }
        else // if no record has been selected
        {

            // display an error
            lblError.Text = "Please select a reocrd to delete from the list";
        }

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
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
