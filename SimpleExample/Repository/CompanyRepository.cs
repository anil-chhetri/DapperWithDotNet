using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using SimpleExample.Data;
using SimpleExample.DTOs;
using SimpleExample.Models;

namespace SimpleExample.Repository
{

    public class CompanyRepository : ICompanyRepository
    {
        private readonly DapperContext context;

        public CompanyRepository(DapperContext context)
        {
            this.context = context;
        }

        public async Task<Company> CreateCompany(CompanyDto newCompany)
        {
            var query = @"Insert into dbo.company(Name, address, country) values (@Name, @Address, @country); 
                        Select cast(Scope_Identity() as int);
                        ";

            var parameters = new DynamicParameters();
            parameters.Add("Name", newCompany.Name, System.Data.DbType.String);
            parameters.Add("Address", newCompany.Address, System.Data.DbType.String);
            parameters.Add("country", newCompany.Country, System.Data.DbType.String);

            //just to execute and provide no result.
            // using (var connection = context.CreateConnection())
            // {
            //     await connection.ExecuteAsync(query, parameters);
            // }


            using (var connection = context.CreateConnection())
            {
                var id = await connection.QuerySingleAsync<int>(query, parameters);

                return new Company()
                {
                    Id = id,
                    Address = newCompany.Address,
                    Name = newCompany.Name,
                    Country = newCompany.Country
                };
            }


        }

        public async Task DeleteCompany(int Id)
        {
            var query = @"delete from dbo.company where id = @Id";

            try
            {
                using (var connection = context.CreateConnection())
                {
                    await connection.ExecuteAsync(query, new { Id = Id });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Company>> GetAll()
        {
            var query = "Select * from Company;";
            using (var connection = context.CreateConnection())
            {
                var companies = await connection.QueryAsync<Company>(query);
                return companies.ToList<Company>();
            }
        }

        public async Task<Company> GetAllEmployeeCompany(int id)
        {
            var query = @"
                select * from dbo.company where id =@id;
                select * from dbo.employee where companyId = @id;
            ";

            using (var conn = context.CreateConnection())
            {
                using (var multi = await conn.QueryMultipleAsync(query, new { id = id }))
                {
                    var company = await multi.ReadSingleOrDefaultAsync<Company>();
                    if (company != null)
                    {
                        company.Employees = (await multi.ReadAsync<Employee>()).ToList();
                    }

                    return company;
                }
            }

        }

        public async Task<IEnumerable<Company>> GetAllEmployeesWithCompany()
        {
            var query = @"
            select c.*, e.*
            from dbo.employee e 
            inner join dbo.company c on c.id = e.companyId
            ";

            using (var conn = context.CreateConnection())
            {
                var companyDict = new Dictionary<int, Company>();
                var compaines = await conn.QueryAsync<Company, Employee, Company>(query, (company, employee) =>
                {
                    if (!companyDict.TryGetValue(company.Id, out var currentcompany))
                    {
                        currentcompany = company;
                        companyDict.Add(company.Id, currentcompany);

                    }
                    currentcompany.Employees.Add(employee);
                    return currentcompany;
                });

                return compaines.Distinct().ToList();
            }

        }

        public async Task<Company> GetById(int Id)
        {
            var query = "Select * from company where id = @Id";

            using (var connection = context.CreateConnection())
            {
                var data = await connection.QuerySingleOrDefaultAsync<Company>(query, new { Id = Id });
                return data;
            }
        }

        public async Task<Company> GetCompanyByEmployeeId(int id)
        {
            var procedureName = "Usp_ShowCompanyForEmployeeId";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int16, ParameterDirection.Input);

            using (var connection = context.CreateConnection())
            {
                var company = await connection.QuerySingleOrDefaultAsync<Company>(procedureName, parameters, commandType: CommandType.StoredProcedure);
                return company;
            }
        }

        public async Task UpdateCompany(int id, CompanyDto newCompany)
        {
            var query = @"
            update dbo.company 
            set name = @Name, Address = @Address, Country = @Country
            where id = @id
            ";

            var parameters = new DynamicParameters();
            parameters.Add("Name", newCompany.Name, System.Data.DbType.String);
            parameters.Add("Address", newCompany.Address, System.Data.DbType.String);
            parameters.Add("Country", newCompany.Country, System.Data.DbType.String);
            parameters.Add("id", id);

            try
            {

                using (var connection = context.CreateConnection())
                {
                    await connection.ExecuteAsync(query, parameters);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


    }

}