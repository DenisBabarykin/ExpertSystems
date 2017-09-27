using LogicSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class LogicRulesConverter
    {
        public static string ConvertToString(List<LogicRule> rules)
        {
            var result = String.Empty;
            foreach (var rule in rules)
                result += rule.ToString() + Environment.NewLine;
            return result;
        }
    }
}
