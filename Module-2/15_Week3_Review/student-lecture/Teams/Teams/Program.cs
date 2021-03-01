using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teams
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

/* Teams Steps
 * 
 * 1. Database Planing
 *      Team
 *          TeamID (PK)
 *          Location
 *          TeamName
 *          Conference (enumaration a 1 or 2)
 *          Division
 *          Wins
 *          Losses
 *     Player
 *          PlayerId (PK)
 *          TeamId (FK)
 *          FirstName
 *          LastName
 *          BirthDate
 *          Position
 * Comments: We are denormalizing the database, to simplify the scop
 * */