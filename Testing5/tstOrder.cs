using System;
using TestingOrder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstOrder
    {
        // good test data 

        // create some test data to pass the method

        string CustomerId = "1011";
        string ShippingAddress = "1b";
        string ShippingDate = DateTime.Now.Date.ToString();
        string TotalPrice = "1.0";


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

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            Assert.IsTrue(Found);

        }


        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1011;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the address no
            if (AnOrder.OrderId != 1011)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1011;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the address no
            if (AnOrder.CustomerId != 1011)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShippingAddressFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1011;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the address no
            if (AnOrder.ShippingAddress != "abc")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestShippingDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1011;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the address no
            if (AnOrder.ShippingDate != Convert.ToDateTime("16/08/2019"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymenetFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1011;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the address no
            if (AnOrder.Payment != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalPriceFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1011;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the address no
            if (AnOrder.TotalPrice != 1011)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();
        
         // string variable to store any error message

            string Error = "";

            // invoke the method

            Error = AnOrder.Valid(CustomerId,ShippingAddress,ShippingDate,TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

}




        [TestMethod]
        public void CustomerIdMin()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string CustomerId = "a";

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }






        [TestMethod]
        public void CustomerIdMinPlusOne()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string CustomerId = "aa";

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void CustomerIdMaxLessOne()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string CustomerId = "aaaa";

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void CustomerIdMax()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string CustomerId = "aaaaaa";

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void CustomerIdMid()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string CustomerId = "aaa";

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }




        [TestMethod]
        public void CustomerIdMaxPlusOne()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string CustomerId = "aaaaaaa";

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIdExtremeMax()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string CustomerId = "";
            CustomerId = CustomerId.PadRight(500, 'a');

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }







        [TestMethod]
        public void ShippingAddressMin()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string ShippingAddress = "a";

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }






        [TestMethod]
        public void ShippingAddressMinPlusOne()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string ShippingAddress = "aa";

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ShippingAddressMaxLessOne()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string ShippingAddress = "aaaa";

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ShippingAddressMax()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string ShippingAddress = "aaaaaa";

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ShippingAddressMid()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string ShippingAddress = "aaa";

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }




        [TestMethod]
        public void ShippingAddressMaxPlusOne()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string ShippingAddress = "aaaaaaa";

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShippingAddressExtremeMax()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(500, 'a');

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }







        [TestMethod]
        public void ShippingDateMin()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            String Error = "";

            //create a variable to store the test date data

            DateTime TestDate;

            //set the date totodays date

            TestDate = DateTime.Now.Date;

            //convert the date variable to a string variable

            string ShippingDate = TestDate.ToString();

            //invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");

        }







        [TestMethod]
        public void ShippingDateMinPlusOne()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            String Error = "";

            //create a variable to store the test date data

            DateTime TestDate;

            //set the date totodays date

            TestDate = DateTime.Now.Date;

            // change the date variable to a string variable

            TestDate = TestDate.AddDays(1)

            //convert the date variable to a string variable

            string ShippingDate = TestDate.ToString();

            //invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            //test to see that the result is correct

            Assert.AreEqual(Error, "");


        }










        [TestMethod]
        public void ShippingDateExtremeMax()
        {
            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            String Error = "";

            //create a variable to store the test date data

            DateTime TestDate;

            //set the date totodays date

            TestDate = DateTime.Now.Date;

            // change the date variable to a string variable

            TestDate = TestDate.AddDays(100)

            //convert the date variable to a string variable

            string ShippingDate = TestDate.ToString();

            //invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }





        [TestMethod]
        public void TotalPriceMin()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string TotalPrice = "a";

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }






        [TestMethod]
        public void TotalPriceMinPlusOne()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string TotalPrice = "aa";

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void TotalPriceMaxLessOne()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string TotalPrice = "aaaa";

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void TotalPriceMax()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string TotalPrice = "aaaaaa";

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void TotalPriceMid()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string TotalPrice = "aaa";

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }




        [TestMethod]
        public void TotalPriceMaxPlusOne()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string TotalPrice = "aaaaaaa";

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void TotalPriceExtremeMax()
        {

            //  create an instance of the class we want to create 

            clsOrder AnOrder = new clsOrder();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string TotalPrice = "";
            TotalPrice = TotalPrice.PadRight(500, 'a');

            // invoke the method

            Error = AnOrder.Valid(CustomerId, ShippingAddress, ShippingDate, TotalPrice);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }



    }
    }   


