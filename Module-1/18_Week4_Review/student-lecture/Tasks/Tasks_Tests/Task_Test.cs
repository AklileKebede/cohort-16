using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks.Models;
using Tasks;
using System;

namespace Tasks_Tests
{
    [TestClass]
    public class Task_Test
    {
        [TestMethod]
        public void TestConstructor1()
        {
            //Arrange- nothing to do here
            DateTime dueDate = DateTime.Now; //DataTime: At the class level give me the current time. It is a static property.

            //Act- Creat a task using the 2-parameter constructor
            Task task = new Task("Test Name", dueDate);
            //Assert

            Assert.AreEqual(0, task.TaskID);
            Assert.AreEqual(false, task.IsCompleted);
            Assert.AreEqual("Test Name", task.TaskName);
            Assert.AreEqual(dueDate, task.DueDate);

        }
    }

    /* Checklist for why I cannot reference my "class under test".
        * Is my Test project referencing (Dependencies-> Projects) the "target" project?
        * Is the "target" class public?
        * Is the "target method" public?
        */
}
