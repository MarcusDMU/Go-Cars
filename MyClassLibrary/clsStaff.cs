using System;

namespace MyClassLibrary
{
    public class clsStaff
    {
        public string Staff { get; set; }
        public int StaffID { get; set; }
        public string Surname { get; set; }

        public bool Valid(string SomeSurname)
        {
            //boolean flag to indicate that all is OK
            Boolean OK = true;
            //if the name of the model is not blank
            if (SomeSurname == "")
            {
                //flag an error
                OK = false;
            }
            //if the name of the model is more than 50 charaters
            if (SomeSurname.Length > 50)
            {
                //flag an error
                OK = false;
            }
            return OK;
        }
    }
}