using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iSystem2021.Controllers
{
    public class SharedController : Controller
    {
        // GET: Shared
        public ActionResult View404()
        {
            return View();
        }
    }
}