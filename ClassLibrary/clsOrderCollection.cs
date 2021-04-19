using System;
using System.Collections.Generic;
using TestingOrder;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mAddressList = new List<clsOrder>();

        public clsOrderCollection()
        {
            // create the item of test data
            clsOrder TestItem = new clsOrder();

            //set its properties 
            TestItem.Active = true;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.ShippingAddress = "LE1 4SD";
            TestItem.ShippingDate = DateTime.Now.Date;
            TestItem.Payment = true;
            TestItem.TotalPrice = 1.0;

            // add the item to the yesy list
            mAddressList.Add(TestItem);

            // re initialise the object for some new data
            TestItem = new clsOrder();

            // set its properties
            TestItem.Active = true;
            TestItem.OrderId = 2;
            TestItem.CustomerId = 2;
            TestItem.ShippingAddress = "LE1 4SG";
            TestItem.ShippingDate = DateTime.Now.Date;
            TestItem.Payment = true;
            TestItem.TotalPrice = 2.0;

            // add the item to the test list
            mAddressList.Add(TestItem);


            {
                // var for index
                Int32 Index = 0;

                // var to store the record count 
                Int32 RecordCount = 0;

                // object for data connection 
                clsDataConnection DB = new clsDataConnection();

                // EXCUTE THE STORED PROCEDURE 
                DB.Execute("sproc_tblOrder_SelectAll");

                // get thecount of records 
                RecordCount = DB.Count;

                // while there are records to process
                while (Index < RecordCount)
                {

                    // create blank address
                    clsOrder AnOrder = new clsOrder();

                    // read in the fields from current record
                    AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                    AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                    AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                    AnOrder.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);
                    AnOrder.ShippingDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ShippingDate"]);
                    AnOrder.Payment = Convert.ToBoolean(DB.DataTable.Rows[Index]["Payment"]);
                    AnOrder.TotalPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["TotalPrice"]);

                    // add the record to the private data member
                    mAddressList.Add(AnOrder);

                    // point to the next record 
                    Index++;
                }

            }
        }

        public List<clsOrder> AddressList
        {
            get
            {
                return mAddressList;
            }
            set
            {
                mAddressList = value;
            }
        }


        public int Count
        {
            get
            {
                return mAddressList.Count;
            }
            set
            {
                // we shall worry about this later
            }

        }


        public clsOrder ThisAddress { get; set; }


    }
}