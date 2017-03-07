using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaSotrudnikov.Domain.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(): base("DefaultConnection"){ }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
