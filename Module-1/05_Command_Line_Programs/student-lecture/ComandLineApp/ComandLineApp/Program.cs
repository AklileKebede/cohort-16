using System;

namespace ComandLineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Ask the user for their name (method'WriteLine'= text + new line)
            //Console.WriteLine("Hello, What is you name?");

            //// Get the user's name (the method is "ReadLine")
            //string name = Console.ReadLine();

            //// Greet the user
            //Console.WriteLine($"Hello there, {name}");

            //// Ask for hight
            //Console.Write("How tall are you in inches? "); // next text will be in the same line as them method 'Write'

            ////Read height from user
            //string heightAsString = Console.ReadLine();
            //int hightInches = int.Parse(heightAsString);

            //// convert inches to feet
            //int feet = hightInches / 12;
            //int inches = hightInches % 12;
            //Console.WriteLine($"Did you know that is {feet} and {inches} inches?")

            //// Ask if the user is wearing flannel
            //Console.Write("Are you wearing flannel right now (true / false)? ");
            //string input = Console.ReadLine();
            //bool isWearingFlannel = bool.Parse(input);

            //// If yes, adn they are over 6 feet, we will tell them they look like a lamberjack/jill
            //if (isWearingFlannel)
            //{
            //    Console.WriteLine("Thanks for participating");
            //}
            //else
            //{
            //    Console.WriteLine("Maybe next week");
            //}

            ////using the split method

            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();

            //string[] words = sentence.Split(" "); //Split method being a space
            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            // using teh join

            string newSentence = string.Join("--", words);//when joning you need to tell it type.Join("joiner type", arr name);
            Console.WriteLine(newSentence);

            //Ask for a series of comma=separated number, add them up and tell the user the SUM

            // prompt user for a list of cs-numbers like "10,20,30"
            Console.WriteLine("Enter a series of comma-separated numbers; ");
            string input = Console.ReadLine();

            // split the string into arr of "string-numbers" like ["10","20","30"]
            string[] stringNumbers = input.Split(",");

            // Initialize a SUM variable to 0
            int sum = 0;
            // loop throught the arr of string-numbers
            for (int i = 0; i < stringNumbers.Length; i++)
            {
                // Parse the element into an int
                int num = int.Parse(stringNumbers[i]);

                // Add the value to the SUM
                sum += num;
              
            }

            // Once the loop is finished, tell the user the SUM
            Console.WriteLine($"These numbers add up to {sum}.");
        }
    }
}
