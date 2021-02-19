using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.IO;

namespace ProjectOrganizer_IntegrationTests
{
    [TestClass]
    public class DAO_TestBase
    {
        // Connection string to our test DB
        protected const string connectionString = "Server=.\\SQLExpress;Database=EmployeeDB_Test;Trusted_Connection=True;";
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
        virtual public void Arrange()
        {
            // Arrange
            SetupDB();
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