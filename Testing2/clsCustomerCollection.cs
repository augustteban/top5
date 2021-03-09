﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCustomer
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();

                ACustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                ACustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                ACustomer.isEmailConfirmed = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsEmailConfirmed"]);
                ACustomer.LoyaltyPoints = Convert.ToDouble(DB.DataTable.Rows[Index]["LoyaltyPoints"]);
                ACustomer.CreatedAt = Convert.ToDateTime(DB.DataTable.Rows[Index]["CreatedAt"]);

                mCustomerList.Add(ACustomer);
                Index++;

            }
        }

        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }

            set
            {
                mCustomerList = value;
            }
        }

        public int Count
        {
            get { return mCustomerList.Count;
            }
            set {
            }
        }
    }
}