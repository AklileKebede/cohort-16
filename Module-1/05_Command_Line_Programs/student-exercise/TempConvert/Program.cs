using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*Write a command line program which prompts a user to enter a temperature,
             * and whether it's in degrees (C)elsius or (F)ahrenheit. 
             * Convert the temperature to the opposite degrees,
             * and display the old and new temperatures to the console.
             */

            // prompt a user to enter a stringTemp  // read user input 
            // convert string-temp to doubleTemp

            Console.Write("Please enter the temperature: ");
            string input = Console.ReadLine();
            int inputNumber = int.Parse(input);

            // prompt a user to enter a string with F/C
            Console.Write("Is the temperature in (C)elsius, or (F)ahrenheit? ");
            string temp = Console.ReadLine();

            // If answer F
            
            if (temp == "F")
            {
                double output = (int)((inputNumber - 32) / 1.8);
                Console.WriteLine($"{input}F is {output}C. ");
            }
            else if (temp == "C")
            {
                double output = (int)((inputNumber * 1.8) + 32);
                Console.WriteLine($"{input}C is {output}F. ");
            }
            
            // calculate doubleTemp to c=>((doubleTemp - 32) / 8) 
            // output text (stringTempF is newTempC)
            // else if C
            // calculate int temp to F => (doubleTemp * 1.8 +32)

        }
    }
}
