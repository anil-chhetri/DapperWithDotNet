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
        Task UpdateCompany(int id, CompanyDto newCompnay);
        Task DeleteCompany(int Id);
        Task<Company> GetCompanyByEmployeeId(int id);

        Task<IEnumerable<Company>> GetAllEmployeesWithCompany();

        Task<Company> GetAllEmployeeCompany(int id);
    }

}