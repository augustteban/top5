using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayAddresses();
        }
    }
    void DisplayAddresses()
    {
        ClassLibrary.clsOrderCollection Addresses = new ClassLibrary.clsOrderCollection();

        lstAddresses.DataSource = Addresses.AddressList;

        lstAddresses.DataValueField = "OrderId";

        lstAddresses.DataTextField = "ShippingAddress";

        lstAddresses.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
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

    protected void btnDelete_Click(object sender, EventArgs e)
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
            Response.Redirect("DeleteOrder.aspx");
        }
        else // if no record has been selected
        {

            // display an error
            lblError.Text = "Please select a reocrd to delete from the list";
        }

    }
}