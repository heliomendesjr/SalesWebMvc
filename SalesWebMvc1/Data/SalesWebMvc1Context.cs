using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc1.Models;

namespace SalesWebMvc1.Data
{
    public class SalesWebMvc1Context : DbContext
    {
        public SalesWebMvc1Context (DbContextOptions<SalesWebMvc1Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
