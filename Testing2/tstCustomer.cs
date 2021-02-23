using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingCustomer
{
    [TestClass]
    public class UnitTest1
    {
        //good test data
        string Name = "John Smith";
        string EmailAddress = "jsmith1987@gmail.com";
        string Address = "Flat 10, Charles street, Leicester";
        string Password = "secret123";
        string IsEmailConfirmed = "true";
        string LoyaltyPoints = "10.5";
        string CreatedAt = DateTime.Now.Date.ToString();


      /**
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

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerId = 1;
            Found = Customer.Find(CustomerId);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestCustomerNotFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = Customer.Find(CustomerId);
            if (Customer.CustomerId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateCreateAtFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = Customer.Find(CustomerId);
            if (Customer.CreatedAt != Convert.ToDateTime("16/09/2019"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = Customer.Find(CustomerId);
            if (Customer.Name != "Joe Doe")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPassswordFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = Customer.Find(CustomerId);
            if (Customer.Password != "password123")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailAddressFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = Customer.Find(CustomerId);
            if (Customer.EmailAddress != "email@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAddressNotFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = Customer.Find(CustomerId);
            if (Customer.Address != "Test Address")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestIsEmailConfirmedFound()
        {
            clsCustomer Customer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = Customer.Find(CustomerId);
            if (Customer.isEmailConfirmed != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    **/

        //WEEK 21 work begins

        [TestMethod]
        public void ValidMethodOK() {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMin()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Name = "";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Name = "J";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Name = "Jo";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Name = "Joe";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Name = "Duke The Fourth Johannah Bridgertton Williamsbury";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Name = "Duke The Fourth Johannah Bridgertton Williamsburry";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Name = "Duke The Fourth Johhannah Bridgertton Williamsburry";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Name = "James William Bruckington";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Name = "James William Bruckington ajdalkdj alkd jakldj alsdj alsdj alsdj" +
                " alsdj lasdj alsd jaldj alsdj alksdj lkasd jalksd ajls asdakldj alksdj kladj" +
                " klasdjlkadjlasdjlksadjlakdjlkasdjalaskdjaklsdjaklsdjalkdjalksdjlkasdjlsajdk" +
                "sdjaklsdjalksdjlkasjdlkasjdlad alsdj ss";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressExtremeMin()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string EmailAddress = "";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string EmailAddress = "jo@mail.co";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMin()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string EmailAddress = "jo@mail.com";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string EmailAddress = "joe@mail.com";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string EmailAddress = "testingemailaddressandsomethingelse12@gmail.co.uk";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMax()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string EmailAddress = "testingemailaddressandsomethingelse123@gmail.co.uk";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string EmailAddress = "testingemailaddressandsomethingelse1234@gmail.co.uk";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string EmailAddress = "joebloggerson@yahoo.co.uk";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string EmailAddress = "joebloggersonjoebloggersonjoebloggersonjoebloggersonjoe" +
                "bloggersonjoebloggersonfamilytrio@yahoo.co.uk";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMin()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Address = "";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Address = "The House, Lei";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Address = "3 House, London";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Address = "33 House, London";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Address = "Apartment 1, The Honeyhive, 115 Princess Street," +
                " Leicester, Leicestershire, LE3 8KD, United Kingdom";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Address = "Apartment 11, The Honeyhive, 115 Princess Street, Leicester," +
                " Leicestershire, LE3 8KD, United Kingdom";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Address = "Apartment 11, The Honeyhive, 1115 Princess Street, Leicester," +
                " Leicestershire, LE3 8KD, United Kingdom";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Address = "Apartment 1, 1 Princess Street, Leicester, LE3 8KD";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Address = "Apartment 11, The Honeyhive, 15 Princess Street, " +
                "Leicester, Leicestershire, LE3 8KD, United Kingdom, Apartment 11, " +
                "The Honeyhive, 15 Princess Street, Leicester, Leicestershire, LE3 8KD, United Kingdom";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMin()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Password = "";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Password = "pass1";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMin()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Password = "pass12";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Password = "pass123";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Password = "verystrongpassword123456ornotstrong654maybestrong";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Password = "verystrongpassword123456ornotstrong6541maybestrong";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Password = "verystrongpassword123456ornotstrong654maybestrong11";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Password = "verystrongpasswordindeed1";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            clsCustomer Customer = new clsCustomer();
            String Error = "";
            string Password = "verystrongpasswordindeed1verystrongpassword" +
                "indeed1verystrongpasswordindeed1verystrongpasswordindeed1";
            Error = Customer.Valid(Name, EmailAddress, Address, Password, IsEmailConfirmed, LoyaltyPoints, CreatedAt);
            Assert.AreNotEqual(Error, "");
        }


    }
}
