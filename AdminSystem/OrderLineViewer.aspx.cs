using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestingOrder;

public partial class AnOrderLine : System.Web.UI.Page
{
    // variable to store the primary key with page level scope
    Int32 OrderLineId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the address to be processed
        OrderLineId = Convert.ToInt32(Session["OrderLineId"]);
        if (IsPostBack == false)
        {
            // if this address is not new reocord 
            if (OrderLineId != -1)
            {
                // display the current data for the record 
                DisplayAddress();
            }
        }
        // create an instance
        clsOrderLine AnOrderLine = new clsOrderLine();

        // get the data from session object
        AnOrderLine = (clsOrderLine)Session["AnOrderLine"];


        Response.Write(AnOrderLine.OrderLineId);
        Response.Write(AnOrderLine.OrderId);
        Response.Write(AnOrderLine.ItemId);
        Response.Write(AnOrderLine.Quantity);
        Response.Write(AnOrderLine.Description);
        Response.Write(AnOrderLine.Price);

        
    }

     void DisplayAddress()
     {
        clsOrderLineCollection AddressBook = new clsOrderLineCollection();

        // find the record to update
        AddressBook.ThisAddress.Find(OrderLineId);

        // display the data for this record
        txtOrderLineId.Text = AddressBook.ThisAddress.OrderLineId.ToString();
        txtOrderId.Text = AddressBook.ThisAddress.OrderId.ToString();
        txtItemId.Text = AddressBook.ThisAddress.ItemId.ToString();
        txtQuantity.Text = AddressBook.ThisAddress.Quantity.ToString();
        txtDescription.Text = AddressBook.ThisAddress.Description.ToString();
        txtPrice.Text = AddressBook.ThisAddress.Price.ToString();
        chkActive.Checked = AddressBook.ThisAddress.Active;
     }
}
