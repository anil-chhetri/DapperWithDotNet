using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleExample.Data;
using SimpleExample.Models;
using SimpleExample.Repository;

namespace SimpleExample.Controllers
{
    [ApiController]
    [Route("api/companies")]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository companyRepo;

        public CompanyController(ICompanyRepository companyRepo)
        {
            this.companyRepo = companyRepo;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Company>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await this.companyRepo.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var companyData = await this.companyRepo.GetById(Id);
            if (companyData != null)
            {
                return Ok(companyData);
            }

            return NotFound();
        }
    }
}