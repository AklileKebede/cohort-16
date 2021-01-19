using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use our custom Person data type (class)
          //  CreatePerson();

            string name = "Ada Lovelace";


            // Strings are actually arrays of characters (char). 
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e
            Console.WriteLine($"First char: {name[0]}, Last char: {name[name.Length-1]}");
            // Console.WriteLine("First and Last Character. ");

            // 2. How do we write code that prints out the first three characters
            // Output: Ada
            Console.WriteLine($"First 3 characters: {name.Substring(0,3)}");
            // Console.WriteLine("First 3 characters: ");

            // 3. Now print out the first three and the last three characters
            // Output: Adaace
            Console.WriteLine($"First and Last 3 characters: {name.Substring(0, 3)}{name.Substring(name.Length-3,3)}");
            // Console.WriteLine("Last 3 characters: ");

            // 4. What about the last word?
            // Output: Lovelace
            string[] words = name.Split(" ");
            Console.WriteLine($"Last Word: {words[words.Length-1]}");

            int spaceIndex = name.IndexOf(" ");// int spaceIndex = name.LastIndexOf(" ");
            Console.WriteLine($"Last Word: {name.Substring(spaceIndex+1)}");
            // Console.WriteLine("Last Word: ");

            // 5. Does the string contain inside of it "Love"?
            // Output: true
            string lowerName = name.ToLower(); // this will cahnge all the caracters to lower case
            Console.WriteLine($"Contains \"Love\": {lowerName.Contains("Love")}");
            // Console.WriteLine("Contains \"Love\"");

            // 6. Where does the string "lace" show up in name?
            // Output: 8

            Console.WriteLine($"Index of \"lace\": {name.IndexOf("lace")}"); // if it was not there the answer will be -1
            // Console.WriteLine("Index of \"lace\": ");

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3
            int countOfAs = 0;
                for (int i=0; i < name.Length; i++)
            {
                // "chains" two methods together, in this case this pulls the string and changes it to lower case
                if (name.Substring(i, 1).ToLower() == "a")
                {
                    countOfAs++;
                }
            }
            Console.WriteLine($"Number of \"a's\": {countOfAs}");
            // Console.WriteLine("Number of \"a's\": ");

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"
            name = name.Replace("Ada","Ada, Countes of Lovelace");
            Console.WriteLine(name);
            // Console.WriteLine(name);

            // 9. Set name equal to null.
            name = null;

            // 10. If name is equal to null or "", print out "All Done".
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("All Done.");
            }
            // Console.ReadLine();
        }

        public static void CreatePerson()
        {
            // Create a new Person object from the Person class

                //1. Declare
            Person instructor;
            
             // 2. Allocate memory (new)
            instructor = new Person();

            // Assign Set the properties of this object
            instructor.FirstName = "Ben";
            instructor.LastName = "Kennedy";
            instructor.HightInches = 71;
            // Create another person and set its value.
                // 1. Declare AND Allocate
            Person student = new Person();
            student.FirstName = "Ariel";
            student.LastName = "Zaviezo";
            student.HightInches = 72;

        }
    }

}