using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace ATest
{
    [TestClass]
    public class tstCar
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //test to see that it exists
            Assert.IsNotNull(ACar);
        }

        [TestMethod]
        public void ModelExist()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            string SomeModel = "Ford";
            //asssign the data to the property
            ACar.Car = SomeModel;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Car, SomeModel);
        }

        [TestMethod]
        public void RegNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            Int32 TestData = 123;
            //assign the data to the property
            ACar.RegNo = TestData;
            //test to see tha the two values are the same
            Assert.AreEqual(ACar.RegNo, TestData);
        }

        [TestMethod]
        public void ManufacturerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            string TestData = "Ford";
            //assign the data to the property
            ACar.Manufacturer = TestData;
            //test to see tha the two values are the same
            Assert.AreEqual(ACar.Manufacturer, TestData);
        }

        [TestMethod]
        public void SeatsPropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            Int32 TestData = 5;
            //assign the data to the property
            ACar.Seats = TestData;
            //test to see tha the two values are the same
            Assert.AreEqual(ACar.Seats, TestData);
        }

        [TestMethod]
        public void YearPropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            Int32 TestData = 2015;
            //assign the data to the property
            ACar.Year = TestData;
            //test to see tha the two values are the same
            Assert.AreEqual(ACar.Year, TestData);
        }

        [TestMethod]
        public void DoorsPropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            Int32 TestData = 5;
            //assign the data to the property
            ACar.Doors = TestData;
            //test to see tha the two values are the same
            Assert.AreEqual(ACar.Doors, TestData);
        }

        [TestMethod]
        public void EngineSizePropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            decimal TestData = 1.4m;
            //assign the data to the property
            ACar.EngineSize = TestData;
            //test to see tha the two values are the same
            Assert.AreEqual(ACar.EngineSize, TestData);
        }

        [TestMethod]
        public void FuelTypePropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            string TestData = "Petrol";
            //assign the data to the property
            ACar.FuelType = TestData;
            //test to see tha the two values are the same
            Assert.AreEqual(ACar.FuelType, TestData);
        }

        [TestMethod]
        public void GearBoxPropertyOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            string TestData = "Manual";
            //assign the data to the property
            ACar.GearBox = TestData;
            //test to see tha the two values are the same
            Assert.AreEqual(ACar.GearBox, TestData);
        }

        [TestMethod]
        public void ValidExist()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign
            string SomeModel = "Ford";
            //invoke the method
            OK = ACar.Valid(SomeModel);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ModelMinLessOne()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeModel = "";
            //invoke the method
            OK = ACar.Valid(SomeModel);
            //test to see that the result
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ModelMinBoundary()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeModel = "a";
            //invoke the method
            OK = ACar.Valid(SomeModel);
            //test to see that the result
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ModelMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeModel = "ab";
            //invoke the method
            OK = ACar.Valid(SomeModel);
            //test to see that the result
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ModelMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeModel = "abcdeabcdeabcdeabcdeabcdeabcdeabcdeabcdeabcdeabcd";
            //invoke the method
            OK = ACar.Valid(SomeModel);
            //test to see that the result
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ModelMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeModel = "abcdeabcdeabcdeabcdeabcdeabcdeabcdeabcdeabcdeabcde";
            //invoke the method
            OK = ACar.Valid(SomeModel);
            //test to see that the result
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ModelMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeModel = "abcdeabcdeabcdeabcdeabcdeabcdeabcdeabcdeabcdeabcdea";
            //invoke the method
            OK = ACar.Valid(SomeModel);
            //test to see that the result
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ModelMid()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeModel = "abcdeabcdeabcdeabcdeabcde";
            //invoke the method
            OK = ACar.Valid(SomeModel);
            //test to see that the result
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ModelExtremeMax()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeModel = "";
            //pad the string with 'a' charachter
            SomeModel = SomeModel.PadRight(500, 'a');
            //invoke the method
            OK = ACar.Valid(SomeModel);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 RegNo = 1234;
            //invoke the method
            Found = ACar.Find(RegNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

    }
}
