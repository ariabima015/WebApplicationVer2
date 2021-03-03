using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationVer2.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet <City> Cities { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
