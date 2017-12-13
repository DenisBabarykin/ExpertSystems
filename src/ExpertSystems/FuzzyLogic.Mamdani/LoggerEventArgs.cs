using System;

namespace FuzzyLogic.Mamdani
{
    public class LoggerEventArgs : EventArgs
    {
        public LoggerEventArgs(string message)
        {
            Meassage = message;
        }

        public string Meassage { get; set; }
    }
}
