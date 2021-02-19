using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectOrganizer.DAL;
using ProjectOrganizer.Models;
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
    }
}
