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
            mCustomerId = 21;
            mCreatedAt = Convert.ToDateTime("16/09/2019");
            mName = "John Barao";
            mPassword = "password123";
            mEmailAddress = "email@gmail.com";
            mAddress = "Test Address";
            mLoyaltyPoints = 10.5;
            mIsEmailConfirmed = true;
            return true;
        }

        
    }
}
