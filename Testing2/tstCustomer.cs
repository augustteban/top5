using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingCustomer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(Customer);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer Customer = new clsCustomer();
            //create some test data to assign to the property
            int TestData = 0;
            //assign the data to the property
            Customer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Customer.CustomerId, TestData);
        }


        [TestMethod]
        public void NamePropertyOK()
        {
            clsCustomer Customer = new clsCustomer();
            string TestData = "name";
            Customer.Name = TestData;
            Assert.AreEqual(Customer.Name, TestData);
        }

        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            clsCustomer Customer = new clsCustomer();
            string TestData = "email";
            Customer.EmailAddress = TestData;
            Assert.AreEqual(Customer.EmailAddress, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsCustomer Customer = new clsCustomer();
            string TestData = "name";
            Customer.Address = TestData;
            Assert.AreEqual(Customer.Address, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsCustomer Customer = new clsCustomer();
            string TestData = "password";
            Customer.Password = TestData;
            Assert.AreEqual(Customer.Password, TestData);
        }

        [TestMethod]
        public void isEmailConfirmedPropertyOK()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean TestData = true;
            Customer.isEmailConfirmed = TestData;
            Assert.AreEqual(Customer.isEmailConfirmed, TestData);
        }

        [TestMethod]
        public void LoyaltyPointsPropertyOK()
        {
            clsCustomer Customer = new clsCustomer();
            double TestData = 0.1;
            Customer.LoyaltyPoints = TestData;
            Assert.AreEqual(Customer.LoyaltyPoints, TestData);
        }

        [TestMethod]
        public void CreatedAtPropertyOK()
        {
            clsCustomer Customer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            Customer.CreatedAt = TestData;
            Assert.AreEqual(Customer.CreatedAt, TestData);
        }
    }
}
