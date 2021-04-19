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
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        // create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        string CustomerId = txtCustomerId.Text;
        string ShippingAddress = txtShippingAddress.Text;
        string ShippingDate = txtShippingDate.Text;
        string Payment = txtPayment.Text;
        string TotalPrice = txtTotalPrice.Text;

        string Error = "";

        Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);
        if (Error == "")
        { 
        
        AnOrder.CustomerId = CustomerId;
        AnOrder.ShippingAddress = ShippingAddress;
        AnOrder.ShippingDate = ShippingDate;
        AnOrder.Payment = Payment;
        AnOrder.TotalPrice = TotalPrice;
        AnOrder.Active = chkActive.Checked;

            // create an instance of the address collection
            clsOrderCollection AddressList = new clsOrderCollection();

            // set the ThisAddress of the address collection
            AddressList.ThisAddress = AnOrder;

            // add a new record
            AddressList.Add();

            // redirect back tp the listpage
            Response.Redirect("OrderList.aspx");
        }
        else
        {

            // display the error message
            lblError.Text = Error;

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
    
