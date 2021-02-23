using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectOrganizer.DAL;
using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace ProjectOrganizer_IntegrationTests
{
    [TestClass]
    public class DeparmentDAO_Test : DAO_TestBase
    {

        private DepartmentSqlDAO dao;
       
        [TestInitialize]
        public override void Arrange()
        {
            base.Arrange();
            this.dao = new DepartmentSqlDAO(connectionString);

        }

        [TestMethod]
        public void GetDepartmentsTest()
        {
            // Act
            List<Department> actualResult = (List<Department>)dao.GetDepartments();
            
            //Assert
            Assert.AreEqual(3, actualResult.Count);
            
            // to test with listcontansDeprtmentName
           Assert.IsTrue(ListContainsDepartmentName(actualResult, "Marketing"));
           Assert.IsTrue(ListContainsDepartmentName(actualResult, "Finance"));
           Assert.IsTrue(ListContainsDepartmentName(actualResult, "HR"));
           Assert.IsFalse(ListContainsDepartmentName(actualResult, "IT"));

            foreach (Department d in actualResult)
            {
                Assert.IsNotNull(d.DepartmentName);
                Assert.IsNotNull(d.DepartmentId);
            }
        }

        private bool ListContainsDepartmentName(IList<Department> departments, string depatmentToFind)
        {
            foreach (Department department in departments)
            {
                if (department.DepartmentName.Contains(depatmentToFind))
                {
                    return true;
                }

            }
            return false;
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

        [TestMethod]
        public void CreateDepartmentTest()
        {
            //Arrange
            // Create a department to insert

            Department department = new Department()
            {
                DepartmentName = "My new Department"
            };

            // Act
            int newId = dao.CreateDepartment(department);

            // Assert

            // Get back a non-zero  id
            Assert.AreNotEqual(0, newId);

            // Number of rows should now be 4
            Assert.AreEqual(4, GetNumberOfRows());

            // Read at the id and make sure the department name is found
            Assert.AreEqual("My new Department", GetDepartmentNameFromDB(newId));
        }
        
        private int GetNumberOfRows()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("Select Count(*) from department", connection);
                return Convert.ToInt32(command.ExecuteScalar());

            }
        }

        private string GetDepartmentNameFromDB(int departmentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("Select name form department where department_id=@id", connection);
                command.Parameters.AddWithValue("@id", departmentId);
                
                return Convert.ToString(command.ExecuteScalar());

            }
        }
    }
}
