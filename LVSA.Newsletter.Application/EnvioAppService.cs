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
        private readonly ILoteService _loteService;
        private readonly IDestinatarioService _destinatarioService;
        private readonly IEnviadoService _enviadoService;

        public EnvioAppService(IEnvioService envioService, ILoteService loteService, IDestinatarioService destinatarioService, IEnviadoService enviadoService)
            : base(envioService)
        {
            _loteService = loteService;
            _destinatarioService = destinatarioService;
            _enviadoService = enviadoService;
        }

        public void EnviarSMS(LoteViewModel model)
        {
            List<Destinatario> destinatarios = new List<Destinatario>();
            foreach (var x in model.Envio.DestinatarioSet)
            {
                Destinatario temp = _destinatarioService.Find(f => f.Nome == x.Nome && f.Celular == x.Celular && f.Email == x.Email).FirstOrDefault();
                if (temp == null)
                    temp = _destinatarioService.Add(new Destinatario { Id = Guid.NewGuid(), Nome = x.Nome, Celular = x.Celular, Email = x.Email });
                destinatarios.Add(temp);
            }

            //TODO: Foreach send sms

            Envio envio = new Envio
            {
                Id = Guid.NewGuid(),
                Body = model.Envio.Body
            };

            Service.Add(envio);

            foreach (Destinatario d in destinatarios)
            {
                _enviadoService.Add(new Enviado
                {
                    EnvioId = envio.Id,
                    DestinatarioId = d.Id
                });
            }

            Lote lote = new Lote
            {
                Id = Guid.NewGuid(),
                EnvioId = envio.Id,
                Horario = DateTime.Now,
                RemetenteId = model.RemetenteId
            };

            _loteService.Add(lote);
        }
    }
}
