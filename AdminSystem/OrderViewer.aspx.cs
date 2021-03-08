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