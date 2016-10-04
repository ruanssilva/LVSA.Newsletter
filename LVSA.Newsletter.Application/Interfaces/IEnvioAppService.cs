﻿using LVSA.Newsletter.Application.ViewModels;
using LVSA.Newsletter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Application.Interfaces
{
    public interface IEnvioAppService : IAppServiceBase<EnvioViewModel,Envio>
    {
        void EnviarSMS(LoteViewModel model);
    }
}
