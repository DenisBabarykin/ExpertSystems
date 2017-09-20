using System.Collections.Generic;

namespace ProductionSystem
{
    public class InferenceResult
    {
        public bool HasSolution { get; set; }

        public List<Rule> Explanation { get; set; }

        public InferenceResult(bool hasSolution, List<Rule> explanation)
        {
            HasSolution = hasSolution;
            Explanation = explanation;
        }
    }
}