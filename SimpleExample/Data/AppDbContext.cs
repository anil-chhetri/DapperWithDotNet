using System.Linq;
using Bogus;
using Microsoft.EntityFrameworkCore;
using SimpleExample.Models;

namespace SimpleExample.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Company> Company { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            int numSeed = 100;

            modelBuilder.Entity<Company>().HasData(
                new Faker<Company>()
                    // .StrictMode(true)
                    .UseSeed(112345)
                    .RuleFor(x => x.Id, f => f.IndexFaker + 1)
                    .RuleFor(x => x.Name, f => f.Company.CompanyName())
                    .RuleFor(x => x.Address, f => f.Address.StreetAddress())
                    .RuleFor(x => x.Country, f => f.Address.Country())
                    .Generate(numSeed)
            );


            modelBuilder.Entity<Employee>().HasData(
                new Faker<Employee>()
                    // .StrictMode(true)
                    .UseSeed(54231)
                    .RuleFor(x => x.Id, f => f.IndexFaker + 1)
                    .RuleFor(x => x.Name, faker => faker.Person.FullName)
                    .RuleFor(x => x.DateOfBirth, f => f.Person.DateOfBirth)
                    .RuleFor(x => x.Position, f => f.Person.Company.Name)
                    .RuleFor(x => x.CompanyId, f => f.Random.Number(1, numSeed))
                .Generate(numSeed * 2)
            );


        }
    }
}