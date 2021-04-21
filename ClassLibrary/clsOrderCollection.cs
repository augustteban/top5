﻿using System;
using System.Collections.Generic;
using TestingOrder;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mAddressList = new List<clsOrder>();

        // private data member ThisAddress
        clsOrder mThisAddress = new clsOrder();

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


        public clsOrder ThisAddress
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
            mThisAddress.OrderId = 5;
        
            // connect to the database
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerId", mThisAddress.CustomerId);
            DB.AddParameter("@ShippingAddress", mThisAddress.ShippingAddress);
            DB.AddParameter("@ShippingDate", mThisAddress.ShippingDate);
            DB.AddParameter("@Payment", mThisAddress.Payment);
            DB.AddParameter("@TotalPrice", mThisAddress.TotalPrice);
            DB.AddParameter("@Active", mThisAddress.Active);

            // excute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            // connect to the database
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderId", mThisAddress.OrderId);
            DB.AddParameter("@CustomerId", mThisAddress.CustomerId);
            DB.AddParameter("@ShippingAddress", mThisAddress.ShippingAddress);
            DB.AddParameter("@ShippingDate", mThisAddress.ShippingDate);
            DB.AddParameter("@Payment", mThisAddress.Payment);
            DB.AddParameter("@TotalPrice", mThisAddress.TotalPrice);
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
            DB.AddParameter("@OrderId", mThisAddress.OrderId);

            // excute the stored procedure 
            DB.Execute("sproc_tblOrder_Delete");
        }
    }
    }
    
