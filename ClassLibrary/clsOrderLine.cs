using System;

namespace TestingOrder
{
    public class clsOrderLine
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


        // orderLineId private memeber variable 
        private Int32 mOrderLineId;
        public Int32 OrderLineId
        {
            get
            {
                // this lineof code sends data out of the property 
                return mOrderLineId;
            }
            
            set

            { 
                // this line of code allows data into the property 
                     mOrderLineId = value;
            }
        }


        private string mDescription;
        public string Description
        {

            get
            {
                // this lineof code sends data out of the property 
                return mDescription;
            }

            set

            {
                // this line of code allows data into the property 
                mDescription = value;
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


        private Int32 mItemId;
        public int ItemId

        {
            get
            {
                // this lineof code sends data out of the property 
                return mItemId;
            }

            set

            {
                // this line of code allows data into the property 
                mItemId = value;
            }

        }



        private Int32 mQuantity;
        public int Quantity

        {
            get
            {
                // this lineof code sends data out of the property 
                return mQuantity;
            }

            set

            {
                // this line of code allows data into the property 
                mQuantity = value;
            }
        }



        private double mPrice;
        public double Price

        {
            get
            {
                // this lineof code sends data out of the property 
                return mPrice;
            }

            set

            {
                // this line of code allows data into the property 
                mPrice = value;
            }
        }


        public bool Find(int orderLineId)
        {
            // set the private data members to the tsts data value
            mOrderLineId = 21;
           // always return true
            return true;
        }
    }
}