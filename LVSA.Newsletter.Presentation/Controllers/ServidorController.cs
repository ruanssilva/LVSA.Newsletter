using LVSA.Newsletter.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LVSA.Newsletter.Presentation.Controllers
{
    public class ServidorController : Controller
    {
        private readonly IServidorAppService _servidorAppService;

        public ServidorController(IServidorAppService servidorAppService)
        {
            _servidorAppService = servidorAppService;
        }

        // GET: Servidor
        public ActionResult Index()
        {
            return View();
        }
    }
}