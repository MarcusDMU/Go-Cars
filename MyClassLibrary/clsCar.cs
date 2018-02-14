using System;

namespace MyClassLibrary
{
    public class clsCar
    {
        public clsCar()
        {
        }

        public string Car { get; set; }
        public int RegNo { get; set; }

        public bool Valid(string SomeModel)
        {
            //boolean flag to indicate that all is OK
            Boolean OK = true;
            //if the name of the model is not blank
            if (SomeModel == "")
            {
                //flag an error
                OK = false;
            }
            //if the name of the model is more than 50 charaters
            if (SomeModel.Length > 50)
            {
                //flag an error
                OK = false;
            }
            return OK;

        }
    }
}