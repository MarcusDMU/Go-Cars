using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsCustomerCollection
    {
        //priavte data member for allCustomers
        private List<clsCustomer> mAllCustomers = new List<clsCustomer>();
        public List<clsCustomer> AllCustomers
        {
            get
            {
                //return the private data member
                return mAllCustomers;
            }
            //setter accepts accepts the data other objects
            set
            {
                //assign the incoming value to the private data member
                mAllCustomers = value;
            }
                }
        public int Count
        {
            
            get
            {
                //return the count property of the private list
                return mAllCustomers.Count;
            }
            set
            {
                //

            }

        }
        public clsCustomerCollection()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //set name to smith
            ACustomer.Customer = "Smith";
            //add the customer to private list
            mAllCustomers.Add(ACustomer);
            //accept new item
            ACustomer = new clsCustomer();
            //set Customer to "blogs"
            ACustomer.Customer = "Blogs";
            //add second customer to private list
            mAllCustomers.Add(ACustomer);
            //private list contains two customers
    }
   
    }
}