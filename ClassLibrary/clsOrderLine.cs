﻿using System;

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
            // create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();

            // add the parameter for the order line id to search for 
            DB.AddParameter("@OrderLineId", orderLineId);

            // execute the stored procedure 
            DB.Execute("sproc_tblOrderLine_FilterByOrderLineId");
            // if one record is found (there should be either zero or one!)
            if (DB.Count == 1)
            {
                // copy the data from database to the private data members
                mOrderLineId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineId"]);
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mItemId = Convert.ToInt32(DB.DataTable.Rows[0]["ItemId"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                
                // return that everything worked OK
                return true;
            }
            // if no record was found 
            else
            {
                // return false indicating a prblem
                return false;
            }
           



        }
    }
}