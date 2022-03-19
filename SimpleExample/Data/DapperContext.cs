using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SimpleExample.Data
{
    public class DapperContext
    {
        private readonly IConfiguration config;
        private readonly string connectionString;

        public DapperContext(IConfiguration config)
        {
            this.config = config;
            this.connectionString = config.GetConnectionString("default");
        }

        public IDbConnection CreateConnection() => new SqlConnection(this.connectionString);
    }
}