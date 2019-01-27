using System;
using CustomerPreferenceCentre.Interfaces;

namespace CustomerPreferenceCentre.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public IPreferenceModel Preferences { get; private set; }

        public UserModel(IPreferenceModel preferences)
        {
            Preferences = preferences;
        }

        public UserModel() : this(new PreferenceModel()) { }
    }
}
