create or alter procedure spUser_Get
    @id int
as 
begin 
    delete  
    from dbo.[user]
    where id = @id;
end