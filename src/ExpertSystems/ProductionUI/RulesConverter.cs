using ProductionSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionUI
{
    public static class RulesConverter
    {
        public static List<Rule> ConvertToRules(string text)
        {
            var rules = new List<Rule>();
            foreach (var line in text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                var splitted = line.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                rules.Add(new Rule(splitted[0].Trim(), splitted[1].Trim()));
            }
            return rules;
        }

        public static string ConvertToText(List<Rule> rules)
        {
            string text = "";
            foreach (var rule in rules)
            {
                text += $"{rule.Left} -> {rule.Right}" + Environment.NewLine;
            }
            return text;
        }
    }
}
