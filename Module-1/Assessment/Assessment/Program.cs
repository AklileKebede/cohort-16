using System;
<<<<<<< HEAD
using System.IO;
=======
using System.Collections.Generic;
using System.IO;

using Assessment.Models;
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4

namespace Assessment
{
    class Program
    {
        
        static void Main(string[] args)
        {
<<<<<<< HEAD
            // TODO: Create instances of your object here and call methods.
            Car Cobalt = new Car(2008, "Shevy", false);
            Car Forester = new Car(1999, "Subaru", true);

            // and use the object(s) to test your methods.
            // 1. ECheck(int yearToCheck)
            // 2. ToString()

            Console.WriteLine("Test Method ECheck");
            Console.WriteLine(Cobalt.ECheck(2023)); // False
            Console.WriteLine(Forester.ToString()); // CAR - 1999 - Subaru

            string file = "CarInput.csv,";

           using (StreamReader sr = new StreamReader(file))// not reading.
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    string[] carFields = line.Split(",");
                    int year = int.Parse(carFields[0]);
                    Console.WriteLine(year);
                }
            }
=======
          // TODO: Create instances of your object here and call methods.
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
        }

    }
}
