using System;
using System.IO;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace FileSplitter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Where is the input file (please include the path to the file)? ");
            string inputFullPath = Console.ReadLine();

            Console.Write("How many lines of text (max) should there be in the split files? ");
            int linesPerFile = int.Parse(Console.ReadLine());

            // Count the number of lines in the file
            int lineCount = 0;
            using (StreamReader reader = File.OpenText(inputFullPath))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }
            // Print-out the number of lines in the input file
            Console.WriteLine($"The input file has {lineCount} lines of text.");

            // numberOfFiles  needed is the number of linesPerFile/lineCount
            int numberOfFiles = linesPerFile % lineCount;

            List<string> outputFileNameList = new List<string>();// generate list of fileNames
            if (numberOfFiles == 0)//number of file names need to be created number of linesPerFile%lineCount==0 
            {

                for (int i = 1; i <= numberOfFiles; i++)
                {
                    outputFileNameList.Add($"Generating input-{i}.txt");
                }
            }
            else
            {
                for (int i = 1; i <= numberOfFiles + 1; i++)
                {
                    outputFileNameList.Add($"Generating input-{i}.txt");
                }
            }

            //string inputFile = "input.txt"
            // string outputFile ="outputPartFile.text"


            //Open the test file using StreamReader(inputFile)
            using (StreamReader r = new StreamReader(inputFullPath))
            {
                // read each line and store them to an index with a line

                // r.ReadToEnd(); //Reading the file a a whole
                // creat list with 
                // start with line 1
                
                while (!r.EndOfStream)
                    
                {

                    for (int i=0; i <= outputFileNameList.Count; i++)
                    {
                        using (StreamWriter w = new StreamWriter(outputFileNameList[i]))
                        {

                        }
                    }
                    
                }
                
            }
            //Open a SreamWriter (outputPartFile.text

            // while not at EndOfStream

            //for i=0; i<(num user put); i++

            // Read line
            // Write line to output file

        }



    }
}
