using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrganizer.DAL
{
    public class EmployeeSqlDAO : IEmployeeDAO
    {
        private const string SQL_GETALLEMPLOYEES = "Select * From Employee";
        private const string SQL_SEARCHFULLNAME = "Select * From employee Where first_name like CONCAT('%',@firstname,'%') And last_name like CONCAT('%',@lastname,'%')";
        private const string SQL_GETEMPLOYEESWITHOUTPROJECTS = "Select * From employee Where employee_id not in (select Distinct employee_id From project_employee);";

        private string connectionString;

        // Single Parameter Constructor
        public EmployeeSqlDAO(string dbConnectionString)
        {
            this.connectionString = dbConnectionString;
        }

        /// <summary>
        /// Returns a list of all of the employees.
        /// </summary>
        /// <returns>A list of all employees.</returns>
        public IList<Employee> GetAllEmployees()
        {
            IList<Employee> employees = new List<Employee>();
            // Things can go wrong, so we will put in 'try{}catch{}'
            try
            {
                //We need the database only while we use it so put it in 'using(){}'
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    // Open a connection to DB
                    connection.Open();

                    // Command query statement
                    SqlCommand cmd = new SqlCommand(SQL_GETALLEMPLOYEES, connection);

                    // Execute the query statement and get the results (Reader)
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Read the results- while loop because we are expecting many results
                    while (reader.Read())
                    {
                        Employee employee = RowToObject(reader);

                        // Add to list
                        employees.Add(employee);

                    }
                    return employees;
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error connecting to data: {ex}");
                throw;
            }
        }

        /// <summary>
        /// Find all employees whose names contain the search strings.
        /// Returned employees names must contain *both* first and last names.
        /// </summary>
        /// <remarks>Be sure to use LIKE for proper search matching.</remarks>
        /// <param name="firstname">The string to search for in the first_name field</param>
        /// <param name="lastname">The string to search for in the last_name field</param>
        /// <returns>A list of employees that matches the search.</returns>
        public IList<Employee> Search(string firstname, string lastname)
        {
            // Instantiat method type
            IList<Employee> employees = new List<Employee>();


            // Try{}Catch{}, because there could be an error when reading DB
            try
            {
                // We need to connect to DB, Close DB once ended using it
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //Open connection
                    connection.Open();

                    // Select Command query statement 
                    SqlCommand cmd = new SqlCommand(SQL_SEARCHFULLNAME, connection);
                    // Paramater Assignment
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname );

                    // Read data and execute query statment
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Read row by row, expecting 0 to many
                    while (reader.Read())
                    {
                        // Instantiat object
                        Employee employee = RowToObject(reader);

                        //Add to list
                        employees.Add(employee);

                    }
                    return employees;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error: {ex}");
                throw;
            }


        }

        /// <summary>
        /// Gets a list of employees who are not assigned to any active projects.
        /// </summary>
        /// <returns></returns>
        public IList<Employee> GetEmployeesWithoutProjects()
        {
            // Instantiate list
            IList<Employee> employees = new List<Employee>();

            // Try{}catch{}, incase we couldn't access DB
            try
            {
                // Create Connection(path) to DB, that will close after use
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    // Open connection
                    connection.Open();

                    // Command query statement and get results   // no parameters to assign
                    SqlCommand command = new SqlCommand(SQL_GETEMPLOYEESWITHOUTPROJECTS, connection);

                    // Excecute query statement
                    SqlDataReader reader = command.ExecuteReader();

                    // read row by row expecting 0 to many return
                    while (reader.Read())
                    {
                        // Instantiat object
                        Employee employee = RowToObject(reader);

                        // Add to list
                        employees.Add(employee);
                    }
                    return employees;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Eror connecting to DB: {ex}");
                throw;
            }
            
        }

        /// <summary>
        /// Repeating part there for Extracted Method
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private static Employee RowToObject(SqlDataReader reader)
        {
            // Create new object (instantiate) Employee
            Employee employee = new Employee();

            // Retrive values from reader object
            employee.EmployeeId = Convert.ToInt32(reader["employee_id"]);
            employee.DepartmentId = Convert.ToInt32(reader["department_id"]);
            employee.FirstName = Convert.ToString(reader["first_name"]);
            employee.LastName = Convert.ToString(reader["last_name"]);
            employee.JobTitle = Convert.ToString(reader["Job_Title"]);
            employee.BirthDate = Convert.ToDateTime(reader["birth_date"]);
            employee.Gender = Convert.ToString(reader["gender"]);
            employee.HireDate = Convert.ToDateTime(reader["Hire_Date"]);
            
            return employee;
        }
    }
}
