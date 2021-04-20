using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestingOrder;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderLineId;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        // create a new instance of clsOrderLine
        clsOrderLine AnOrderLine = new clsOrderLine();


        string OrderId = txtOrderId.Text;
        string ItemId = txtItemId.Text;
        string Quantity = txtQuantity.Text;
        string Description = txtDescription.Text;
        string Price = txtPrice.Text;

        string Error = "";
        Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

        if (Error == "")
        {
            AnOrderLine.OrderId = OrderId;
            AnOrderLine.ItemId = ItemId;
            AnOrderLine.Quantity = Quantity;
            AnOrderLine.Description = Description;
            AnOrderLine.Price = Price;
            AnOrderLine.Active = chkActive.Checked;

            // create an instance of the address collection
            clsOrderLineCollection AddressList = new clsOrderLineCollection();

            // if this a new record i.e. OrderLineId = -1 then add the data 
            if (OrderLineId == -1)
            {
                // set the ThisAddress property
                AddressList.ThisAddress = AnOrderLine;

                // add a new record
                AddressList.Add();
            }
            // otherwise it must be an update
            else
            {
                // find the record to update 
                AddressList.ThisAddress.Find(OrderLineId);
                // set the ThisAddress property 
                AddressList.ThisAddress = AnOrderLine;
                // update the record
                AddressList.Update();
            }

            // redirect back tp the listpage
            Response.Redirect("OrderLineList.aspx");
        }
        else
        {

            // display the error message
            lblError.Text = Error;
        }




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
