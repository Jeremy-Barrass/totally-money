using System;
using CustomerPreferenceCentre.Interfaces;

namespace CustomerPreferenceCentre.Models
{
    public class PreferenceModel : IPreferenceModel
    {
        public bool Never { get; set; }
        public bool Everyday { get; set; }
        public string[] Days { get; set; }
        public DateTime Date { get; set; }
    }
}
