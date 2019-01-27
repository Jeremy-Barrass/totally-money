using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using CustomerPreferenceCentre.Models;

namespace CustomerPreferenceCentre.Controllers
{    
    [System.Web.Mvc.Route("/api/save")]
    public class SavePreferencesController : Controller
    {
        [System.Web.Mvc.HttpPost]
        public ActionResult Save([FromBody] UserModel[] users = new []() { })
        {

            return View ("~/Views/input/EnterPreference");
        }
    }
}
