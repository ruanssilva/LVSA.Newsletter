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
    public class ServidorAppService : AppServiceBase<ServidorViewModel, Servidor, IServidorService>, IServidorAppService
    {
        public ServidorAppService(IServidorService servidorService)
            : base(servidorService)
        {
        }
    }
}
