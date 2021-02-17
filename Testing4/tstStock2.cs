using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStock2
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock2 AnStock2 = new clsStock2();
            Assert.IsNotNull(AnStock2);
        }

        [TestMethod]
        public void ProductidPropertOK()
        {
            clsStock2 AnStock2 = new clsStock2();
            int TestData = 1;
            AnStock2.Stock2 = TestData;
            Assert.AreEqual(AnStock2.Stock2, TestData);
        }
           
        [TestMethod]   
        public void ProductNameOK()
        {
            clsStock2 Anstock2 = new clsStock2();
            string TestData = "Top";
            Anstock2.ProductName = TestData;
            Assert.AreEqual(Anstock2.ProductName, TestData);

        }
    }
}
