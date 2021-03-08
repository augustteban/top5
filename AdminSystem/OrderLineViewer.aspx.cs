using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestingOrder;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
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
}