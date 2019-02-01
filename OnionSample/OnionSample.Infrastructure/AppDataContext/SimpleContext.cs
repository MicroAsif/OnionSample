using System;
using System.Collections.Generic;
using System.Data.Entity;
using OnionSample.Domain.Entity;

namespace OnionSample.Infrastructure.AppDataContext
{
    public class SimpleContext : DbContext
    {
        public SimpleContext() : base("OnionContext")
        {
            
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
       
    }
}
