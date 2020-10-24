using DataAccess.Dal;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Dependenciesenjection
{
    class DependenciesInjection : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonelDal>().To<PersonelDal>();
            Bind<IPersonelService>().To<PersonelService>();
            Bind<IUrunService>().To<UrunService>();
            Bind<IUrunDal>().To<UrunDal>();
        }

        
    }
}
