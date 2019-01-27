using System;
using Microsoft.AspNetCore.Mvc;
using CustomerPreferences.Interfaces;
using CustomerPreferences.Helpers;

namespace CustomerPreferences.Controllers
{
    public class CustomerPreferencesController
    {
        private IReportHelper _reportHelper;

        public CustomerPreferencesController(ReportHelper reportHelper)
        {
            _reportHelper = reportHelper;
        }

        public CustomerPreferencesController() : this(new ReportHelper()) { }

        [HttpGet]
        public IActionResult Get() {
            _reportHelper.GetCustomerPreferencesReport();

            return new ContentResult();
        }
    }
}
