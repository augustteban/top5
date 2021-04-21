using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 OrderLineId;
    protected void Page_Load(object sender, EventArgs e)
    {

        // get the number of the address to be deleted from session object
        OrderLineId = Convert.ToInt32(Session["OrderLineId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection AddressBook = new clsOrderLineCollection();

        // find the record to delete
        AddressBook.ThisAddress.Find(OrderLineId);

        // delete the record
        AddressBook.Delete();

        // redirect back to the main page
        Response.Redirect("OrderLineList");
    }
}