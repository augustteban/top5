using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestingCustomer

{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.Name = "John Smith";
            TestItem.EmailAddress = "jsmith1987@gmail.com";
            TestItem.Address = "Flat 10, Charles street, Leicester";
            TestItem.Password = "secret123";
            TestItem.isEmailConfirmed = true;
            TestItem.LoyaltyPoints = 10.5;
            TestItem.CreatedAt = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Name = "John Smith";
            TestItem.EmailAddress = "jsmith1987@gmail.com";
            TestItem.Address = "Flat 10, Charles street, Leicester";
            TestItem.Password = "secret123";
            TestItem.isEmailConfirmed = true;
            TestItem.LoyaltyPoints = 10.5;
            TestItem.CreatedAt = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerId = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Name = "John Smith";
            TestItem.EmailAddress = "jsmith1987@gmail.com";
            TestItem.Address = "Flat 10, Charles street, Leicester";
            TestItem.Password = "secret123";
            TestItem.isEmailConfirmed = true;
            TestItem.LoyaltyPoints = 10.5;
            TestItem.CreatedAt = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerId = PrimaryKey;

            // Modify data
            TestItem.Name = "Johnny Smith";
            TestItem.EmailAddress = "jsmith1887@gmail.com";
            TestItem.Address = "Flat 21, Charles street, Leicester";
            TestItem.Password = "secret321";
            TestItem.isEmailConfirmed = false;
            TestItem.LoyaltyPoints = 12.5;
            TestItem.CreatedAt = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Name = "John Smith";
            TestItem.EmailAddress = "jsmith1987@gmail.com";
            TestItem.Address = "Flat 10, Charles street, Leicester";
            TestItem.Password = "secret123";
            TestItem.isEmailConfirmed = true;
            TestItem.LoyaltyPoints = 10.5;
            TestItem.CreatedAt = DateTime.Now.Date;

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerId = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();

            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByEmailMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByEmail("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByEmailMethodNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByEmail("test@test.com");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
    }
}
