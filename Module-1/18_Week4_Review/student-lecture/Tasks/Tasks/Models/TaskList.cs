using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tasks.Models
{
    public class TaskList
    {
        private const string FILE_SEPARATOR_CHAR = "|||";

        // This is whare our working list of tasks is stored
        private List<Task> taskList = new List<Task>();
        private int maxID = 0;


        public Task[] List  // Public access to the list of tasks and will let the user to add or remove tasks
        {
            get // Derived property, from taskList
            {
                return this.taskList.ToArray();
            }
        }
        public int Count // Tells the amout of tasks in the list
        {
            get // Derived property, from taskList
            {
                return this.taskList.Count;
            }
        }

        // This points to the file that persistently holds our tasks

        public string Path { get; }
        /// <summary>
        /// Creates a new TaskList object
        /// </summary>
        /// <param name="path">Path to the file stores task info</param>
        public TaskList(string path)
        {
            this.Path = path;
            Load();
        }

        /// <summary>
        /// Saves all the Tasks that are in the list into a file at Path
        /// </summary>
        private bool Save()
        {
            try
            {
                // Open the file for Overwrite
                using (StreamWriter sw = new StreamWriter(Path, false))
                {
                    foreach (Task task in this.taskList)
                    {
                        string outputLine = string.Join(FILE_SEPARATOR_CHAR, task.TaskID, task.TaskID, task.TaskName, task.DueDate, task.IsCompleted);
                        sw.WriteLine(outputLine);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// Open the file at Path and read it to create Task instances to load into taskList
        private bool Load()
        {
            this.taskList.Clear();
            this.maxID = 0;
            try
            {
                using (StreamReader sr = new StreamReader(this.Path))
                {
                    while (!sr.EndOfStream)
                    {
                        string inputLine = sr.ReadLine();
                        string[] fields = inputLine.Split(FILE_SEPARATOR_CHAR);
                        // Create a Task fromthe data
                        Task task = new Task(int.Parse(fields[0]), fields[1], DateTime.Parse(fields[2]), bool.Parse(fields[3]));

                        // See if this is the highst ID
                        this.maxID = Math.Max(this.maxID, task.TaskID);
                        //Add the task to the list
                        this.taskList.Add(task);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                // Log to some error lot
                return false;
            }
        }

        public Task AddTask(Task task)
        {
            //TODO write code
                // Fill in the id if needed
                if (task.TaskID == 0)
            {
                task.TaskID = GetNextId();
                task.IsCompleted = false; // Since we're Adding new task- it isn't completed
            }
            this.taskList.Add(task);

            // Make sure the list is saved to the file
            Save();

            return task;
        }

        private int GetNextId()
        {
            this.maxID++;
            return this.maxID;
        }
    }
}
