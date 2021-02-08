using System;
using System.IO;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
