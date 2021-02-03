using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Aids
{
    public class PerformanceDemo
    {
        /// <summary>
        /// This piece of code demonstrates that there is a noticeable delay 
        /// to open and close a Stream Writer 1500 times even if we are printing one word.
        /// </summary>
        public static void SlowPerformance()
        {
            Stopwatch watch = new Stopwatch();            
            Console.WriteLine("Starting slow file write.");

            watch.Start();

            for (int i = 0; i < 15000; i++)//Openes the file 15000 times to write "SLOW"
            {
                using (StreamWriter sw = new StreamWriter("slow-file.txt", true))// This opens the file and closes it
                {
                    sw.WriteLine("SLOW");
                }
            }

            Console.WriteLine($"It took {watch.Elapsed} to print out the slow file.");
            Console.WriteLine();
        }

        /// <summary>
        /// This piece of code demonstrates that there is no noticeable delay
        /// when opening a file and printing out a new line 1500 times.
        /// </summary>
        public static void FastPerformance()
        {
            Stopwatch watch = new Stopwatch();
            Console.WriteLine("Starting fast file write.");

            watch.Start();


            using (StreamWriter sw = new StreamWriter("fast-file.txt", true))// Opens the file and closes it after the loop is over
            {
                for (int i = 0; i < 15000; i++)// Write "FAST" 15000 times
                {
                    sw.WriteLine("FAST");
                }
            }

            Console.WriteLine($"It took {watch.Elapsed} to print out the fast file.");
            Console.WriteLine();
        }
    }
}
