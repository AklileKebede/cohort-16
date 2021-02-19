using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using WorldDB.DAL;
using WorldDB.Models;

namespace WorldDBIntergrationTests
{
    [TestClass]
    public class CountrySqlDAOTests
    {
        const string connectionString = "Server=.\\SQLExpress;Database=World_Test;Trusted_Connection=True;";
        private CountrySqlDAO dao;
        [TestInitialize]
        public void Arrange()
        {
                // Establish the "known state" of the DB
                SetupDB();
               // Create an instance of CountrySqlDAO
                this.dao = new CountrySqlDAO(connectionString);

        }

        [TestMethod]
        public void GetCoutnryByIdTest()
        {
            // Arrange

            // Act
            // Call the GetCoutnry method
            Country country = dao.GetCountry("USA");

            // Assert
            //Make sure we get back the country we expect
            Assert.IsNotNull(country);
            Assert.AreEqual("United States", country.Name);
        }

        [TestMethod]

        public void GetCountriesByContinentTest()
        {
            // Arrange
           
            // Act
            // Call the GetCountries method
            List<Country> countries = dao.GetCountries("North America");

            // Assert
            //Make sure we get back the country we expect
            Assert.IsNotNull(countries);
            Assert.AreEqual(2, countries.Count);
        }

        private void SetupDB()
        {

            string path = "DBSetup.sql";
            // Read teh DB setup script from text file
            string setupScript = File.ReadAllText(path);
            
            // Create a new connection
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(setupScript, conn);
                cmd.ExecuteNonQuery();
            }

            // Create a new command from the text file and execute it
        }
    }
}
