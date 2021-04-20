using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestingOrder;

public partial class AnOrder : System.Web.UI.Page
{
    // variable to store the primary key with page level scope
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the address to be processed
        OrderId = Convert.ToInt32(Session["OrderLineId"]);
        if (IsPostBack == false)
        {
            // if this address is not new reocord 
            if (OrderId != -1)
            {
                // display the current data for the record 
                DisplayAddress();
            }

            // create an instance
            clsOrder AnOrder = new clsOrder();

            // get the data from session object
            AnOrder = (clsOrder)Session["AnOrder"];



            Response.Write(AnOrder.OrderId);
            Response.Write(AnOrder.CustomerId);
            Response.Write(AnOrder.ShippingAddress);
            Response.Write(AnOrder.ShippingDate);
            Response.Write(AnOrder.Payment);
            Response.Write(AnOrder.TotalPrice);
        }
    }

    private void DisplayAddress()
    {
        clsOrderCollection AddressBook = new clsOrderCollection();

        // find the record to update
        AddressBook.ThisAddress.Find(OrderId);

        // display the data for this record
        txtOrderId.Text = AddressBook.ThisAddress.OrderId.ToString();
        txtCustomerId.Text = AddressBook.ThisAddress.CustomerId.ToString();
        txtShippingAddress.Text = AddressBook.ThisAddress.ShippingAddress.ToString();
        txtShippingDate.Text = AddressBook.ThisAddress.ShippingDate.ToString();
        txtPayment.Text = AddressBook.ThisAddress.Payment.ToString();
        txtTotalPrice.Text = AddressBook.ThisAddress.TotalPrice.ToString();
        chkActive.Checked = AddressBook.ThisAddress.Active;
    }
}

