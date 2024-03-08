using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyEcomStore.DataAccess.Entities;

namespace TinyEcomStore.DataAccess.Context
{
    public class TinyEcomStoreDBContext : DbContext
    {
        protected readonly IConfiguration _configuration;
        public TinyEcomStoreDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Products> Products { get; set; }
    }
}
