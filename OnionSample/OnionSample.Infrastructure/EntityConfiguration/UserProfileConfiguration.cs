using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionSample.Domain.Entity;

namespace OnionSample.Infrastructure.EntityConfiguration
{
    public class UserProfileConfiguration
    {
        public UserProfileConfiguration(DbModelBuilder builder)
        {
            builder.Entity<UserProfile>().HasKey(u => u.Id);
            builder.Entity<UserProfile>().Property(t => t.FirstName).IsRequired();
            builder.Entity<UserProfile>().Property(t => t.LastName).IsRequired();
            builder.Entity<UserProfile>().Property(t => t.Address);
        }
    }
}
