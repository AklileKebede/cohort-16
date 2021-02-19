using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectOrganizer.DAL;
using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace ProjectOrganizer_IntegrationTests
{
    [TestClass]
    public class EmployeeDAO_Test
    {
        const string connectionString = "Server=.\\SQLExpress;Database=EmployeeDB_Test;Trusted_Connection=True;";
        private EmployeeSqlDAO dao;

        [TestInitialize]
        public void Arranger()
        {
            string path = "DBSetup.sql";

            string readDBSetup = File.ReadAllText(path);

            using (SqlConnection connection= new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(readDBSetup, connection);
                command.ExecuteNonQuery();
            }

            // Arrange
            //Establish the "known state" of the database
            dao = new EmployeeSqlDAO(connectionString);
        }

        [TestMethod]
        public void GetEmployeesTest()
        {
            //Act
            IList<Employee> employees = dao.GetAllEmployees();

            //Assert
            Assert.AreEqual(6, employees.Count);

            ListLoopTests(employees);

        }

        [DataTestMethod]
        [DataRow("a","e",4)]
        [DataRow("Lucinda", "Planck",1)]
        [DataRow("a", "ss",2)]
        //[DataRow("c", "C",2)] edge case where capital letter should affect name.contains
        
      /*  [TestMethod]*/
        public void SearchTest(string firstname, string lastname, int countresults)
        {
            // Act
            IList<Employee> employees = dao.Search(firstname, lastname);

            //Assert
            Assert.IsNotNull(employees);
            Assert.AreEqual(countresults, employees.Count);

            ListLoopTests(employees);

            foreach (Employee e in employees)
            {
                Assert.IsTrue(e.FirstName.Contains(firstname));
                Assert.IsTrue(e.LastName.Contains(lastname));
            }
        }

        private static void ListLoopTests(IList<Employee> employees)
        {
            foreach (Employee e in employees)
            {
                Assert.IsNotNull(e.FirstName);
                Assert.IsNotNull(e.LastName);
                Assert.IsNotNull(e.JobTitle);
                Assert.IsNotNull(e.BirthDate);
                Assert.IsNotNull(e.Gender);
                Assert.IsNotNull(e.HireDate);
                Assert.IsNotNull(e.EmployeeId);
                Assert.IsNotNull(e.DepartmentId);
            }
        }
    }
}
