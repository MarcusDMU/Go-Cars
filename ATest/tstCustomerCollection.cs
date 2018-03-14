using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;
namespace ATest
{
    [TestClass]
    public class tstCustomerCollection
    {
        public object AllCustomers { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see if it exists
            Assert.IsNotNull(AllCustomers);
        }
        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    //create an instance of the class we want to create
        //    clsCarCollection AllCars = new clsCarCollection();
        //    //create some test data to assign to the property
        //    Int32 SomeCount = 1;
        //    //assign the data to the property
        //    AllCars.Count = SomeCount;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllCars.Count, SomeCount);
        //}



        [TestMethod]
        public void AllCustomersOK()
        {
            //create an instance of the class
            clsCustomerCollection Customers = new clsCustomerCollection();
            //create test data
            //We need a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //adding an item to the list
            //Item of test data
            clsCustomer TestItem = new clsCustomer();
            //set properties
            TestItem.CustomerNo = 1;
            TestItem.Customer = "Smith";
            //add item to list
            TestList.Add(TestItem);
            //assign data to property
            Customers.AllCustomers = TestList;
            //Test
            Assert.AreEqual(Customers.AllCustomers, TestList);
        }

        [TestMethod]
        public void CustomerMatchesList()
        {
            //create an instance of the class
            clsCustomerCollection Customers = new clsCustomerCollection();
            //create test data
            //We need a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //adding an item to the list
            //Item of test data
            clsCustomer TestItem = new clsCustomer();
            //set properties
            TestItem.CustomerNo = 1;
            TestItem.Customer = "Smith";
            //add item to list
            TestList.Add(TestItem);
            //assign data to property
            Customers.AllCustomers = TestList;
            //Test
            Assert.AreEqual(Customers.Count, TestList.Count);
        }
        [TestMethod]
        public void CustomerPropertyOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create test data
            Int32 SomeCount = 2;
            //assign data property
            AllCustomers.Count = SomeCount;
            //Test
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }

        [TestMethod]
        public void TwoCustomersPresent()
        {
            //create an instance of the class
            clsCustomerCollection Customers = new clsCustomerCollection();
            //test to see if values are the same
            Assert.AreEqual(Customers.Count, 2);
        }
    }
}




