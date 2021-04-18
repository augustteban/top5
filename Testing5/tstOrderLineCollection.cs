using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestingOrder
{
    [TestClass]
    public class tstOrderLineCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void InstanceOK()
        {

        // create an instance of the class we want to create 
        clsOrderLineCollection AllAddresses = new clsOrderLineCollection();

            // test to see that exists 
            Assert.IsNotNull(AllAddresses);
        }

        [TestMethod]
        public void AddressListOK()
        {
            // create an instance of the class we want to create 
            clsOrderLineCollection AllAddresses = new clsOrderLineCollection();

            // create some test data to assign the property 
            // in this case the data needs to be a list of objects
            List<clsOrderLine> TestList = new List<clsOrderLine>();

            // add an item to the list 
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
            clsOrderLineCollection AllAddresses = new clsOrderLineCollection();

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
            clsOrderLineCollection AllAddresses = new clsOrderLineCollection();

            // create some test data to assign to the property 
            clsOrderLine TestAddress = new clsOrderLine();

            //set the properties of the test object
            TestAddress.Active = true;
            TestAddress.OrderLineId = 1;
            TestAddress.OrderId = 1;
            TestAddress.ItemId = 1;
            TestAddress.Quantity = 1;
            TestAddress.Description = "Red short";
            TestAddress.Price = 1.0;


            // assign the data to the property 
            AllAddresses.ThisAddress = TestAddress;

            //test to see that the two values are the same 
            Assert.AreEqual(AllAddresses.ThisAddress, TestAddress);
        }

        [TestMethod]
        public void ListAndCountOK()
        {

            // create an instance of the class we want to create 
            clsOrderLineCollection AllAddresses = new clsOrderLineCollection();

            // create some test data to assign the property 
            // in this case the data needs to be a list of objects
            List<clsOrderLine> TestList = new List<clsOrderLine>();

            // add an item to the list 
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

            // add the item to the test list
            TestList.Add(TestItem);

            // assign the data to the property 
            AllAddresses.AddressList = TestList;

            //test to see thet the two values are the same 
            Assert.AreEqual(AllAddresses.Count, TestList.Count);
        }


    }
}
