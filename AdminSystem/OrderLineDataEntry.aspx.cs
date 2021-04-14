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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        // create a new instance of clsOrderLine
        clsOrderLine AnOrderLine = new clsOrderLine();

        AnOrderLine.OrderLineId = Int32.Parse(txtOrderLineId.Text);
        AnOrderLine.OrderId = Int32.Parse(txtOrderId.Text);
        AnOrderLine.ItemId = Int32.Parse(txtItemId.Text);
        AnOrderLine.Quantity = Int32.Parse(txtQuantity.Text);
        AnOrderLine.Description = txtDescription.Text;
        AnOrderLine.Price = Double.Parse(txtPrice.Text);
        Session["AnOrderLine"] = AnOrderLine;

        // nevigate to the viewr page
        Response.Redirect("OrderLineViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the OrderLine class

        clsOrderLine AnOrderLine = new clsOrderLine();

        // variable to store the result of the primary key

        Int32 OrderLineId;

        // variable to store the result of the find operation

        Boolean Found = false;

        // get the primary key entered by the user 

        OrderLineId = Convert.ToInt32(txtOrderLineId.Text);

        // find the record 

        Found = AnOrderLine.Find(OrderLineId);

        // if found 

        if (Found == true)
        {

            // display the values of the properties in the form 

            txtOrderId.Text = AnOrderLine.OrderId.ToString();
            txtItemId.Text = AnOrderLine.ItemId.ToString();
            txtQuantity.Text = AnOrderLine.Quantity.ToString();
            txtDescription.Text = AnOrderLine.Description.ToString();
            txtPrice.Text = AnOrderLine.Price.ToString();

        }
    }
}