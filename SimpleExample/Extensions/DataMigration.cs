using System;
using System.IO;
using System.Linq;
using Dapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SimpleExample.Data;

namespace SimpleExample.Extensions
{
    public static class DataMigration
    {
        public static IHost PerformDataMigration(this IHost host)
        {
            using (var scopedService = host.Services.CreateScope())
            {
                var logger = scopedService.ServiceProvider.GetRequiredService<ILogger<Program>>();
                using (var context = scopedService.ServiceProvider.GetRequiredService<AppDbContext>())
                {
                    try
                    {

                        if (context.Database.GetPendingMigrations().Any())
                        {
                            logger.LogInformation("Migration of database is starting.");
                            context.Database.Migrate();
                        }
                    }
                    catch (Exception)
                    {

                        logger.LogError("Something wrong with migrations.");
                        throw;
                    }
                }
            }
            return host;
        }


        public static IHost AddProcedure(this IHost host)
        {
            using (var scopedService = host.Services.CreateScope())
            {
                var logger = scopedService.ServiceProvider.GetService<ILogger<Program>>();
                var config = scopedService.ServiceProvider.GetRequiredService<IConfiguration>();
                var env = scopedService.ServiceProvider.GetRequiredService<IWebHostEnvironment>();

                logger.LogInformation("Adding procedure to database.");
                using (var con = new SqlConnection(config.GetConnectionString("default")))
                {
                    var curpath = env.ContentRootPath;
                    // var test = env.
                    foreach (var item in Directory.GetFiles(Path.Combine(curpath, "Procedure"), "*.sql", SearchOption.TopDirectoryOnly))
                    {
                        var filename = Path.GetFileName(item);
                        logger.LogInformation("executing procedure {filename}", filename);
                        var sql = File.ReadAllText(item);
                        con.Execute(sql);
                    }
                }
            }
            return host;
        }
    }
}