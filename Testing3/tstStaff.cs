using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Testing6
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff Staff = new clsStaff();
            Assert.IsNotNull(Staff);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            clsStaff Staff = new clsStaff();
            int TestData = 0;
            Staff.StaffID = TestData;
            Assert.AreEqual(Staff.StaffID, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            clsStaff Staff = new clsStaff();
            string TestData = "Staff Name";
            Staff.Name = TestData;
            Assert.AreEqual(Staff.Name, TestData);
        }


        [TestMethod]
        public void JobRolePropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            string TestData = "Job Role";
            AnStaff.StaffNo = TestData;
            Assert.AreEqual(Staff.JobRole, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsStaff Staff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AnAddress.CountyNo = TestData;
            Assert.AreEqual(Staff.DateAdded, TestData);
        }

        [TestMethod]
        public void IsManagerPropertyOK()
        {
            clsStaff Staff = new clsStaff();

            Staff.IsManager = TestData;
            Assert.AreEqual(Staff.IsManager, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff Staff = new clsStaff();
            Boolean Found = false;
            Int32 StaffID = 1;
            Found = Staff.Find(StaffID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            clsStaff Staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found =Staff.Find(StaffID);
            if (Staff.StaffID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            clsStaff Staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = Staff.Find(StaffID);
            if (Staff.StaffName != "Staff Name")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestJobRoleFound()
        {
            clsStaff Staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = Staff.Find(StaffID);
            if (Staff.JobRole != "Job Role")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsStaff Staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = Staff.Find(StaffID);
            if (Staff.CreatedAt != Convert.ToDateTime ("20/03/2021"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsManagerFound()
        {
            clsStaff Staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = Staff.Find(StaffID);
            if (Staff.IsManager != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}


