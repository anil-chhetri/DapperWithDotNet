create or alter procedure spUser_Get
    @id int
as 
begin 
    select * 
    from dbo.[user]
    where id = @id;
end