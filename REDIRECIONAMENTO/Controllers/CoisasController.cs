using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REDIRECIONAMENTO.Controllers
{
    public class CoisasController : Controller
    {
        // GET: Coisas
        public ActionResult FaleConosco()
        {
            return View();
        }
    }
}