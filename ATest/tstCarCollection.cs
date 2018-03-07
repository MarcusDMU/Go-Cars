using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace ATest
{
    [TestClass]
    public class tstCarCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCars);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllCars.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.Count, SomeCount);
        }

        [TestMethod]
        public void AllCarsOK()
        {
            //create an instance of the class we want to create
            clsCarCollection Cars = new clsCarCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCar> TestList = new List<clsCar>();
            //add an item to the list
            //create an item of test data
            clsCar TestItem = new clsCar();
            //set its properties
            TestItem.CarNo = 1;
            TestItem.Car = "Ford";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Cars.AllCars = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Cars.AllCars, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance of the class we want to create
            clsCarCollection Cars = new clsCarCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCar> TestList = new List<clsCar>();
            //add an item to the list
            //create the item of test data
            clsCar TestItem = new clsCar();
            //set its properties
            TestItem.CarNo = 1;
            TestItem.Car = "Ford";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Cars.AllCars = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Cars.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoCarsPresent()
        {
            //create an instance of the class we want to create
            clsCarCollection Cars = new clsCarCollection();
            //test to see that the two values are the same
            Assert.AreEqual(Cars.Count, 2);
        }
    }
}
