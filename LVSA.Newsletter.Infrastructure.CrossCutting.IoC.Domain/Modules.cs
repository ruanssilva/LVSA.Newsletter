
using LVSA.Newsletter.Domain.Interfaces.Repository;
using LVSA.Newsletter.Domain.Interfaces.Services;
using LVSA.Newsletter.Domain.Services;
using LVSA.Newsletter.Infrastructure.Data.Repository.EF;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Infrastructure.CrossCutting.IoC.Domain
{
    public class Modules : NinjectModule
    {
        public override void Load()
        {
            Bind<IDestinatarioRepository>().To<DestinatarioRepository>();
            Bind<IDestinatarioService>().To<DestinatarioService>();

            Bind<IEnvioRepository>().To<EnvioRepository>();
            Bind<IEnvioService>().To<EnvioService>();

            Bind<ILoteRepository>().To<LoteRepository>();
            Bind<ILoteService>().To<LoteService>();

            Bind<IRemetenteRepository>().To<RemetenteRepository>();
            Bind<IRemetenteService>().To<RemetenteService>();

            Bind<IServidorRepository>().To<ServidorRepository>();
            Bind<IServidorService>().To<ServidorService>();
        }
    }
}
