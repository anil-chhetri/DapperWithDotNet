using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleExample.Models;

namespace SimpleExample.Repository
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> GetAll();
        Task<Company> GetById(int Id);
    }

}