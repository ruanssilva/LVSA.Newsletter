using LVSA.Newsletter.Application.Interfaces;
using LVSA.Newsletter.Application.ViewModels;
using LVSA.Newsletter.Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LVSA.Newsletter.Presentation.Controllers
{
    public class EnviaController : Controller
    {
        private readonly IServidorAppService _servidorAppService;
        private readonly IRemetenteAppService _remetenteAppService;

        public EnviaController(IServidorAppService servidorAppService, IRemetenteAppService remetenteAppService)
        {
            _servidorAppService = servidorAppService;
            _remetenteAppService = remetenteAppService;
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

            return View("Index");
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