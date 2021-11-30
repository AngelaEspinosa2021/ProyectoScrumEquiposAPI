using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesCompanySystemAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesCompanySystemAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
