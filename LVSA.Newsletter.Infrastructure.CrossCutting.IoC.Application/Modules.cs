using LVSA.Newsletter.Application;
using LVSA.Newsletter.Application.Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Infrastructure.CrossCutting.IoC.Application
{
    public class Modules : NinjectModule
    {
        public override void Load()
        {
            //Bind<IDestinatarioAppService>().To<DestinarioAppService>();
            Bind<IEnvioAppService>().To<EnvioAppService>();
            //Bind<ILoteAppService>().To<LoteAppService>();
            Bind<IRemetenteAppService>().To<RemetenteAppService>();
            Bind<IServidorAppService>().To<ServidorAppService>();
        }
    }
}
