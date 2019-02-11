using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Services.Protocols;
using OnionSample.Domain.Entity;
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
            return Ok(_medicineRepository.All().Include(x=>x.Company).ToList());
        }
        [HttpPost]
        public async Task<IHttpActionResult> Post(Medicine model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            await _medicineRepository.Insert(model);
            return Ok(model);
        }
    }
}
