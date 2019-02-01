using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionSample.Domain.Entity;
using OnionSample.Domain.Interfaces.Repository.Base;

namespace OnionSample.Domain.Interfaces.Repository
{
    public interface IMedicineRepository : IBaseRepository<Medicine>
    {
    }
}
