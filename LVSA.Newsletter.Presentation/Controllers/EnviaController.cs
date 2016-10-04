using LVSA.Newsletter.Application.Interfaces;
using LVSA.Newsletter.Application.ViewModels;
using LVSA.Newsletter.Presentation.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace LVSA.Newsletter.Presentation.Controllers
{
    public class EnviaController : Controller
    {
        private readonly IServidorAppService _servidorAppService;
        private readonly IRemetenteAppService _remetenteAppService;
        private readonly IEnvioAppService _envioAppService;

        public EnviaController(IServidorAppService servidorAppService, IRemetenteAppService remetenteAppService, IEnvioAppService envioAppService)
        {
            _servidorAppService = servidorAppService;
            _remetenteAppService = remetenteAppService;
            _envioAppService = envioAppService;
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            ViewBag.ServidorSet = _servidorAppService.Filtrar(f => true);
            ViewBag.RemetenteSet = _remetenteAppService.Filtrar(f => true);
        }

        // GET: Envia
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SMS(EnviaViewModel model)
        {
            ViewBag.Tipo = "Text/SMS";
            ViewBag.ServidorId = model.ServidorId;
            ViewBag.RemetenteId = model.RemetenteId;

            if (!ModelState.IsValid)
                return View("Index", model);

            string[] destinarios;
            MemoryStream m = new MemoryStream();

            string all;
            using (StreamReader sr = new StreamReader(model.Arquivo.InputStream))
                all = sr.ReadToEnd();

            destinarios = all.Replace("\r\n", "\n").Split('\n');

            DestinatarioViewModel[] destinatarioSet = destinarios.Select(s =>
            {
                string[] temp = s.Split(';');
                return new DestinatarioViewModel { Nome = temp[0], Email = temp[1], Celular = temp[2] };
            }).ToArray();

            _envioAppService.EnviarSMS(new LoteViewModel
            {
                RemetenteId = model.RemetenteId,
                Envio = new EnvioViewModel
                {
                    Body = model.SMS,
                    DestinatarioSet = destinatarioSet
                }
            });

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Mail(EnviaViewModel model)
        {
            ViewBag.Tipo = "E-mail";
            ViewBag.ServidorId = model.ServidorId;
            ViewBag.RemetenteId = model.RemetenteId;

            return View("Index");
        }
    }
}