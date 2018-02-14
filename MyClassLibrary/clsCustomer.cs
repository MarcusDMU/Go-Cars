using System;

namespace MyClassLibrary
{
    public class clsCustomer
    {
        public int CustomerNo { get; set; }
        public string Email { get; set; }

        public bool Valid(string SomeEmail)
        {
            Boolean OK = true;
            if (SomeEmail == "")
            {
                OK = false;
            }
            if (SomeEmail.Length > 50)
            {
                OK = false;
            }
            return OK;

        }

    }

}