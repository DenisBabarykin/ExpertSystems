using LogicSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class LogicRulesLoader
    {        
        public static List<LogicRule> LoadFromFile(string text)
        {
            var rules = new List<LogicRule>();
            foreach (var line in text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                rules.Add(ParseRule(line));            
            return rules;
        }
        
        public static LogicRule ParseRule(string ruleString)
        {
            var rule = new LogicRule();
            rule.Functor = ruleString.Substring(0, ruleString.IndexOf('('));
            rule.Arguments = ParseArguments(ruleString);           
            rule.Body = ParseBody(ruleString);
            return rule;
        }

        protected static List<LogicRuleArgument> ParseArguments(string ruleString)
        {
            var argumentsDict = new List<LogicRuleArgument>();
            var openBracketIndex = ruleString.IndexOf('(');
            var closeBracketIndex = ruleString.IndexOf(')');
            var arguments = ruleString.Substring(openBracketIndex + 1, closeBracketIndex - openBracketIndex - 1)       
                .Split(new char[] { ',' }).Select(s => s.Trim()).ToList();
            foreach (var arg in arguments)
            {
                if (arg.StartsWith("'") && arg.EndsWith("'"))   // constant
                {
                    var argContent = arg.Substring(1, arg.Length - 2);
                    AddArgument(argumentsDict, argContent, argContent);
                }
                else  // variable 
                    AddArgument(argumentsDict, arg, null);
            } 
            return argumentsDict;
        }

        protected static void AddArgument(List<LogicRuleArgument> argsList, string argumentName, string argumentValue)
        {
            argsList.Add(new LogicRuleArgument() { Name = argumentName, Value = argumentValue } );            
        }

        protected static List<LogicRule> ParseBody(string ruleString)
        {
            var resultRules = new List<LogicRule>();
            var bodySeparatorIndex = ruleString.IndexOf(":-");
            if (bodySeparatorIndex != -1)
            {
                var body = ruleString.Substring(bodySeparatorIndex + 2, ruleString.Length - bodySeparatorIndex - 2);
                var rulesInBody = body.Split(new char[] { '&' }).Select(s => s.Trim()).ToList();
                resultRules = rulesInBody.Select(r => ParseRule(r)).ToList();
            }
            return resultRules;
        }
    }
}
