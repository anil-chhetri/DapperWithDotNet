using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

public static class DataMigration
{
    public static WebApplicationBuilder PerformDataMigration(this WebApplicationBuilder builder)
    {
        using (var scopedService = builder.Services.BuildServiceProvider().CreateScope())
        {
            var logger = scopedService.ServiceProvider.GetRequiredService<ILogger<Program>>();
            using (var context = scopedService.ServiceProvider.GetRequiredService<ApplicationDbContext>())
            {
                try
                {
                    logger.LogInformation("Checking for pending migrations.");
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

            logger.LogInformation("ruinng perform data migrations.");
        }
        return builder;
    }


    public static WebApplicationBuilder AddProcedure(this WebApplicationBuilder builder)
    {
        using (var scopedService = builder.Services.BuildServiceProvider().CreateScope())
        {
            var logger = scopedService.ServiceProvider.GetRequiredService<ILogger<Program>>();
            var config = scopedService.ServiceProvider.GetRequiredService<IConfiguration>();
            var env = scopedService.ServiceProvider.GetRequiredService<IWebHostEnvironment>();

            logger.LogInformation("Adding procedure to database.");
            using (var con = new SqlConnection(config.GetConnectionString("default")))
            {
                var curpath = env.ContentRootPath;
                // var test = env.
                foreach (var item in Directory.GetFiles(Path.Combine(curpath, "StoredProcedure"), "*.sql", SearchOption.TopDirectoryOnly))
                {
                    var filename = Path.GetFileName(item);
                    logger.LogInformation("executing procedure {filename}", filename);
                    var sql = File.ReadAllText(item);
                    con.Execute(sql);
                }
            }
        }
        return builder;
    }
}