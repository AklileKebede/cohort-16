using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization;
using System.Threading;
using WorldDB.DAL;
using WorldDB.Models;
using WorldDB.Views;

namespace WorldDB
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code reads the connection string from appsettings.json
            // TODO 03: Add the connection string to appsettings.json and un-comment the following lines to read the configuration
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            string connectionString = configuration.GetConnectionString("World");


            // TEMPORARY: DB EXAMPLE (vanilla, no DAO)
            //ReadCities();
            //return;

            //Temporary: DAO to use GetCountries()
            //CountrySqlDAO dao = new CountrySqlDAO(connectionString);
            //List<Country> list = dao.GetCountries("Asia");

            //Country country = dao.GetCountry("zzz");

            //country = dao.GetCountry("USA");

            // TODO 04a: Create a Model for Country to go with the City model we already have
            // TODO 04b: Create a CountrySqlDAO class (GetCountries, GetCountries(continent), GetCountry(code))
            // TODO 04c: Create an ICountryDAO interface
            ICountryDAO countryDAO = new CountrySqlDAO(connectionString);


            // TODO 10: Create a CitySqlDAO class (GetCitiesByCountryCode)
            // TODO 10a: Create an ICityDAO interface
            ICityDAO cityDAO = new CitySqlDAO(connectionString);

            // TODO 14a: Create a Model for CountryLanguage
            // TODO 14b: Create a CountryLanguageSqlDAO class (GetLanguages(string countryCode))
            // TODO 14c: Create an ICountryLanguageDAO interface


            // TODO 05b: Create a WorldDBMenu, passing in the country dao, and Run it
            WorldDBMenu menu = new WorldDBMenu(countryDAO, cityDAO);
            menu.Show();

            // Say goodbye to the user...
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Goodbye...");
            Thread.Sleep(1500);
        }

        private static void ReadCities()
        {
            // TODO 01: Read cities from the database and list the results on the screen.
            string connectionString = "Server=.\\SqlExpress;Database=World;Trusted_Connection=True;";
            
            // TODO 02: Add a parameter to the query to get the cities for a given country code.
            Console.Write("Country Code: ");
            string coutnryCode = Console.ReadLine();
           
            try
            {// Create a connection
                using (SqlConnection conn = new SqlConnection(connectionString)) // Add using for SqlConnection
                {
                    // First open the connection to the DB
                    conn.Open();

                    // Create command for sql statement
                    SqlCommand cmd = new SqlCommand("Select name, population from City where CoutnryCode=@cc", conn);
                    cmd.Parameters.AddWithValue("@cc", coutnryCode);

                    // Execute the statment and get back a "reader"=results
                    SqlDataReader rdr = cmd.ExecuteReader(); // rdr[] is an object

                    // Loop through the results and display to the user
                    while (rdr.Read())
                    {
                        string name = Convert.ToString(rdr["name"]);
                        int population = Convert.ToInt32(rdr["Population"]);
                        Console.WriteLine($"Name: {name}, Population:{population}");
                    }
                }
            }
            catch (sqlException ex)
            {
                Console.WriteLine($"There was a database error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}

    [Serializable]
    internal class sqlException : Exception
    {
        public sqlException()
        {
        }

        public sqlException(string message) : base(message)
        {
        }

        public sqlException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected sqlException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }