using System;
using Tasks.Models;
using Tasks.Views.UI;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

             // Prompt the user for task name, due date
             string taskName = "test"; // for now we will declare it
             DateTime dueDate = DateTime.Now;

             // Create a task that has not yet been added to the list
             Task task = new Task(taskName,dueDate); // Constroctor

             // Call TaskList list = new TaskList(path);
             TaskList list = new TaskList();
             task = list.AddTask(task);
            */

            // Creat the menu and show it
            TaskMenu menu = new TaskMenu();
            menu.Show();
        }
    }
}
