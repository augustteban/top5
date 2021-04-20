<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLineList.aspx.cs" Inherits="OrderLineList" %>

<!DOCTYPE html>
<script runat="server">

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into the session objct to indicate this is a new record
        Session["OrderLineId"] = -1;
        Response.Redirect("AnOrderLine.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {

        // var to store the primary key value of the record to be edited
        Int32 OrderlineId;

        // if a record has been selected from the list 
        if (lstOrderLineList.SelectedIndex != -1)
        {
            // get the primary key value of the record to edit 
            OrderlineId = Convert.ToInt32(lstOrderLineList.SelectedIndex);

            // store the data in the session object
            Session["OrderLineId"] = OrderlineId;

            // redirect to the edit page
            Response.Redirect("AnOrderLine.aspx");
        }
        else // if no record has been selected
        {

            // display an error
            lblError.Text = "Please select a reocrd to delete from the list";
        }

    }

    protected void lstOrderLineList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderLineList" runat="server" Height="457px" Width="570px" OnSelectedIndexChanged="lstOrderLineList_SelectedIndexChanged"></asp:ListBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            &nbsp;<asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
&nbsp;<asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
