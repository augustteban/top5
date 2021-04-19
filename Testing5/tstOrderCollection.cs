﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestingOrder
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void InstanceOK()
        {

            // create an instance of the class we want to create 
            clsOrderCollection AllAddresses = new clsOrderCollection();

            // test to see that exists 
            Assert.IsNotNull(AllAddresses);
        }

        [TestMethod]
        public void AddressListOK()
        {
            // create an instance of the class we want to create 
            clsOrderCollection AllAddresses = new clsOrderCollection();

            // create some test data to assign the property 
            // in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();

            // add an item to the list 
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
            TestList.Add(TestItem);

            // assign the data to the property 	
            AllAddresses.AddressList = TestList;

            //test to see thet the two values are the same 
            Assert.AreEqual(AllAddresses.AddressList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {

            // create an instance of the class we want to create 
            clsOrderCollection AllAddresses = new clsOrderCollection();

            // create some test data to the property 
            Int32 SomeCount = 2;

            // assign the data to the property 
            AllAddresses.Count = SomeCount;

            // test to see that the two values are equal
            Assert.AreEqual(AllAddresses.Count, SomeCount);
        }

        [TestMethod]
        public void ThisAddressPropertyOK()
        {

            // create an instance 
            clsOrderCollection AllAddresses = new clsOrderCollection();

            // create some test data to assign to the property 
            clsOrder TestAddress = new clsOrder();

            //set the properties of the test object
            TestAddress.Active = true;
            TestAddress.OrderId = 1;
            TestAddress.CustomerId = 1;
            TestAddress.ShippingAddress = "LE1 4SD";
            TestAddress.ShippingDate = DateTime.Now.Date;
            TestAddress.Payment = true;
            TestAddress.TotalPrice = 1.0;


            // assign the data to the property 
            AllAddresses.ThisAddress = TestAddress;

            //test to see that the two values are the same 
            Assert.AreEqual(AllAddresses.ThisAddress, TestAddress);
        }

        [TestMethod]
        public void ListAndCountOK()
        {

            // create an instance of the class we want to create 
            clsOrderCollection AllAddresses = new clsOrderCollection();

            // create some test data to assign the property 
            // in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();

            // add an item to the list 
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

            // add the item to the test list
            TestList.Add(TestItem);

            // assign the data to the property 
            AllAddresses.AddressList = TestList;

            //test to see thet the two values are the same 
            Assert.AreEqual(AllAddresses.Count, TestList.Count);
        }
    }
}
