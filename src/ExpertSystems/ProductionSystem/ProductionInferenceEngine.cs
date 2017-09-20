using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSystem
{
    public class ProductionInferenceEngine
    {
        public List<Rule> Rules { get; set; }

        public ProductionInferenceEngine(List<Rule> rules)
        {
            Rules = rules;
        }

        public InferenceResult ExecuteForwardChaining(string fact, string goal)
        {
            return null;
        }

        public InferenceResult ExecuteBackwardChaining(string fact, string goal)
        {
            return null;
        }
    }
}
