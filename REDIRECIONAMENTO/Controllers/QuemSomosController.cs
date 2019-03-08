using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REDIRECIONAMENTO.Controllers
{
    public class QuemSomosController : Controller
    {
        // GET: QuemSomos
        public ActionResult Index()
        {
            return View("QuemSomos");
        }
    }
}