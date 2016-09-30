using LVSA.Newsletter.Application.Interfaces;
using LVSA.Newsletter.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LVSA.Newsletter.Presentation.Controllers
{
    public class RemetenteController : ControllerBase
    {
        private readonly IRemetenteAppService _remetenteAppService;
        public RemetenteController(IRemetenteAppService remetenteAppService)
        {
            _remetenteAppService = remetenteAppService;
        }

        // GET: Remetente
        public ActionResult Index()
        {
            try
            {
                return View(_remetenteAppService.Filtrar(f => true));
            }
            catch (Exception ex)
            {
                HandlingException(ex);
            }

            return RedirectToAction("Index", "Home");
        }

        // GET: Remetente/Details/5
        public ActionResult Details(Guid id)
        {
            var model = _remetenteAppService.Filtrar(f => f.Id == id).SingleOrDefault();
            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        // GET: Remetente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Remetente/Create
        [HttpPost]
        public ActionResult Create(RemetenteViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                _remetenteAppService.Incluir(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Remetente/Edit/5
        //public ActionResult Action(string verb, Guid id)
        //{
        //    var model = _remetenteAppService.Filtrar(f => f.Id == id).SingleOrDefault();
        //    if (model == null)
        //        return HttpNotFound();

        //    return View(verb, model);
        //}

        // GET: Remetente/Edit/5
        public ActionResult Edit(Guid id)
        {
            var model = _remetenteAppService.Filtrar(f => f.Id == id).SingleOrDefault();
            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        // POST: Remetente/Edit/5
        [HttpPost]
        public ActionResult Edit(RemetenteViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                _remetenteAppService.Atualizar(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Remetente/Delete/5
        public ActionResult Delete(Guid id)
        {
            var model = _remetenteAppService.Filtrar(f => f.Id == id).SingleOrDefault();
            if (model == null)
                return HttpNotFound();

            return View(model);
        }

        // POST: Remetente/Delete/5
        [HttpPost]
        public ActionResult Delete(RemetenteViewModel model)
        {
            try
            {
                _remetenteAppService.Remover(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
