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
    public class ProjectDAO_Test : DAO_TestBase
    {
        private ProjectSqlDAO dao;

        [TestInitialize]
        public override void Arrange()
        {
            base.Arrange();

            // Arrange
            //Establish the "known state" of the database
            dao = new ProjectSqlDAO(connectionString);
        }

        [TestMethod]
        public void GetProjectsTest()
        {
            //Act
            IList<Project> projects = dao.GetAllProjects();

            //Assert
            Assert.AreEqual(3, projects.Count);

            ListLoopTests(projects);

        }
        private static void ListLoopTests(IList<Project> projects)
        {
            foreach (Project p in projects)
            {
                Assert.IsNotNull(p.ProjectId);
                Assert.IsNotNull(p.ProjectName);
                Assert.IsNotNull(p.StartDate);
                Assert.IsNotNull(p.EndDate);
            }
        }

        [TestMethod]
        public void CreateProjectTest()
        {

            Project project = new Project() { ProjectName = "Merge", EndDate = DateTime.Now.Date, StartDate = DateTime.Parse("2008-05-01") };
            //Act
           int projectId = dao.CreateProject(project);

            Assert.IsNotNull(projectId);
            Assert.AreNotEqual(null, projectId);
            Assert.IsNotNull(project.ProjectId);
            Assert.IsNotNull(project.ProjectName);
            Assert.IsNotNull(project.StartDate);
            Assert.IsNotNull(project.EndDate);

            Assert.AreEqual("Merge", project.ProjectName);
            Assert.AreEqual(DateTime.Parse("2008-05-01"), project.StartDate);
            Assert.AreEqual(DateTime.Now.Date, project.EndDate);

        }


    }
}
