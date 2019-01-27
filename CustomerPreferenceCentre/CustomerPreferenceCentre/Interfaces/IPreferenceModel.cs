using System;
namespace CustomerPreferenceCentre.Interfaces
{
    public interface IPreferenceModel
    {
        bool Never { get; set; } 
        bool Everyday { get; set; }
        string[] Days { get; set; }
        DateTime Date { get; set; }
    }
}
