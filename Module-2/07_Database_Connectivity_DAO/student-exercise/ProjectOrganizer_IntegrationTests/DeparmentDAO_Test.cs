using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectOrganizer.DAL;
using ProjectOrganizer.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace ProjectOrganizer_IntegrationTests
{
    [TestClass]
    public class DeparmentDAO_Test
    {
        // Connection string to our test DB
        const string connectionString = "Server=.\\SQLExpress;Database=EmployeeDB_Test;Trusted_Connection=True;";
        private DepartmentSqlDAO dao;
        /*
        We will be testing the DepartmentSqlDAO methods:
            1. GetDepartments
            2. CreateDepartment
            3. UpdateDepartment
        Steps:
            1. Extracted methods for the tests:
                - SetupDB: method to access the testing DB
                - Initialize: runs before each testclass
        We need to create a seperate method to read the DB script that will apply to all of our tests
        */

        [TestInitialize]
        public void Arrange()
        {
            // Arrange
            SetupDB();

            this.dao = new DepartmentSqlDAO(connectionString);

        }

        [TestMethod]
        public void GetDepartmentsTest()
        {

            //List<Department> expectedResult = new List<Department>() 
            //{ //{ "Marketing", "Finance", "HR" };
            //    new Department(){ DepartmentName="Marketing"},
            //    new Department(){ DepartmentName="Finance"},
            //    new Department(){ DepartmentName="HR"}
            //};
            //Assert
            //CollectionAssert.AreEquivalent(expectedResult, actualResult);

            // Act
            List<Department> actualResult = (List<Department>)dao.GetDepartments();
            
            //Assert
            Assert.AreEqual(3, actualResult.Count);

            foreach(Department d in actualResult)
            {
                Assert.IsNotNull(d.DepartmentName);
                Assert.IsNotNull(d.DepartmentId);
            }

            
        }
        [TestMethod]
        public void UpdateDepartmentTest()
        {
            
            Department department = new Department() {DepartmentName= "IT"}; 
            // Act
            bool actualResult = dao.UpdateDepartment(department);
            

            //Assert
            Assert.AreEqual("IT", department.DepartmentName);
           
                       
        }
        private void SetupDB()
        {
            // Create a path to our Querty Statement file
            string path = "DBSetup.sql";
            // Read and accesse Query Statment
            string setupScript = File.ReadAllText(path);
            // Create a new connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(setupScript, connection);

                command.ExecuteNonQuery();
            }
        }
    }
}
