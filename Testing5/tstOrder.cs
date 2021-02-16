using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstOrder
    {

        [TestMethod]
        public void InstanceOk()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void ActivePropertyOk()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property 
            Boolean TestData = true;
            // assign the data to the property
            AnOrder.Active = TestData;
            // test to see if the two values are the same 
            Assert.AreEqual(AnOrder.Active, TestData);
        }




        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void ItemIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.ItemId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ItemId, TestData);
        }




        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Quantity, TestData);
        }




        [TestMethod]
        public void SizePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.Size = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Size, TestData);
        }




        [TestMethod]
        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            String TestData = "ss";
            //assign the data to the property
            AnOrder.Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Description, TestData);
        }





        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Price, TestData);
        }








        [TestMethod]
        public void Order_datePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.Order_date = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Order_date, TestData);
        }



    }
}

