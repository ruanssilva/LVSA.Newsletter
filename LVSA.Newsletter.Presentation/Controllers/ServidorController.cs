using LVSA.Newsletter.Application.Interfaces;
using LVSA.Newsletter.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LVSA.Newsletter.Presentation.Controllers
{
    public class ServidorController : ControllerBase
    {
        private readonly IServidorAppService _servidorAppService;
        public ServidorController(IServidorAppService servidorAppService)
        {
            _servidorAppService = servidorAppService;
        }

        // GET: Servidor
        public ActionResult Index()
        {
            try
            {
                return View(_servidorAppService.Filtrar(f => true));
            }
            catch (Exception ex)
            {
                HandlingException(ex);
            }

            return RedirectToAction("Index", "Home");
        }

        // GET: Servidor/Details/5
        public ActionResult Details(Guid id)
        {
            var model = _servidorAppService.Filtrar(f => f.Id == id).SingleOrDefault();
            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        // GET: Servidor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Servidor/Create
        [HttpPost]
        public ActionResult Create(ServidorViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                _servidorAppService.Incluir(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Servidor/Edit/5
        //public ActionResult Action(string verb, Guid id)
        //{
        //    var model = _servidorAppService.Filtrar(f => f.Id == id).SingleOrDefault();
        //    if (model == null)
        //        return HttpNotFound();

        //    return View(verb, model);
        //}

        // GET: Servidor/Edit/5
        public ActionResult Edit(Guid id)
        {
            var model = _servidorAppService.Filtrar(f => f.Id == id).SingleOrDefault();
            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        // POST: Servidor/Edit/5
        [HttpPost]
        public ActionResult Edit(ServidorViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                _servidorAppService.Atualizar(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Servidor/Delete/5
        public ActionResult Delete(Guid id)
        {
            var model = _servidorAppService.Filtrar(f => f.Id == id).SingleOrDefault();
            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        // POST: Servidor/Delete/5
        [HttpPost]
        public ActionResult Delete(ServidorViewModel model)
        {
            try
            {
                _servidorAppService.Remover(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
