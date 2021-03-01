using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Teams.Models;

namespace Teams.DAL
{
    public class TeamSqlDao
    {
        private string connectionString;

        public TeamSqlDao(string connectionString) // Constructor
        {
            this.connectionString = connectionString;
        }

        /*Methods on the DAO:
                GetAllTeams()
                GetTeamById()
        */
        public List<Team> GetAllTeam()
        {
            List<Team> teams = new List<Team>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("Select * From Team", connection);
                // No parameters bind

                SqlDataReader reader = command.ExecuteReader();

                // Loop and create object
                while (reader.Read())
                {
                    Team newTeam = RowToObject(reader);
                    teams.Add(newTeam);
                }

            }
            return teams;
        }

        public Team GetTeamById(int teamId)
        {
            Team teamToGet = null;
            using (SqlConnection connection= new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("Select * from Team Where TeamId=@teamId", connection);
                command.Parameters.AddWithValue("@teamId", teamId);
                SqlDataReader reader = command.ExecuteReader();

                // We are expecting one answer so we do an if instead of while
                if (reader.Read())
                {
                    teamToGet = RowToObject(reader);
                }
            }

            return teamToGet;
        }
        // Create a row to object
        private Team RowToObject(SqlDataReader reader) // take a team (row) and convert to object
        {
            Team team = new Team();

            team.TeamId = Convert.ToInt32(reader["TeamId"]);
            team.Location = Convert.ToString(reader["Location"]);
            team.TeamName = Convert.ToString(reader["TeamName"]);
            team.Conference = (Conference)Convert.ToInt32(reader["Conference"]);
            team.Division = (Division)Convert.ToInt32(reader["Division"]);
            team.Wins = Convert.ToInt32(reader["Wins"]);
            team.Losses = Convert.ToInt32(reader["Losses"]);

            return team;
        }


    }
}
