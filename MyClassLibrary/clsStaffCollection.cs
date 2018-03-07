using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the allstaff list
        private List<clsStaff> mAllStaff = new List<clsStaff>();
        //public property for count
        public int Count
        { 
            get
            {
                //return the count property of the private list
                return mAllStaff.Count;
            }
            set
            {
                //we will look at this in a moment!
            }
        }
            //public property for allstaff
            public List<clsStaff> AllStaff
        {
            //getter sends the data to requesting code
            get
            {
                //return the private data member
                return mAllStaff;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                mAllStaff = value;
            }
        }

        //public constructor for the class
        public clsStaffCollection()
        {
            //create an instance of the staff class to store a staff member
            clsStaff AStaff = new clsStaff();
            //set the Staff to 16168441
            AStaff.Staff = "16168441";
            //add the staff to the private list of staff
            mAllStaff.Add(AStaff);
            //re initialise the AStaff object to accept a new item
            AStaff = new clsStaff();
            //set the staff to 16184104
            AStaff.Staff = "16184104";
            //add the second staff member to the private list of staff
            mAllStaff.Add(AStaff);
            //the private list now contains two staff members
        }
    }
}
