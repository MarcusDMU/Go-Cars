using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsCarCollection
    {
        //private data member for allcars list
        private List<clsCar> mAllCars = new List<clsCar>();

        public List<clsCar> AllCars
        {
            get
            {
                //return the count property of the private list
                return mAllCars;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                mAllCars = value;
            }
        }
        public int Count
        {
            get
            {
                //return the private data member
                return mAllCars.Count;
            }
            set
            {
                //assign the incoming value to the private data member
            }
        }

        //public constructor for the class
        public clsCarCollection()
        {
            //create an instance of the car class to store a car
            clsCar ACar = new clsCar();
            //set the car to ford
            ACar.Car = "Ford";
            //add the car to the private list of cars
            mAllCars.Add(ACar);
            //re initialise the ACar object to accept a new item
            ACar = new clsCar();
            //set the car to BMW
            ACar.Car = "BMW";
            //add the second car to the private list of cars
            mAllCars.Add(ACar);
            //the private list now contains two countries
        }
    }

}