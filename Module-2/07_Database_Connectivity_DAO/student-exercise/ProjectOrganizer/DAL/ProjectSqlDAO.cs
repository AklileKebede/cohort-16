using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrganizer.DAL
{
    public class ProjectSqlDAO : IProjectDAO
    {
        private const string SQL_INSERT_EMPLOYEE_PROJECT = "Insert Into project_employee(project_id,employee_id) Values (@project_id,@employee_id);";
        private const string SQL_DELETE_EMPLOYEE_PROJECT = "Delete From project_employee Where project_id=@project_id And employee_id=@employee_id; Select @@IDENTITY;";
        private const string SQL_INSERT_PROJECT = "Insert Into project(name,from_date,to_date) Values (@name, @from_date, @to_date); Select @@IDENTITY;";
        private const string SQL_SELECT_PROJECTS = "Select * From project;";
        private string connectionString;

        // Single Parameter Constructor
        public ProjectSqlDAO(string dbConnectionString)
        {
            this.connectionString = dbConnectionString;
        }

        /// <summary>
        /// Returns all projects.
        /// </summary>
        /// <returns></returns>
        public IList<Project> GetAllProjects()
        {
            IList<Project> projects = new List<Project>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL_SELECT_PROJECTS, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Project project = new Project()
                        {
                            ProjectId = Convert.ToInt32(reader["Project_Id"]),
                            ProjectName = Convert.ToString(reader["name"]),
                            StartDate = Convert.ToDateTime(reader["from_date"]),
                            EndDate = Convert.ToDateTime(reader["to_date"])
                        };
                        projects.Add(project);
                    }
                    return projects;
                }
            }
            catch
            {
                // Log Error 
                throw;
            }
        }

        /// <summary>
        /// Assigns an employee to a project using their IDs.
        /// </summary>
        /// <param name="projectId">The project's id.</param>
        /// <param name="employeeId">The employee's id.</param>
        /// <returns>If it was successful.</returns>
        public bool AssignEmployeeToProject(int projectId, int employeeId)
        {
            try
            {
                using (SqlConnection connection= new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL_INSERT_EMPLOYEE_PROJECT, connection);
                    ProjectEmployee_Paramenter(projectId, employeeId, command);

                    int affectedRows = Convert.ToInt32(command.ExecuteNonQuery());

                    if (affectedRows == 0)
                    {
                        return false;
                    }
                    return true;
                }
            }
            catch
            {
                // Log Error
                throw;
            }
        }

        /// <summary>
        /// Removes an employee from a project.
        /// </summary>
        /// <param name="projectId">The project's id.</param>
        /// <param name="employeeId">The employee's id.</param>
        /// <returns>If it was successful.</returns>
        public bool RemoveEmployeeFromProject(int projectId, int employeeId)
        {
            try
            {
                using(SqlConnection connection= new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL_DELETE_EMPLOYEE_PROJECT, connection);
                    ProjectEmployee_Paramenter(projectId, employeeId, command);

                    return Affected_Row_Scalar(command);
                }
            }
            catch
            {
                // Log error
                throw;
            }
        }

        /// <summary>
        /// Extracted method: Query statement result
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        private static bool Affected_Row_Scalar(SqlCommand command)
        {
            int affectedRows = Convert.ToInt32(command.ExecuteScalar());

            if (affectedRows == 0)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Extracted method: Parameters Assignment
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="employeeId"></param>
        /// <param name="command"></param>
        private static void ProjectEmployee_Paramenter(int projectId, int employeeId, SqlCommand command)
        {
            command.Parameters.AddWithValue("@project_id", projectId);
            command.Parameters.AddWithValue("@employee_id", employeeId);
        }

        /// <summary>
        /// Creates a new project.
        /// </summary>
        /// <param name="newProject">The new project object.</param>
        /// <returns>The new id of the project.</returns>
        public int CreateProject(Project newProject)
        {
            try
            {
                using (SqlConnection connection= new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL_INSERT_PROJECT, connection);
                    command.Parameters.AddWithValue("@name", newProject.ProjectName);
                    command.Parameters.AddWithValue("@from_date", newProject.StartDate);
                    command.Parameters.AddWithValue("@to_date", newProject.EndDate);

                    int newProjectId = Convert.ToInt32(command.ExecuteScalar());

                    return newProjectId;
                }
            }
            catch
            {
                // Log Error
                throw;
            }
        }

    }
}
