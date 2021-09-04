using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iSystem2021.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            ViewBag.Menu = "Index";
            return View();
        }

        public ActionResult New()
        {
            ViewBag.Menu = "New";
            return View();
        }
    }
}