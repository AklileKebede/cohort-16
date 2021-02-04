using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Models
{
    public class Task // When we have external test we have to have 'public'
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        public Task(int taskID, string taskName, DateTime dueDate, bool isCompleted)
        {
           
            this.TaskID = taskID;
            this.TaskName = taskName;
            this.DueDate = dueDate;
            this.IsCompleted = isCompleted;
        }

        public Task(string taskName, DateTime dueDate)
        {
            this.TaskName = taskName;
            this.DueDate = dueDate;
        }
    }

}
