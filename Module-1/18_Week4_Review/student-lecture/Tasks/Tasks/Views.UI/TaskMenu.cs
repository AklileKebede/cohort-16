using MenuFramework;
using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Models;

namespace Tasks.Views.UI
{
    public class TaskMenu : ConsoleMenu
    {
        private TaskList tasks = new TaskList("Tasks.txt");
        public TaskMenu()
        {
            AddOption("Add a Task", AddNewTask);
            AddOption("Exit", Exit);
        }

        protected override void OnBeforeShow()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine("==========================        Tasks!       ========================");
            Console.WriteLine("=======================================================================");
            Console.WriteLine("Here is where we would list the tasks to the user...");

        }

        private MenuOptionResult AddNewTask()
        {
            // Prompt the user for task information
            string taskName = GetString("Enter task name: ");
            if (taskName.Length == 0)// Equivalent to (taskName =="")
            {
                return MenuOptionResult.DoNotWaitAfterMenuSelection;
            }

            //Due Date
            DateTime dueDate = GetDate("Enter due date: ", DateTime.Today);

            // Creat a new Task instance
            Task task = new Task(taskName, dueDate);

            // Add the task to the taskList
            task = this.tasks.AddTask(task);

            Console.WriteLine($"Task {task.TaskID} was created.");
            return MenuOptionResult.WaitAfterMenuSelection; // This will pause so the user can read the cw message;
        }
    }
}
