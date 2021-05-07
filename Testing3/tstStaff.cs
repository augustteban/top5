﻿using System;
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
            string TestData = "Name";
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
            Boolean TestData = true / false;
            Staff.IsManager = TestData;
            Assert.AreEqual(Staff.IsManager, TestData);
        }

    }
}