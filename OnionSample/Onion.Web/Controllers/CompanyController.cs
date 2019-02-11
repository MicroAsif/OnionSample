using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OnionSample.Domain.Interfaces.Repository;

namespace Onion.Web.Controllers
{
    public class CompanyController : ApiController
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_companyRepository.All());
        }
    }
}
