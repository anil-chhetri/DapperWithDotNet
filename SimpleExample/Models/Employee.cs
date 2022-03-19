using System;

namespace SimpleExample.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Position { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

    }
}