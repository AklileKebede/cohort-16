using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrganizer.DAL
{
    public class DepartmentSqlDAO : IDepartmentDAO
    {
        private const string SQL_GETDEPARMENT = "Select * From department";
        private const string SQL_NEWDEPARTMENT = "Insert Into department(name) Values (@name); Select @@IDENTITY;";
        private const string SQL_UPDATEDEPARTMENT = "Update department Set name=@name Where department_id=@department_id;";
        private string connectionString;

        // Single Parameter Constructor
        public DepartmentSqlDAO(string dbConnectionString)
        {
            this.connectionString = dbConnectionString;
        }
      
        /// <summary>
        /// Returns a list of all of the departments.
        /// </summary>
        /// <returns></returns>
        public IList<Department> GetDepartments()
        {
            IList<Department> departments = new List<Department>();
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL_GETDEPARMENT, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Department department = RowToObject(reader);
                        departments.Add(department);
                    }
                    return departments;
                }
            }
            catch
            {
                // Eror here
                throw;
            }
        }

        private static Department RowToObject(SqlDataReader reader)
        {
            return new Department()
            {
                DepartmentId = Convert.ToInt32(reader["Department_Id"]),
                DepartmentName = Convert.ToString(reader["name"])
            };
        }

        /// <summary>
        /// Creates a new department.
        /// </summary>
        /// <param name="newDepartment">The department object.</param>
        /// <returns>The id of the new department (if successful).</returns>
        public int CreateDepartment(Department newDepartment)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL_NEWDEPARTMENT, connection);
                    command.Parameters.AddWithValue("@name", newDepartment.DepartmentName);
                    

                    int newDepartmentId = Convert.ToInt32(command.ExecuteScalar());
                    return newDepartmentId;
                }
            }
            catch
            {
                // Log error
                throw;
            }
        }
        
        /// <summary>
        /// Updates an existing department.
        /// </summary>
        /// <param name="updatedDepartment">The department object.</param>
        /// <returns>True, if successful.</returns>
        public bool UpdateDepartment(Department updatedDepartment)
        {
            try
            {
                using (SqlConnection connection= new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL_UPDATEDEPARTMENT, connection);
                    command.Parameters.AddWithValue("@name", updatedDepartment.DepartmentName);
                    command.Parameters.AddWithValue("@department_id", updatedDepartment.DepartmentId);

                    //SqlDataReader reader = command.ExecuteScalar();

                    int updatedDepartmentId = Convert.ToInt32(command.ExecuteNonQuery());
                    if (updatedDepartmentId == 0)
                    {
                        return false;
                    }

                    return true;
                }
            }
            catch
            {
                // Log error
                throw;
            }
        }

    }
}
