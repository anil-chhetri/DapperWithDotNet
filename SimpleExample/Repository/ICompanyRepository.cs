using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleExample.DTOs;
using SimpleExample.Models;

namespace SimpleExample.Repository
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> GetAll();
        Task<Company> GetById(int Id);
        Task<Company> CreateCompany(CompanyDto newCompnay);
        Task UpdateCompany(CompanyDto newCompnay);

        Task DeleteCompany(int Id);

    }

}