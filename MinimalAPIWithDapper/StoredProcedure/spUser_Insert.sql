create or alter procedure spUser_Insert
    @firstname nvarchar(50),
    @lastName nvarchar(50)
as 
begin 
    insert into dbo.[user](firstName, lastName)
    values (@firstname, @lastname)
end