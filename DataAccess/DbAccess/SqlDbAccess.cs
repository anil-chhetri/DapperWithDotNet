using System.Data.SqlClient;
using System.Data;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace DataAccess.DbAccess;

public class SqlDbAccess : ISqlDbAccess
{
    private readonly IConfiguration _config;

    public SqlDbAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<IEnumerable<T>> LoadData<T, U>(
        string procedureName,
        U parameters,
        string connectionId = "default")
    {
        using var conn = new SqlConnection(_config.GetConnectionString(connectionId));

        return await conn.QueryAsync<T>(
            sql: procedureName,
            param: parameters,
            commandType: CommandType.StoredProcedure);
    }

    public async Task SaveData<T>(
        string procedureName,
        T parameters,
        string connectionId = "default")
    {
        using var conn = new SqlConnection(_config.GetConnectionString(connectionId));

        await conn.ExecuteAsync(sql: procedureName, param: parameters, commandType: CommandType.StoredProcedure);


    }
}
