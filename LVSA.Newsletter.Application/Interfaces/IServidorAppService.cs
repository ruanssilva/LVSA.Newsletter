﻿using LVSA.Newsletter.Application.ViewModels;
using LVSA.Newsletter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Newsletter.Application.Interfaces
{
    public interface IServidorAppService : IAppServiceBase<ServidorViewModel, Servidor>
    {
    }
}