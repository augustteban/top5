using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestingOrder;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        // create a new instance of clsOrderLine
        clsOrder AnOrder = new clsOrder();

        
        AnOrder.OrderId = Int32.Parse(txtOrderId.Text);
        AnOrder.CustomerId = Int32.Parse(txtCustomerId.Text);
        AnOrder.ShippingAddress = txtShippingAddress.Text;
        AnOrder.ShippingDate = DateTime.Parse(txtShippingDate.Text);
        AnOrder.Payment = Boolean.Parse(txtPayment.Text);
        AnOrder.TotalPrice = Double.Parse(txtTotalPrice.Text);
        Session["AnOrder"] = AnOrder;


        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }
}