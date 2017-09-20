using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSystem
{
    public class Rule
    {
        public string Left { get; set; }

        public string Right { get; set; }

        public Rule(string leftPart, string rightPart)
        {
            Left = leftPart;
            Right = rightPart;
        }
    }
}
