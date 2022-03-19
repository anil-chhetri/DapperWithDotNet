using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleExample.DTOs;
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
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpGet("{Id}", Name = "GetById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int Id)
        {
            var companyData = await this.companyRepo.GetById(Id);
            if (companyData != null)
            {
                return Ok(companyData);
            }

            return NotFound();
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateCompany(CompanyDto newCompany)
        {
            try
            {
                var createdCompany = await this.companyRepo.CreateCompany(newCompany);
                return CreatedAtRoute("GetById", new { Id = createdCompany.Id }, createdCompany);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateCompany(int id, CompanyDto company)
        {
            try
            {
                await this.companyRepo.UpdateCompany(id, company);
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }


        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteCompany(int Id)
        {
            try
            {
                await this.companyRepo.DeleteCompany(Id);
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}