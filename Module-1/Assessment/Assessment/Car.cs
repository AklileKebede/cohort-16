using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class Car
    {
        public int YearManufactured { get; set; }
        public string Make { get; set; }
        public bool IsClassicCar { get; set; }
        public int Age { get; set; }

        public Car(int yearManufactured, string make, bool isClassicCar)
        {
            this.YearManufactured = yearManufactured;
            this.Make = make;
            this.IsClassicCar = isClassicCar;
            this.Age = DateTime.Now.Year - this.YearManufactured;
        }

        public bool ECheck(int yearToCheck)
        {
            
            
            if (this.YearManufactured < 4 || this.YearManufactured > 25)
            {
                return false;
            }
            else if ( this.YearManufactured%2==0 && yearToCheck%2==0)// if Even-model year vehicles must be tested if yearToCheck is even.
            {
                return true;
            }
            else if (this.YearManufactured%2!=0 && yearToCheck%2!=0) // Odd-model year vehicles must be tested if yearToCheck is odd.
            {
                return true;
            }
            return true;

        }

        public override string ToString()
        {
            return $"CAR - {this.YearManufactured} - {this.Make}";
        }



    }
}
