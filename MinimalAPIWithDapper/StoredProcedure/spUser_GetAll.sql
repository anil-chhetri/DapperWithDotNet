create or alter procedure dbo.spUser_GetAll 
as 
begin 
    select * 
    from dbo.[user];
end 