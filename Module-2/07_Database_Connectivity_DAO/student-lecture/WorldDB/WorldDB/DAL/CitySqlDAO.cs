using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using WorldDB.Models;

namespace WorldDB.DAL
{
    // Creat a CitySqlDAO class that will Get Citites By Country Code
    public class CitySqlDAO : ICityDAO
    {
        private const string SQL_GETCITIESBYCOUNTRY = "Select * from city where CountryCode = @countryCode";
        private const string SQL_INSERTCITY = "Insert into City (Name, District, CountryCode, Population) Values(@name, @district, @countryCode, @population); Select @@IDENTITY";

        //coonection string

        private string connectionString;
        public CitySqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Get all the cities for a given country
        /// </summary>
        /// <param name="countryCode">ISO Code for the country</param>
        /// <returns>List of City objects for that country</returns>
        public List<City> GetCitiesByCountry(string countryCode)
        {
            List<City> cities = new List<City>();
            // It can go wrong
            try
            {
                // connect to DB and then close it
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Open Connection
                    conn.Open();

                    // Command query statement and get results
                    SqlCommand cmd = new SqlCommand(SQL_GETCITIESBYCOUNTRY, conn);
                    // Parameter Assignment
                    cmd.Parameters.AddWithValue("@countryCode", countryCode);

                    // Read data and Excute query
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Read row by row
                    while (reader.Read())
                    {
                        City city = new City()
                        {
                            CityId = Convert.ToInt32(reader["CityId"]),
                            CountryCode = Convert.ToString(reader["CountryCode"]),
                            District = Convert.ToString(reader["District"]),
                            Name = Convert.ToString(reader["Name"]),
                            Population = Convert.ToInt32(reader["Population"]),
                        };
                        cities.Add(city);
                    }

                }

            }
            catch (sqlException ex)
            {
                // Log the Error

                // Re-throw so it can be caught up the stack
                throw;
            }
            return cities;
        }

        /// <summary>
        /// Adds a city to the DB
        /// </summary>
        /// <param name="cityToAdd"> A City object with  values in its properties for the new city</param>
        /// <returns> The id of the added city</returns>
        public int AddCity(City cityToAdd)
        {
            try
            {


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Open the connection
                    conn.Open();

                    // Create the command to insert
                    SqlCommand cmd = new SqlCommand(SQL_INSERTCITY, conn);
                    cmd.Parameters.AddWithValue("@name", cityToAdd.Name);
                    cmd.Parameters.AddWithValue("@district", cityToAdd.District);
                    cmd.Parameters.AddWithValue("@countryCode", cityToAdd.CountryCode);
                    cmd.Parameters.AddWithValue("@population", cityToAdd.Population);

                    int newId = Convert.ToInt32(cmd.ExecuteScalar());
                    return newId;
                }
            }
            catch (SqlException ex)
            {
                // Lot it!
                throw;
            }

        }

        public int DeleteCity (string cityName, string countryCode)
        {
            
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Delete From City Where Name=@name and CountryCode=@countryCode", conn);
                    cmd.Parameters.AddWithValue("@name", cityName);
                    cmd.Parameters.AddWithValue("@countryCode", countryCode);

                    int rowsAffected = cmd.ExecuteNonQuery(); // How many got back when we excute the queary statement
                    return rowsAffected;

                }
           
        }
    }
}
