using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionSample.Domain.Entity;
using OnionSample.Infrastructure.EntityConfiguration;

namespace OnionSample.Infrastructure.AppDataContext
{
    public class SimpleContext : DbContext
    {
        public SimpleContext() : base("OnionContext")
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new UserConfiguration(modelBuilder);
            new UserProfileConfiguration(modelBuilder);
        }
    }
}
