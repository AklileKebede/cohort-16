using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.IO;
using Teams.DAL;
using Teams.Models;

namespace TeamIntegrationTests
{
    [TestClass]
    public class TeamSqlDaoTests
    {
        private string connectionString = @"Server=.\SQLExpress;Database=NFLDB;Trusted_Connection=True;";
        private TeamSqlDao teamDao;
        private int BrownsTeamId = 0;

        [TestInitialize]
        public void SetupBeforeEachTest() // TODO: Run the TestSetup script
        {
            // Read the Test setup script into a string
            string setupScript = File.ReadAllText("SetupTestData.sql");

            // Create a connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(setupScript, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    BrownsTeamId = Convert.ToInt32(reader["BrownsId"]);
                }
            }
            // Execute the test script

            //Arrange - Create an instance of the DAO
            this.teamDao = new TeamSqlDao(connectionString);
        }

       [TestMethod]
        public void GetByBadId_ShouldReturnNULL()
        {            
            //Act- Execute the method to test, with known bad id
            Team actualTeam = teamDao.GetTeamById(-1);

            //Assert
            Assert.IsNull(actualTeam);
        }
        [TestMethod]
        public void GetByGoodId_ShouldReturnNULL()
        {
            //Act- Execute the method to test, with known bad id
            Team actualTeam = teamDao.GetTeamById(this.BrownsTeamId);

            //Assert
            Assert.IsNotNull(actualTeam);
            Assert.AreEqual("Cleveland", actualTeam.Location);
        }

    }
}
