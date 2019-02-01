using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using OnionSample.Domain.Interfaces.Repository;
using OnionSample.Infrastructure.Repository;

namespace OnionSample.Dependency
{
    public class DependencyResolver
    {
        public static IKernel Kernel { get; set; }
        public void Resolve()
        {
            Kernel = new StandardKernel();
            var serviceRegister = new DependencyServiceRegister();
            serviceRegister.Register(Kernel);
        }
    }

    public class DependencyServiceRegister
    {
        public void Register(IKernel kernel)
        {
            kernel.Bind<IMedicineRepository>().To<MedicineRepository>();
            kernel.Bind<ICompanyRepository>().To<CompanyRepository>();
        }
    }
}
