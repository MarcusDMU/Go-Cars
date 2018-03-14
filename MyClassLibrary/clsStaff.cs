using System;

namespace MyClassLibrary
{
    public class clsStaff
    {
        public int AddressNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Forename { get; set; }
        public string Staff { get; set; }
        public int StaffID { get; set; }
        public string Surname { get; set; }
        public long TelephoneNo { get; set; }
        public bool Find(int StaffID)
        {
            //always return true
            return true;
        }

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