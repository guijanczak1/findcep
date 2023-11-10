using apicep.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apicep.Infrastructure
{
    public class ApiCepDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerPhone> CustomerPhones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=cliente;Uid=admin;Pwd=m748lmrt;", ServerVersion.Parse("8.2.0"));
        }
    }
}
