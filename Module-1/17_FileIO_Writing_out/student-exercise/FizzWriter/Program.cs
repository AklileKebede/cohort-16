using System;
using System.IO;
using System.Collections.Generic;

namespace FizzWriter
{
    public class Program 
    {
        static void Main(string[] args)
        {
            string fileName = "FizzBuzz.txt"; // Creat a virable with the file name
            
            // Creates a new stream writer
            using (StreamWriter sw = new StreamWriter(fileName, false)) // Append => false, because we want to overwrite instead of appended to
            {
                // Get full path
                //string path = @"C:\Users\Student\git\aklilekebede-c\Module-1\17_FileIO_Writing_out\student-exercise"; // Path to the folder file should be created in
                //path = Path.Combine(path, fileName);

                //Call the constructor 
                FizzBuzz input = new FizzBuzz(1, 300, 3, 5);
              foreach( string num in input.FizzBuzzList())
                {
                    sw.WriteLine(num);
                }
                                
                
            }
        }
    }
}
