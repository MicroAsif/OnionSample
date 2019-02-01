using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionSample.Domain.Entity;
using OnionSample.Domain.Interfaces.Repository;
using OnionSample.Infrastructure.Repository.Base;

namespace OnionSample.Infrastructure.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {

    }
}
