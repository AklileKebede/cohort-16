using System;
using System.IO;
using System.Collections.Generic;

namespace file_io_part1_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the fully qualified name of the file to read in for quiz questions:");
            string questionFile = Console.ReadLine();
            //string questionsFile = @"C:\Users\Student\git\aklilekebede-c\Module-1\16_FileIO_Reading_in\student-exercise\sample-quiz-file.txt";

            using (StreamReader reader = new StreamReader(questionFile))
            {
                while (!reader.EndOfStream)
                {
                    // Call the Constructor // Get & Read line
                    Quiz_Question q = new Quiz_Question(reader.ReadLine());
                    Console.WriteLine($"{q.Question}");
                    int correctAnswer = 1;
                    foreach(KeyValuePair<int,(string,bool)> kvp in q.answerOptions)
                    {
                        Console.WriteLine($"{kvp.Key}. {kvp.Value.Item1}");
                        if (kvp.Value.Item2 == true)
                        {
                            correctAnswer = kvp.Key;
                        }
                         
                    }
                    Console.Write("Your answer: ");
                    string playerAnswer = Console.ReadLine();
                    int input = Int32.Parse(playerAnswer.Trim());
                    if (input == correctAnswer)
                    {
                        Console.WriteLine("RIGHT!");
                    }
                    else
                    {
                        Console.WriteLine("WRONG!");
                    }
                   
                }
            }


        }
    }
}
