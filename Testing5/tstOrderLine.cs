using System;
using TestingOrder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestingOrder
{
    [TestClass]
    public class tstOrderLine
    {
        // good test data 
       // create some test data to pass the method

        string OrderId = "1011";
        string ItemId = "1";
        string Quantity = "2";
        string Description = "Red shirt";
        string Price = "1.0";


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
            clsOrderLine OrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderLineId = 21;
            //invoke the method
            Found = OrderLine.Find(OrderLineId);
            //check the address no
            if (OrderLine.Description != "abc")
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
            clsOrderLine OrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderLineId = 1;
            //invoke the method
            Found = OrderLine.Find(OrderLineId);
            //check the address no
            if (OrderLine.Active != true)
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

            clsOrderLine AnOrderLine = new clsOrderLine();

    // string variable to store any error message

            string Error = "";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId,ItemId,Quantity,Description,Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

}
        [TestMethod]
        public void OrderIdMinLessOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string OrderId = "";  // this should trigger an error

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreNotEqual(Error, "");
 
}




        [TestMethod]
        public void OrderIdMin()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string OrderId = "a";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

}


        [TestMethod]
        public void OrderIdMinPlusOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string OrderId = "aa";
            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");
        
}


        [TestMethod]
        public void OrderIdMaxLessOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string OrderId = "aaaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");
        
}


        [TestMethod]
        public void OrderIdMax()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string OrderId = "aaaaaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");
        
}


        [TestMethod]
        public void OrderIdMid()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string OrderId = "aaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");
        
}




        [TestMethod]
        public void OrderIdMaxPlusOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string OrderId = "aaaaaaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");
        
}
        [TestMethod]
        public void OrderIdExtremeMax()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string OrderId = "";
            OrderId = OrderId.PadRight(500, 'a');

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");
        
}

        [TestMethod]
        public void ItemIdMinLessOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string ItemId = "";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreNotEqual(Error, "");
        
}



        [TestMethod]
        public void ItemIdMin()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string ItemId = "a";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

}


        [TestMethod]
        public void ItemIdMinPlusOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string ItemId = "aa";
            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");
        
}


        [TestMethod]
        public void ItemIdMaxLessOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string ItemId = "aaaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");
        
}


        [TestMethod]
        public void ItemIdMax()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string ItemId = "aaaaaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");
        
}


        [TestMethod]
        public void ItemIdMid()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string ItemId = "aaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");
        
}




        [TestMethod]
        public void ItemIdMaxPlusOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string ItemId = "aaaaaaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");
        
}
        [TestMethod]
        public void ItemIdExtremeMax()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string ItemId = "";
            ItemId = ItemId.PadRight(500, 'a');

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");
        
}

        [TestMethod]
        public void QuantityMinLessOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Quantity = "";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]
        public void QuantityMin()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Quantity = "a";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void QuantityMinPlusOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Quantity = "aa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void QuantityMaxLessOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Quantity = "aaaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void QuantityMax()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Quantity = "aaaaaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void QuantityMid()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Quantity = "aaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }




        [TestMethod]
        public void QuantityMaxPlusOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Quantity = "aaaaaaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        } 

        [TestMethod]
        public void QuantityExtremeMax()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Quantity = "";
            Quantity = Quantity.PadRight(500, 'a');

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void DescriptionMinLessOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Description = "";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]
        public void DescriptionMin()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Description = "a";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void DescriptionMinPlusOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Description = "aa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void DescriptionMaxLessOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Description = "aaaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void DescriptionMax()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Description = "aaaaaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void DescriptionMid()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Description = "aaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }




        [TestMethod]
        public void DescriptionMaxPlusOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Description = "aaaaaaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DescriptionExtremeMax()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Description = "";
            Description = Description.PadRight(500, 'a');

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Price = "";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]
        public void PriceMin()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Price = "a";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void PriceMinPlusOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Price = "aa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void PriceMaxLessOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Price = "aaaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void PriceMax()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Price = "aaaaaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void PriceMid()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Price = "aaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }




        [TestMethod]
        public void PriceMaxPlusOne()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Price = "aaaaaaa";

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PriceExtremeMax()
        {

            //  create an instance of the class we want to create 

            clsOrderLine AnOrderLine = new clsOrderLine();

            // string variable to store any error message

            string Error = "";

            // create some test data to pass to the method 

            string Price = "";
            Price = Price.PadRight(500, 'a');

            // invoke the method

            Error = AnOrderLine.Valid(OrderId, ItemId, Quantity, Description, Price);

            // test to see that the result is correct

            Assert.AreEqual(Error, "");

        }

        
    }

    }

