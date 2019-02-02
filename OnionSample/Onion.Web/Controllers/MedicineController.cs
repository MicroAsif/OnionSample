using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OnionSample.Domain.Interfaces.Repository;

namespace Onion.Web.Controllers
{
    public class MedicineController : ApiController
    {
        private readonly IMedicineRepository _medicineRepository;

        public MedicineController(IMedicineRepository medicineRepository)
        {
            _medicineRepository = medicineRepository;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_medicineRepository.All().ToList());
        }
    }
}
