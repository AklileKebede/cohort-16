using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Models;
using Tasks;

namespace Tasks_Tests
{
    [TestClass]
    public class TaskList_Test
    {
        [TestMethod]
        public void AddTask_Test()
        {
            //Arrange- Creat a new Task object

            TaskList tasks = new TaskList("");
            Task task = new Task("Test", DateTime.Now);

            //Act-Call AddTask
            task = tasks.AddTask(task);

            //Assert
            Assert.IsNotNull(task);
            Assert.AreEqual(1, tasks.Count);
            Assert.AreNotEqual(0, task.TaskID);
            Assert.IsTrue(task.TaskID > 0, "AddTask should return a positive integer for teh new ID");
        }
    }
}

/* Why doesn't my test show up in 
    *Is your test-class public?
    *Do you have a [TestClass]?
    *Is there a test-method?
    *Do you have a [TestMethod] attribute?
    *Is the test-method public?
    *Is teh return type of teh test-method void?
*/