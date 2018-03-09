using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace capstonerunning.Controllers
{
    public class AlertController : Controller
    {
        // GET: Alert
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PurchaseRequests()
        {
            return View();
        }

        public ActionResult SpendingWarnings()
        {
            return View();
        }

    }
}