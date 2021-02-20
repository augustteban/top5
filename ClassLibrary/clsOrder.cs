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


        private double mTotalPrice;
        public double TotalPrice
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
            mOrderId = 21;
            mShippingDate = Convert.ToDateTime("16/08/2019");
            return true;
        }
    }
}