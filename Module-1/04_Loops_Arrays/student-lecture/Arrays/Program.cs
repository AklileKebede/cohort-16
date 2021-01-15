using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Creating an array of integers
            int[] scores = new int[3];
            scores[0] = 99;
            scores[1] = 67;
            scores[2] = 78;
            // to check how many element are in the array
            Console.WriteLine("There are " + scores.Length + " elements in the array.");
           
            // How to embed deta into string also know as string interpolation
            Console.WriteLine($"There are {scores.Length} elements in the array.");
            
            //2. Creating an array of strings
            string[] students = new string[] { "Aklile", "Luci", "Paul", "Tim" };
            Console.WriteLine($"There are {students} students in class.");
            students[1] = "Dejan";  // re-assigning a value to an array location

            //3. Create an array of characters that hold "Tech Elevator"        
            char[] characters = new char[] { 't', 'e', 'c', 'h' };

            //4. Print out the first item in each array
            Console.WriteLine($"The first element is {characters[0]}");

            // Pring the Lst element
            Console.WriteLine($"The last element is {characters[characters.Length-1]}");

            //5. Print out the 3rd item in each array
            Console.WriteLine();

            //6. Get the length of each array

            //7. Get the last index 

            //8. Update the last item in each array

            Console.ReadLine();
        }
    }
}
