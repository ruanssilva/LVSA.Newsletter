using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LVSA.Newsletter.Presentation.Controllers
{
    public abstract class ControllerBase : Controller
    {
        protected virtual void HandlingException(Exception ex)
        {
            ViewBag.Error = ex.Message;
        }
    }
}