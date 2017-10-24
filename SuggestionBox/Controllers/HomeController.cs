using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuggestionBox.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //There is an action for each one of our pages. This page sends back.
            return View();
        }

    }
}