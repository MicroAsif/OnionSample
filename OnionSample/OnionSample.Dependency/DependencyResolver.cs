using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using OnionSample.Business;
using OnionSample.Domain.Interfaces.Business;
using OnionSample.Domain.Interfaces.Repository;
using OnionSample.Infrastructure.Repository;

namespace OnionSample.Dependency
{
    public class DependencyServiceRegister
    {
        public void Register(IKernel kernel)
        {
            #region Data
            kernel.Bind<IMedicineRepository>().To<MedicineRepository>();
            kernel.Bind<ICompanyRepository>().To<CompanyRepository>();
            #endregion

            #region BusinessLogic

            kernel.Bind<IMedicineLogic>().To<MedicineLogic>();

            #endregion


        }
    }
}
