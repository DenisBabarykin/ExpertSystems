using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroFuzzy
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
