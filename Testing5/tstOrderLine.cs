using System;
using TestingOrder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
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

    }
}
