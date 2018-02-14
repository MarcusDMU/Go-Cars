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
        public void RegNoExist()
        {
            clsCar ACar = new clsCar();
            Int32 RegNo = 123;
            ACar.RegNo = RegNo;
            Assert.AreEqual(ACar.RegNo, RegNo);
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

    }
}
