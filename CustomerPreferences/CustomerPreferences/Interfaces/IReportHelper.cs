using System;
using System.Collections.Generic;

namespace CustomerPreferences.Interfaces
{
    public interface IReportHelper
    {
        Dictionary<string, string[]> GetCustomerPreferencesReport();
    }
}
