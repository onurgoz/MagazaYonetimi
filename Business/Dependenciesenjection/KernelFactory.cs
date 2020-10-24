using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Dependenciesenjection
{
    public class KernelFactory
    {
        public static T GetService<T>()
        {
            var kernel = new StandardKernel(new DependenciesInjection());
            return kernel.Get<T>();
        }
    }
}
