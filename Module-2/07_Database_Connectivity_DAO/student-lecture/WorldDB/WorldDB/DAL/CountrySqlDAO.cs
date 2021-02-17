using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using WorldDB.Models;

namespace WorldDB.DAL
{
    public class CountrySqlDAO : ICountryDAO
    {
        private const string SQL_GETALLCOUNTRIES = "Select * from Country";
        private const string SQL_GETALLCOUNTRIESBYCONTINENT = "Select * from Country Where continent = @continent";
        private const string SQL_GETALLCOUNTRYBYCODE = "Select * from Country Where Code=@code";

        private string connectionString;

        public CountrySqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Country> GetCountries()
        {
            List<Country> countries = new List<Country>();

            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    // Open Connetion
                    conn.Open();

                    // Create command query
                    SqlCommand cmd = new SqlCommand(SQL_GETALLCOUNTRIES, conn);

                    // Execute command and get a reader
                    SqlDataReader rdr = cmd.ExecuteReader();

                    // Loop through rows, Create a country object for each row and add it to the list
                    while (rdr.Read())
                    {
                        // Create a new country object
                        Country country = new Country();

                        country.Code = Convert.ToString(rdr["Code"]);
                        country.Name = Convert.ToString(rdr["Name"]);
                        country.Continent = Convert.ToString(rdr["Continent"]);
                        country.Region = Convert.ToString(rdr["Region"]);
                        country.SurfaceArea = Convert.ToDouble(rdr["SurfaceArea"]);
                        country.Population = Convert.ToInt32(rdr["Population"]);

                        // Add to list
                        countries.Add(country);
                    }

                    return countries;
                }
            }
            catch (SqlException ex)
            {
                // Log the error here
                throw;
            }
        }
        public List<Country> GetCountries(string continent)
        {
            List<Country> countries = new List<Country>();

            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    // Open Connetion
                    conn.Open();

                    // Create command query
                    SqlCommand cmd = new SqlCommand(SQL_GETALLCOUNTRIESBYCONTINENT, conn);
                    cmd.Parameters.AddWithValue("@continent", continent);

                    // Execute command and get a reader
                    SqlDataReader rdr = cmd.ExecuteReader();

                    // Loop through rows, Create a country object for each row and add it to the list
                    while (rdr.Read())
                    {
                        Country country = RowToObject(rdr);

                        // Add to list
                        countries.Add(country);
                    }

                    return countries;
                }
            }
            catch (SqlException ex)
            {
                // Log the error here
                throw;
            }
        }
        public Country GetCountry(string code)
        {
            Country country = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    // Open Connetion
                    conn.Open();

                    // Create command query
                    SqlCommand cmd = new SqlCommand(SQL_GETALLCOUNTRYBYCODE, conn);
                    cmd.Parameters.AddWithValue("@code", code);// 

                    // Execute command and get a reader
                    SqlDataReader rdr = cmd.ExecuteReader();

                    // Loop through rows, Create a country object for each row and add it to the list
                    // Using IF because our retun can 0 or 1, see if three is a row returned and if sdo, create a country object
                    if (rdr.Read())
                    {
                        country = RowToObject(rdr);
                    }

                }
            }
            catch (SqlException ex)
            {
                // Log the error here
                throw;
            }
            return country;
        }
        private static Country RowToObject(SqlDataReader rdr)
        {
            // Create a new country object
            Country country = new Country();

            country.Code = Convert.ToString(rdr["Code"]);
            country.Name = Convert.ToString(rdr["Name"]);
            country.Continent = Convert.ToString(rdr["Continent"]);
            country.Region = Convert.ToString(rdr["Region"]);
            country.SurfaceArea = Convert.ToDouble(rdr["SurfaceArea"]);
            country.Population = Convert.ToInt32(rdr["Population"]);
            return country;
        }
    }
}
