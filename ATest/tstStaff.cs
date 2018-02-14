﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace ATest
{
    [TestClass]
    public class tstStaff
    {
        {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff ACar = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(ACar);

        }

        [TestMethod]
        public void StaffExist()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeSurname = "Smith";
            //asssign the data to the property
            AStaff.Surname = SomeSurname;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Surname, SomeSurname);

        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 StaffID = 1;
            //assign the data to the property
            AStaff.StaffID = StaffID;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffID, StaffID);
        }

        [TestMethod]
        public void SurnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeSurname = "";
            //invoke the method
            OK = AStaff.Valid(SomeSurname);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void SurnameMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeSurname = "a";
            //invoke the method
            OK = AStaff.Valid(SomeSurname);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SurnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeSurname = "aa";
            //invoke the method
            OK = AStaff.Valid(SomeSurname);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SurnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeSurname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            OK = AStaff.Valid(SomeSurname);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SurnameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeSurname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            OK = AStaff.Valid(SomeSurname);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SurnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeSurname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            OK = AStaff.Valid(SomeSurname);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void SurnameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeSurname = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            OK = AStaff.Valid(SomeSurname);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SurnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeSurname = "";
            //pad the string with 'a' characters
            SomeSurname = SomeSurname.PadRight(500, 'a');
            //invoke the method
            OK = AStaff.Valid(SomeSurname);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }
    }
}
