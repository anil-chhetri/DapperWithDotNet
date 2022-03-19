using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using SimpleExample.Data;
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
    }

}