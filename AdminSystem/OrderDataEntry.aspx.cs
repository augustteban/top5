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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the OrderLine class

        clsOrder AnOrder = new clsOrder();

        // variable to store the result of the primary key

        Int32 OrderId;

        // variable to store the result of the find operation

        Boolean Found = false;

        // get the primary key entered by the user 

        OrderId = Convert.ToInt32(txtOrderId.Text);

        // find the record 

        Found = AnOrder.Find(OrderId);

        // if found 

        if (Found == true)
        {

            // display the values of the properties in the form 

            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            txtShippingAddress.Text = AnOrder.ShippingAddress;
            txtShippingDate.Text = AnOrder.ShippingDate.ToString();
            txtPayment.Text = AnOrder.Payment.ToString();
            txtTotalPrice.Text = AnOrder.TotalPrice.ToString();

        }
    }
}
    
