create or alter procedure Usp_ShowCompanyForEmployeeId
@id int
AS
begin 
    select c.Id, c.Name, c.Address, c.Country
    from dbo.employee e 
        inner join dbo.company c on c.id = e.companyId
    where e.id = @id
end 