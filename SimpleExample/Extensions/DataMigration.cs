using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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
                var logger = scopedService.ServiceProvider.GetRequiredService<ILogger<IHost>>();
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
    }
}