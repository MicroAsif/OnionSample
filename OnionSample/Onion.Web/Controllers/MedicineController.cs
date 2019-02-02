using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OnionSample.Domain.Interfaces.Business;
using OnionSample.Domain.Interfaces.Repository;

namespace Onion.Web.Controllers
{
    public class MedicineController : ApiController
    {
        private readonly IMedicineRepository _medicineRepository;
        private readonly IMedicineLogic _medicineLogic;

        public MedicineController(IMedicineRepository medicineRepository, IMedicineLogic medicineLogic)
        {
            _medicineRepository = medicineRepository;
            _medicineLogic = medicineLogic;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_medicineRepository.All().ToList());
        }
    }
}
