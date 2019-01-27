using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerPreferenceCentre.Controllers
{
    private 
    [Route("api/save")]
    public class SavePreferencesController : Controller
    {
        [HttpPost]
        public ActionResult Save()
        {

            return View ("~/Views/input/EnterPreference");
        }
    }
}
