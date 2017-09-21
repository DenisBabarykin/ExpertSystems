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

        private string Goal { get; set; }

        private Stack<Rule> WorkSpace { get; set; }

        public ProductionInferenceEngine(List<Rule> rules)
        {
            Rules = rules;
            WorkSpace = new Stack<Rule>();
        }

        public InferenceResult ExecuteForwardChaining(string fact, string goal)
        {
            Goal = goal;

            InferenceResult result;
            if (CheckGoal(fact, 0))    // recursion starts here
                result = new InferenceResult(true, WorkSpace.Reverse().ToList());
            else
                result = new InferenceResult(false, null);

            return result;
        }

        /// <param name="count">Count of tries to use given left part</param>
        private bool CheckGoal(string left, int count)
        {
            var rule = TryGetNextRule(left, count);
            if (rule == null)
                return false;

            WorkSpace.Push(rule);

            if (rule.Right == Goal)
                return true;


            if (CheckGoal(rule.Right, 0))
                return true;
            else
            {
                WorkSpace.Pop();
                return CheckGoal(left, count + 1);
            }
        }

        private Rule TryGetNextRule(string left, int index)
        {
            var rules = Rules.Where(r => r.Left == left)?.ToList();
            if (rules == null || rules.Count <= index)
                return null;
            else
                return rules[index];
        }

        public InferenceResult ExecuteBackwardChaining(string fact, string goal)
        {
            return null;
        }
    }
}
