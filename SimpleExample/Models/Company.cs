using System.Collections.Generic;

namespace SimpleExample.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Country { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
    }
}