using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCustomer
{
    public class clsCustomer
    {

        private string mName;
        public string Name {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        private string mEmailAddress;
        public string EmailAddress {
            get
            {
                return mEmailAddress;
            }
            set
            {
                mEmailAddress = value;
            }
        }
        private string mAddress;
        public string Address { get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
                }
        private string mPassword;
        public string Password { get
            {
                return mPassword;
            
            } set
            {
                mPassword = value;
            }
                }
        private Boolean mIsEmailConfirmed;
        public Boolean isEmailConfirmed
        {
            get
            {
                return mIsEmailConfirmed;
            }
            set
            {
                mIsEmailConfirmed = value;
            }
        }
            private double mLoyaltyPoints;
        public double LoyaltyPoints { get
            {
                return mLoyaltyPoints;
            } set
            {
                mLoyaltyPoints = value;
            }
                }
        private DateTime mCreatedAt;
        public DateTime CreatedAt
        {
            get
            {
                return mCreatedAt;
            }
            set
            {
                mCreatedAt = value;
            }
        }

        private Int32 mCustomerId;
        public Int32 CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }
        public bool Find(int customerId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", customerId);
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");

            if (DB.Count == 1)
            {
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mIsEmailConfirmed = Convert.ToBoolean(DB.DataTable.Rows[0]["IsEmailConfirmed"]);
                mLoyaltyPoints = Convert.ToDouble(DB.DataTable.Rows[0]["LoyaltyPoints"]);
                mCreatedAt = Convert.ToDateTime(DB.DataTable.Rows[0]["CreatedAt"]);

                return true;
            }
            else {
                return false;

            }
        }

        public string Valid(string name, string emailAddress, string address, string password, string isEmailConfirmed, string loyaltyPoints, string createdAt)
        {
            String Error = "";

            if (name.Length == 0)
            {
                Error = Error + "The name cannot be blank : ";
            }

            if (name.Length < 0 || name.Length == 1 || name.Length > 50)
            {
                Error = Error + "The name must be between 2 and 50 characters long : ";
            }

            if (emailAddress.Length == 0)
            {
                Error = Error + "The email address cannot be blank : ";
            }

            if ((emailAddress.Length <= 10 && emailAddress.Length != 0) || emailAddress.Length > 50)
            {
                Error = Error + "The email address must be between 11 and 50 characters long : ";
            }

            if (address.Length == 0)
            {
                Error = Error + "The address cannot be blank : ";
            }

            if ((address.Length < 15 && address.Length != 0) || address.Length > 100)
            {
                Error = Error + "The address must be between 15 an 100 characters long : ";
            }

            return Error;
        }
    }
}
