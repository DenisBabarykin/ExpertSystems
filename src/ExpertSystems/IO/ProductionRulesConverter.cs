using ProductionSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public static class ProductionRulesConverter
    {
        public static List<ProductionRule> ConvertToRules(string text)
        {
            var rules = new List<ProductionRule>();
            foreach (var line in text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                var splitted = line.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                rules.Add(new ProductionRule(splitted[0].Trim(), splitted[1].Trim()));
            }
            return rules;
        }

        public static string ConvertForwardRulesToText(List<ProductionRule> rules)
        {
            string text = "";
            foreach (var rule in rules)
            {
                text += $"{rule.Left} -> {rule.Right}" + Environment.NewLine;
            }
            return text;
        }

        public static string ConvertBackwardRulesToText(List<ProductionRule> rules)
        {
            string text = "";
            foreach (var rule in rules)
            {
                text += $"{rule.Left} <- {rule.Right}" + Environment.NewLine;
            }
            return text;
        }
    }
}
