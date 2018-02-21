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
            //set
            //{
            //    //assign the incoming value to the private data member
            //    mAllCars = value;
            //}
        }
    }

}