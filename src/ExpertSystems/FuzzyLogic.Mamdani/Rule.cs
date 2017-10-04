using System;
using System.Collections.Generic;
using System.Linq;
using FuzzyLogic.Mamdani.Statements;

namespace FuzzyLogic.Mamdani
{
    /// <summary>
    /// Правило
    /// </summary>
    public class Rule
    {
        public readonly List<Condition> Conditions;
        public readonly Conclusion Conclusion;

        public Rule(List<Condition> conditions, Conclusion conclusion)
        {
            Conditions = conditions;
            Conclusion = conclusion;
        }

        /// <summary>
        /// Для вывода в таблицах
        /// </summary>
        public string[] ToStringArray()
        {
            var list = new List<string>();
            list.Add(string.Join(" & ", Conditions.Select(x => x.ToString()).ToArray()));
            list.Add(Conclusion.ToString());

            return list.ToArray();
        }
    }
}
