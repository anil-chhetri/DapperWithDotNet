using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class UserData : IUserData
{
    private readonly ISqlDbAccess _dbAccess;

    public UserData(ISqlDbAccess dbAccess)
    {
        _dbAccess = dbAccess;
    }

    public Task<IEnumerable<UserModel>> GetUsers() =>
            _dbAccess.LoadData<UserModel, dynamic>(procedureName: "dbo.spUser_Getall", parameters: new { });


    public async Task<UserModel?> GetUser(int id)
    {
        var results = await _dbAccess.LoadData<UserModel, dynamic>(
            procedureName: "dbo.spUser_Get",
            parameters: new { id = id });

        return results.FirstOrDefault();
    }

    public Task InsertUser(UserModel user) => _dbAccess.SaveData<dynamic>(
            procedureName: "dbo.spUser_Insert",
            new { user.FirstName, user.LastName });


    public Task UpdateUser(UserModel user) =>
           _dbAccess.SaveData<dynamic>("dbo.spUser_Update", user);

    public Task DeleteUser(int id) =>
             _dbAccess.SaveData("dbo.spUser_Delete", new { id = id });

}
