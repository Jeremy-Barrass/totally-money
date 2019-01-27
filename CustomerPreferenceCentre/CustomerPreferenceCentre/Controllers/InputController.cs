using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerPreferenceCentre.Controllers
{
    public class InputController : Controller
    {
        public ActionResult Index()
        {
            return View ("EnterPreference");
        }
    }
}
