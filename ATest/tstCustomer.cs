using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace ATest
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //test
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void CustomerEmailOK()
        {
            //Instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //create test data
            string SomeEmail = "Luke.rayner@hotmail.com";
            //Assign data to property
            ACustomer.Email = SomeEmail;
            //test
            Assert.AreEqual(ACustomer.Email, SomeEmail);
        }
        [TestMethod]
        public void CustomerNoOK()
        {
            //Instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //create test data
            Int32 CustomerNo = 1;
            //Assign data to property
            ACustomer.CustomerNo = CustomerNo;
            //test
            Assert.AreEqual(ACustomer.CustomerNo, CustomerNo);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //Instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //store result of validation
            Boolean OK = false;
            //create test data
            string SomeEmail = "Luke.rayner@hotmail.com";
            //request method
            OK = ACustomer.Valid(SomeEmail);
            //test
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerMinLessOne()
        {
            //Instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //store result of validation
            Boolean OK = false;
            //create test data
            string SomeEmail = "";
            //request method
            OK = ACustomer.Valid(SomeEmail);
            //test
            Assert.IsFalse(OK);
        }
        [TestMethod]
        public void CustomerMinBoundary()
        {
            //Instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //store result of validation
            Boolean OK = false;
            //create test data
            string SomeEmail = "a";
            //request method
            OK = ACustomer.Valid(SomeEmail);
            //test
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerMinPlusOne()
        {
            //Instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //store result of validation
            Boolean OK = false;
            //create test data
            string SomeEmail = "aa";
            //request method
            OK = ACustomer.Valid(SomeEmail);
            //test
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerMaxLessOne()
        {
            //Instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //store result of validation
            Boolean OK = false;
            //create test data
            string SomeEmail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //request method
            OK = ACustomer.Valid(SomeEmail);
            //test
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerMaxBoundary()
        {
            //Instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //store result of validation
            Boolean OK = false;
            //create test data
            string SomeEmail = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //request method
            OK = ACustomer.Valid(SomeEmail);
            //test
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerMaxPlusOne()
        {
            //Instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //store result of validation
            Boolean OK = false;
            //create test data
            string SomeEmail = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //request method
            OK = ACustomer.Valid(SomeEmail);
            //test
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerMid()
        {
            //Instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //store result of validation
            Boolean OK = false;
            //create test data
            string SomeEmail = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //request method
            OK = ACustomer.Valid(SomeEmail);
            //test
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CustomerExtremeMax()
        {
            //Instance of a class
            clsCustomer ACustomer = new clsCustomer();
            //store result of validation
            Boolean OK = false;
            //declare variable
            string SomeEmail = "";
            //Pad string 
            SomeEmail = SomeEmail.PadRight(500, 'a');
            //request method
            OK = ACustomer.Valid(SomeEmail);
            //test
            Assert.IsFalse(OK);
        }






    }
}
