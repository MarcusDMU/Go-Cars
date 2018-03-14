using System;

namespace MyClassLibrary
{
    public class clsCar
    {
        public clsCar()
        {
        }

        public string Car { get; set; }
        public int CarNo { get; set; }
        public int Doors { get; set; }
        public decimal EngineSize { get; set; }
        public string FuelType { get; set; }
        public string GearBox { get; set; }
        public string Manufacturer { get; set; }
        public int RegNo { get; set; }
        public int Seats { get; set; }
        public int Year { get; set; }

        public bool Find(int RegNo)
        {
            //always return true
            return true;
        }

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