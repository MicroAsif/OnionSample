using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionSample.Domain.Entity;
using OnionSample.Domain.Interfaces.Repository;
using OnionSample.Domain.Interfaces.Repository.Base;
using OnionSample.Infrastructure.Repository.Base;

namespace OnionSample.Infrastructure.Repository
{
    public class MedicineRepository : BaseRepository<Medicine>, IMedicineRepository
    {
    }
}
