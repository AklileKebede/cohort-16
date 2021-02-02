using System;
using System.Collections.Generic;
using System.IO;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Ask the user for the file path
            Console.WriteLine("What is fully qualified name of the file that should be searched?");
            string pathInput = Console.ReadLine();
            //1. Ask the user for the search string
            Console.WriteLine("What is the search word you are looking for?");
            string wordInput = Console.ReadLine();
            //3.Ask the user if the search should be case insensitive
            Console.WriteLine(@"Should the search be case sensitive? (Y\N)");
            string sensitivityInput = Console.ReadLine();
            //---------------------------------------------------------------
            /*
             * if (sensitive)
             * {do whatever}
             * else
             * {already existing code}
             * 
             */
            //3. Open the file
            try
            {
                using (StreamReader reader = new StreamReader(pathInput))
                {
                    int lineNumber = 1;
                    //4. Loop through each line in the file
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        // if sensitivityInput==N
                        // then 
                        if (sensitivityInput == "N")
                        {
                            if (line.ToLower().Contains(wordInput.ToLower()))
                            {
                                
                                Console.WriteLine($"{lineNumber}) {line}");
                            }
                        }
                        else
                        {
                            if (line.Contains(wordInput))
                            {
                                //5. If the line contains the search string, print it out along with its line number
                                Console.WriteLine($"{lineNumber}) {line}");
                            }

                        }
                        lineNumber++;
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("The file does not exist in the location.");
                Console.WriteLine($"{ex.Message}");
            }


        }
    }
}
