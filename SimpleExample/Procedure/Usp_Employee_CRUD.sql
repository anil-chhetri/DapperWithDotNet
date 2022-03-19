create or alter procedure Usp_Employee_CRUD
@Action varchar(1) = 'r', --crud
@id int=0,
@Name varchar(500)='',
@Dob Datetime2='',
@position varchar(500)='',
@companyId int=0
as
begin 
    set nocount on;
    
    if(@Action = 'r')
    begin 
        select * 
        from dbo.Employee;
    end

    if(@Action = 'c')
    begin 
        if not exists (select top 1 'x' from dbo.Company where id = @companyId)
        begin 
            RAISERROR('company doesn''\t exists.', 16, 1);
            return;
        END
        insert into dbo.employee(Name, DateOfBirth, [Position], CompanyId)
        values(@Name, @Dob, @position, @companyId)
    end

    if(@Action = 'u')
    begin 
        if not exists (select top 1 'x' from dbo.Company where id = @companyId)
        begin 
            RAISERROR('company doesn''\t exists.', 16, 1);
            return;
        END

        if not exists (select top 1 'x' from dbo.Employee where id = @id)
        begin 
            RAISERROR('employee doesn''t exists to update.', 16,1);
            return;
        end

        update dbo.Employee
        set Name = @Name, DateOfBirth = @Dob, [Position] = @position, CompanyId = @companyId
        where id = @id
    end

    if(@Action = 'd')
    begin 
        if not exists (select top 1 'x' from dbo.Employee where id = @id)
        begin 
            RAISERROR('employee doesn''t exists to update.', 16,1);
            return;
        end

        delete from dbo.Employee where id = @id
    end

end