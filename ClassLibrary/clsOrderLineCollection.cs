using System;
using System.Collections.Generic;
using TestingOrder;

namespace ClassLibrary
{
    public class clsOrderLineCollection
    {
         List<clsOrderLine> mAddressList = new List<clsOrderLine>();

        // private data member ThisAddress
        clsOrderLine mThisAddress = new clsOrderLine();


        public clsOrderLineCollection()
        {
            // create the item of test data
            clsOrderLine TestItem = new clsOrderLine();

            //set its properties 
            TestItem.Active = true;
            TestItem.OrderLineId = 1;
            TestItem.OrderId = 1;
            TestItem.ItemId = 1;
            TestItem.Quantity = 1;
            TestItem.Description = "Red short";
            TestItem.Price = 1.0;

            // add the item to the yesy list
            mAddressList.Add(TestItem);

            // re initialise the object for some new data
            TestItem = new clsOrderLine();

            // set its properties
            TestItem.Active = true;
            TestItem.OrderLineId = 2;
            TestItem.OrderId = 2;
            TestItem.ItemId = 2;
            TestItem.Quantity = 2;
            TestItem.Description = "Black short";
            TestItem.Price = 2.0;

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
                DB.Execute("sproc_tblOrderLine_SelectAll");

                // get thecount of records 
                RecordCount = DB.Count;

                // while there are records to process
                while (Index < RecordCount)
                {

                // create blank address
                clsOrderLine AnOrderLine = new clsOrderLine();

                // read in the fields from current record
                 AnOrderLine.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                 AnOrderLine.OrderLineId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLineId"]);
                 AnOrderLine.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                 AnOrderLine.ItemId = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemId"]);
                 AnOrderLine.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                 AnOrderLine.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                 AnOrderLine.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);

                 // add the record to the private data member
                 mAddressList.Add(AnOrderLine);

                // point to the next record 
                Index++;
                }
            }
        }
        


        public List<clsOrderLine> AddressList
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

        public clsOrderLine ThisAddress
        {
            get
            {
                return mThisAddress;
            }
            set
            {
                // set the private data
                mThisAddress = value;
            }

        }

        public int Add()
        {
            // add a new record to the database based on the values of mThisAddress
            // set the primary key value of the new record
            mThisAddress.OrderLineId = 5;
        
            // connect to the database
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderId", mThisAddress.OrderId);
            DB.AddParameter("@ItemId", mThisAddress.ItemId);
            DB.AddParameter("@Quantity", mThisAddress.Quantity);
            DB.AddParameter("@Description", mThisAddress.Description);
            DB.AddParameter("@Price", mThisAddress.Price);
            DB.AddParameter("@Active", mThisAddress.Active);

            // excute the query returning the primary key value
            return DB.Execute("sproc_tblOrderLine_Insert");           
        }

        public void Update()
        {
            // connect to the database
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderLineId", mThisAddress.OrderLineId);
            DB.AddParameter("@OrderId", mThisAddress.OrderId);
            DB.AddParameter("@ItemId", mThisAddress.ItemId);
            DB.AddParameter("@Quantity", mThisAddress.Quantity);
            DB.AddParameter("@Description", mThisAddress.Description);
            DB.AddParameter("@Price", mThisAddress.Price);
            DB.AddParameter("@Active", mThisAddress.Active);

            // excute the query returning the primary key value
            DB.Execute("sproc_tblOrderLine_Update");
        }

        public void Delete()
        {
            // delete the record pointed to by thisAddress
            // connect to thr database
            clsDataConnection DB = new clsDataConnection();

            // set the parameters for the stored procedure 
            DB.AddParameter("@OrderLineId", mThisAddress.OrderLineId);

            // excute the stored procedure 
            DB.Execute("sproc_tblOrderLine_Delete");

        }
    }
    }
