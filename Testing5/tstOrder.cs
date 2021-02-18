using System;
using TestingOrder;
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
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }







        [TestMethod]
        public void ShippingAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            String TestData = "ss";
            //assign the data to the property
            AnOrder.ShippingAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ShippingAddress, TestData);
        }



        [TestMethod]
        public void ShippingDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.ShippingDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ShippingDate, TestData);
        }




        [TestMethod]
        public void PaymentPropertyOk()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data to assign to the property 
            Boolean TestData = true;
            // assign the data to the property
            AnOrder.Payment = TestData;
            // test to see if the two values are the same 
            Assert.AreEqual(AnOrder.Payment, TestData);

        }



        [TestMethod]
        public void TotalPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            double TestData = 1.0;
            //assign the data to the property
            AnOrder.TotalPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }




    }
}   


