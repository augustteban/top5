using System;
using TestingOrder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingOrder
{
    [TestClass]
    public class tstOrderLine
    {
       
        [TestMethod]
        public void InstanceOk()
        {
            // create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            // test to see that it exists
            Assert.IsNotNull(AnOrderLine);
        }

        [TestMethod]
        public void ActivePropertyOk()
        {
            // create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            // create some test data to assign to the property 
            Boolean TestData = true;
            // assign the data to the property
            AnOrderLine.Active = TestData;
            // test to see if the two values are the same 
            Assert.AreEqual(AnOrderLine.Active, TestData);
        }


        [TestMethod]
        public void OrderLineIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderLine.OrderLineId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.OrderLineId, TestData);
        }



        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderLine.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.OrderId, TestData);
        }



        [TestMethod]
        public void ItemIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderLine.ItemId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.ItemId, TestData);
        }




        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderLine.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.Quantity, TestData);
        }







        [TestMethod]
        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            String TestData = "ss";
            //assign the data to the property
            AnOrderLine.Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.Description, TestData);
        }



        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            double TestData = 1.0;
            //assign the data to the property
            AnOrderLine.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.Price, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Int32 OrderLineId = 1;
            Found = AnOrderLine.Find(OrderLineId);
            Assert.IsTrue(Found);

        }


        [TestMethod]
        public void TestOrderLineIdFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderLineId = 21;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineId);
            //check the address no
            if (AnOrderLine.OrderLineId != 21)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }





        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderLineId = 21;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineId);
            //check the address no
            if (AnOrderLine.OrderId != 21)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestItemIdFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderLineId = 21;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineId);
            //check the address no
            if (AnOrderLine.ItemId != 21)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }





        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderLineId = 21;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineId);
            //check the address no
            if (AnOrderLine.Quantity != 21)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestDescriptionFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderLineId = 21;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineId);
            //check the address no
            if (AnOrderLine.Description != "abc")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }




        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderLineId = 21;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineId);
            //check the address no
            if (AnOrderLine.Price != 0.1)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderLineId = 21;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineId);
            //check the address no
            if (AnOrderLine.Active != true)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



    }
}
