using System;

namespace TestingOrder
{
    public class clsOrder
    {
        private Boolean mActive;
        public bool Active
        {
            get
            {
                // this lineof code sends data out of the property 
                return mActive;
            }

            set

            {
                // this line of code allows data into the property 
                mActive = value;
            }
        }



        private Int32 mOrderId;
        public int OrderId
        {
            get
            {
                // this lineof code sends data out of the property 
                return mOrderId;
            }

            set

            {
                // this line of code allows data into the property 
                mOrderId = value;
            }
        }


        private Int32 mCustomerId;
        public int CustomerId
        {
            get
            {
                // this lineof code sends data out of the property 
                return mCustomerId;
            }

            set

            {
                // this line of code allows data into the property 
                mCustomerId = value;
            }
        }


        private Double mTotalPrice;
        public Double TotalPrice
        {
            get
            {
                // this lineof code sends data out of the property 
                return mTotalPrice;
            }

            set

            {
                // this line of code allows data into the property 
                mTotalPrice = value;
            }
        }


        private Boolean mPayment;
        public bool Payment
        {
            get
            {
                // this lineof code sends data out of the property 
                return mPayment;
            }

            set

            {
                // this line of code allows data into the property 
                mPayment = value;
            }
        }


        private DateTime mShippingDate;
        public DateTime ShippingDate
        {
            get
            {
                // this lineof code sends data out of the property 
                return mShippingDate;
            }

            set

            {
                // this line of code allows data into the property 
                mShippingDate = value;
            }
        }


        private string mShippingAddress;
        public string ShippingAddress
        {
            get
            {
                // this lineof code sends data out of the property 
                return mShippingAddress;
            }

            set

            {
                // this line of code allows data into the property 
                mShippingAddress = value;
            }
        }



        public bool Find(int orderId)
        {
            // create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();

            // add the parameter for the order line id to search for 
            DB.AddParameter("@OrderId", orderId);

            // execute the stored procedure 
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            // if one record is found (there should be either zero or one!)
            if (DB.Count == 1)
            {
                // copy the data from database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
                mShippingDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ShippingDate"]);
                mPayment = Convert.ToBoolean(DB.DataTable.Rows[0]["Payment"]);
                mTotalPrice = Convert.ToDouble(DB.DataTable.Rows[0]["TotalPrice"]);

                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);

                // return that everything worked OK
                return true;
            }
            // if no record was found 
            else
            {
                // return false indicating a problem
                return false;
            }




        }
    }
}