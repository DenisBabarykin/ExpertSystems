using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicSystem
{
    public class LogicInferenceEngine
    {
        public LogicInferenceEngine(List<LogicRule> rules)
        {
            Rules = rules;
            WorkSpace = new Stack<LogicRule>();
        }
        public List<LogicRule> Rules { get; set; }
        public LogicRule Goal { get; set; }
        public Stack<LogicRule> WorkSpace { get; set; }

        public LogicInferenceResult ExecuteBackwardChaining(LogicRule goal)
        {
            LogicInferenceResult result = null;
            Goal = goal;         
            if (CheckGoal(Goal))
                result = new LogicInferenceResult(WorkSpace.Reverse().ToList(), true);
            else
                result = new LogicInferenceResult(null, false);
            return result;
        }


        protected bool CheckGoal(LogicRule goal)
        {
            var nextRule = TryGetNextRule(goal);
            if (nextRule != null)
            {
                WorkSpace.Push(nextRule);
                if (nextRule.Body.Count == 0) // нашли факт
                    return true;
                RuleUnufication(nextRule, goal);
                var trueResCount = 0;
                foreach (var rule in nextRule.Body)
                {
                    var res = CheckGoal(rule);
                    if (res)
                        ++trueResCount;
                }
                return trueResCount == nextRule.Body.Count;
            }
            WorkSpace.Pop();
            return false;
        }

        protected void RuleUnufication(LogicRule ruleTo, LogicRule fuleFrom)
        {
            for (int i = 0; i < fuleFrom.Arguments.Count; i++)            
                ruleTo.Arguments[i].Value = fuleFrom.Arguments[i].Value;
            UnificateRuleBody(ruleTo);
        }

        protected void UnificateRuleBody(LogicRule rule)
        {
            foreach (var arg in rule.Arguments)
            {
                foreach (var ruleBody in rule.Body)
                {
                    var index = ruleBody.Arguments.FindIndex(a => a.Name == arg.Name);
                    if (index != -1)
                        ruleBody.Arguments[index].Value = arg.Value;
                }
            }
            
        }

        protected bool AreArgumentsEqual(LogicRule firstRule, LogicRule secondRule)
        {
            var result = false;
            if (firstRule.Arguments.Count == secondRule.Arguments.Count)
            {
                var matchedCount = 0;
                for (int i = 0; i < firstRule.Arguments.Count; i++)
                    if (firstRule.Arguments[i].Value == secondRule.Arguments[i].Value)
                        ++matchedCount;                
                result = matchedCount == firstRule.Arguments.Count;
            }
            return result;
        }

        protected int GetEqualArgumentsNumber(LogicRule firstRule, LogicRule secondRule)
        {
            var matchedCount = 0;
            if (firstRule.Arguments.Count == secondRule.Arguments.Count)
            {                
                for (int i = 0; i < firstRule.Arguments.Count; i++)
                    if ((firstRule.Arguments[i].Value != null && secondRule.Arguments[i].Value != null && firstRule.Arguments[i].Value == secondRule.Arguments[i].Value) 
                        || (firstRule.Arguments[i].Value == null) 
                        || (secondRule.Arguments[i].Value == null))
                        ++matchedCount;                
            }
            return matchedCount;
        }

        protected LogicRule GetMaxMatchRule(List<LogicRule> rules, LogicRule ruleForMatch)
        {
            LogicRule result = null;
            int maxMatch = 0;
            
            foreach (var rule in rules)
            {
                var allVariablesDefined = rule.Arguments.All(a => a.Value != null);
                var matchedArgsNumber = GetEqualArgumentsNumber(rule, ruleForMatch);
                if (rule.Body.Count == 0 && allVariablesDefined && matchedArgsNumber == ruleForMatch.Arguments.Count)
                {
                    return rule;
                }
                else if (matchedArgsNumber > maxMatch && !allVariablesDefined)
                {
                    result = rule;
                    maxMatch = matchedArgsNumber;
                }
            }
            return result;
        }

        protected LogicRule TryGetNextRule(LogicRule currentGoal)
        {
            var rules = Rules.Where(r => r.Functor == currentGoal.Functor && r.Arguments.Count == currentGoal.Arguments.Count).ToList();
            LogicRule rule = GetMaxMatchRule(rules, currentGoal);         
            return rule;
        }
    }
}
