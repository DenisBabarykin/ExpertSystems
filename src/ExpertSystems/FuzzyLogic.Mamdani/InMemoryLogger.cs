using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuzzyLogic.Mamdani
{
    public static class InMemoryLogger
    {
        public static event EventHandler<LoggerEventArgs> OnPrintMessage;

        public static void PrintMessage(string message)
        {
            OnPrintMessage?.Invoke(null, new LoggerEventArgs(message + Environment.NewLine));
        }
    }
}
