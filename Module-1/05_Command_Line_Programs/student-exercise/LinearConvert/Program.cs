using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length: ");
            string input = Console.ReadLine();
            double inputNumber = double.Parse(input);

            // prompt a user to enter a string with f/c
            Console.Write("Is the measurement in (m)eter, or (f)eet? ");
            string hight = Console.ReadLine();

            // If answer f

            if (hight == "f")
            {
                int output = (int)(inputNumber *0.3048);
                Console.WriteLine($"{input}f is {output}m. ");
            }
            else if (hight == "m")
            {
                double output = (int)(inputNumber * 3.2808399);
                Console.WriteLine($"{input}m is {output}f. ");
            }
        }
    }
}
