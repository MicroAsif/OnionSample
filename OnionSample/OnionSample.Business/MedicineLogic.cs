using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionSample.Domain.Interfaces.Business;
using OnionSample.Domain.Interfaces.Repository;

namespace OnionSample.Business
{
    public class MedicineLogic : IMedicineLogic
    {
        private readonly IMedicineRepository _medicineRepository;
        private readonly ICompanyRepository _companyRepository;

        public MedicineLogic(IMedicineRepository medicineRepository, ICompanyRepository companyRepository)
        {
            _medicineRepository = medicineRepository;
            _companyRepository = companyRepository;
        }

        public void SomeLogicHere()
        {

            Console.WriteLine("Some logic will be here");
        }
    }
}
