using System;
using System.Collections.Generic;
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

        public async Task<Company> GetById(int Id)
        {
            var query = "Select * from company where id = @Id";

            using (var connection = context.CreateConnection())
            {
                var data = await connection.QuerySingleOrDefaultAsync<Company>(query, new { Id = Id });
                return data;
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