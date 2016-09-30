using LVSA.Newsletter.Application.Interfaces;
using LVSA.Newsletter.Application.ViewModels;
using LVSA.Newsletter.Domain;
using LVSA.Newsletter.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Application
{
    public class EnvioAppService : AppServiceBase<EnvioViewModel, Envio, IEnvioService>, IEnvioAppService
    {
        public EnvioAppService(IEnvioService envioService)
            : base(envioService)
        {
        }
    }
}
