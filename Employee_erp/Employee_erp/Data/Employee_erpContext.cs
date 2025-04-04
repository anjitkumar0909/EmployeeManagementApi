using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Employee_erp.Models;

namespace Employee_erp.Data
{
    public class Employee_erpContext : DbContext
    {
        public Employee_erpContext (DbContextOptions<Employee_erpContext> options)
            : base(options)
        {
        }

        public DbSet<Employee_erp.Models.Employee> Employee { get; set; } = default!;
    }
}
