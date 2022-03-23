
namespace DataAccess.DbAccess;

public interface ISqlDbAccess
{
    Task<IEnumerable<T>> LoadData<T, U>(string procedureName, U parameters, string connectionId = "default");
    Task SaveData<T>(string procedureName, T parameters, string connectionId = "default");
}