using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YourNewCanadian.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

          ViewBag.Message =   "You're pretty nosey, eh? Look, we're a new company, there's not much to know.<br />" +
                "We ended up with a HUGE surplus of Canadians" +
                " and now they *all must go*. <br />Just go get one, already!";
            return View();
        }
        public ActionResult Why()
        {
            return View("Why");
        }
        public ActionResult Legal()
        {
            return View("Legal");
        }
        public ActionResult FAQ()
        {
            return View("FAQ");
        }
    }
}