using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace capstonerunning.Controllers
{
    public class BudgetController : Controller
    {
        // GET: Budget
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateBudget()
        {
            return View();
        }

        public ActionResult CurrentMonthProgress()
        {
            return View();
        }

        public ActionResult EnterTransactions()
        {
            return View();
        }
    }
}