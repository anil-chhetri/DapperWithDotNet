using DataAccess.Data;
using DataAccess.Models;

namespace MinimalAPIWithDapper;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
        app.MapGet("/Users", GetUsers);
        app.MapGet("/Users/{Id}", GetUser);
        app.MapPost("/Users", InsertUser);
        app.MapPut("/Users", UpdateUser);
        app.MapDelete("/Users", DeleteUser);
    }

    private async static Task<IResult> GetUsers(IUserData userData)
    {
        try
        {
            return Results.Ok(await userData.GetUsers());
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }
    private async static Task<IResult> GetUser(int Id, IUserData userData)
    {
        try
        {
            var results = await userData.GetUser(Id);
            if (results == null) return Results.NotFound();
            return Results.Ok(results);
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }
    private async static Task<IResult> InsertUser(UserModel usermodel, IUserData userData)
    {
        try
        {
            await userData.InsertUser(usermodel);
            return Results.Ok();
        }
        catch (Exception ex)
        {
           return Results.Problem(ex.Message);
        }
    }
    private async static Task<IResult> UpdateUser(UserModel usermodel, IUserData userData)
    {
        try
        {
            await userData.UpdateUser(usermodel);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    private async static Task<IResult> DeleteUser(int Id, IUserData userData)
    {
        try
        {
            await userData.DeleteUser(Id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
