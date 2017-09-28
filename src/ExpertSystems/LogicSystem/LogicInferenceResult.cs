using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicSystem
{
    public class LogicInferenceResult
    {
        public LogicInferenceResult(List<LogicRule> explanation, bool hasSolution)
        {
            Explanation = explanation;
            HasSolution = hasSolution;
        }
        public bool HasSolution { get; set; }
        public List<LogicRule> Explanation { get; set; }
    }
}
