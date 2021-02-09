using System;
using System.Collections.Generic;
using System.IO;
using System.Collections.Generic;

namespace FileIO_lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a file in the local folder to write result to
<<<<<<< HEAD

            // using here...
            string fileName = "GitFolders.txt";

            using (StreamWriter sw = new StreamWriter(fileName, false))// false=> File will be overwritten each time the program is run
=======
            string outputPath = "GitFolders.txt";
            
            using (StreamWriter writer = new StreamWriter(outputPath,false))
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            {
                // Get a list of folders from a directory on disk
                string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                path = Path.Combine(path, "GIT");
                Console.WriteLine($"Getting folders in {path}");
                DirectoryInfo dir1 = new DirectoryInfo(path);

                // First, write the top-level folder
<<<<<<< HEAD
                sw.WriteLine($"These are the folders under{dir1.FullName}");

                // Find all the folders in this folder
                IEnumerable<DirectoryInfo> folders = dir1.EnumerateDirectories(); // OR just dir1.EnumerateDirectories();
                
                //folders is the name of the Dicrectory
                foreach(DirectoryInfo folder in folders)
                {
                    sw.WriteLine($"\t{folder.Name}");
                
                    foreach(DirectoryInfo subfolder in folder.EnumerateDirectories())
                    {
                        sw.WriteLine($"\t{subfolder.Name}");
                    }
                }
            }// The file is now closed.  We can open it again for append to add more lines


            // using here...
            using(StreamWriter sw = new StreamWriter(fileName,true)) // appened is true=> Text will be added to the end of file
=======
                writer.WriteLine($"These are the folders under {dir1.FullName}:");
                
                // Find all the folders in this folder
                IEnumerable<DirectoryInfo> folders = dir1.EnumerateDirectories();
                foreach (DirectoryInfo folder in folders) {
                    writer.WriteLine($"\t{folder.Name}");
                    foreach (DirectoryInfo subFolder in folder.EnumerateDirectories()) {
                        writer.WriteLine($"\t\t{subFolder.Name}");
                    }
                }
            }

            // The file is now closed.  We can open it again for append to add more lines
            using (StreamWriter sw = new StreamWriter(outputPath,true))
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            {
                for (int i = 1; i <= 100; i++)
                {
                    sw.Write($"{i:000} ");
                    if (i % 10 == 0)
                    {
                        sw.WriteLine();
                    }
                }
            }

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
