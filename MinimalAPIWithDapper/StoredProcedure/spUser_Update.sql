create or alter procedure spUser_Update
    @id int,
    @firstName nvarchar(50),
    @lastName nvarchar(50)
as 
begin 
    update dbo.[user]
    set firstName = @firstName, lastName = @lastName
    where id = @id;
end