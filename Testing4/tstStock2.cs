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
    }
}
