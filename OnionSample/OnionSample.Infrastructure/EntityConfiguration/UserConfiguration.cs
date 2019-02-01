using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionSample.Domain.Entity;

namespace OnionSample.Infrastructure.EntityConfiguration
{
    public class UserConfiguration
    {
        public UserConfiguration(DbModelBuilder entityBuilder)
        {
            entityBuilder.Entity<User>().HasKey(t => t.Id);
            entityBuilder.Entity<User>().Property(t => t.Email).IsRequired();
            entityBuilder.Entity<User>().Property(t => t.Password).IsRequired();
            entityBuilder.Entity<User>().Property(t => t.Email).IsRequired();
            entityBuilder.Entity<User>().HasRequired(t => t.UserProfile).WithRequiredDependent(u => u.User);
            //entityBuilder.HasOne(t => t.UserProfile).WithOne(u => u.User).HasForeignKey<UserProfile>(x => x.Id);
        }
    }
}
