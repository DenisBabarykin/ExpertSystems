using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicSystem
{
    public class LogicRule
    {
        public LogicRule()
        {
            Arguments = new List<LogicRuleArgument>();
            Body = new List<LogicRule>();
        }
        public List<LogicRule> Body { get; set; }
        public string Functor { get; set; }
        public List<LogicRuleArgument> Arguments;

        public override string ToString()
        {
            return $"{Functor}({ String.Join(",", Arguments.Select(a => a.ToString()).ToList())})";
        }
    }
}
