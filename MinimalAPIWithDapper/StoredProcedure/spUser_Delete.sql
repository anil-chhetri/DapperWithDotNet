create or alter procedure spUser_Delete
    @id int
as 
begin 
    delete  
    from dbo.[user]
    where id = @id;
end