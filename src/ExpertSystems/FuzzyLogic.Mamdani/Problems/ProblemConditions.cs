using System.Collections.Generic;
using System.Linq;

namespace FuzzyLogic.Mamdani.Problems
{
    /// <summary>
    /// Условия задачи
    /// </summary>
    public class ProblemConditions
    {
        /// <summary>
        /// Правила вывода
        /// </summary>
        public List<Rule> Rules { get; }

        /// <summary>
        /// Нечеткие переменные
        /// </summary>
        public List<FuzzyVariable> Variables { get; }

        public ProblemConditions()
        {
            Variables = new List<FuzzyVariable>();
            Rules = new List<Rule>();
        }

        public ProblemConditions(List<FuzzyVariable> variables, List<Rule> rules)
        {
            Variables = variables;
            Rules = rules;
        }

        /// <summary>
        /// Число условий
        /// </summary>
        public int NumberOfConditions { get { return Rules.Select(x => x.Conditions.Count).Sum(); } }

        /// <summary>
        /// Число заключений
        /// </summary>
        public int NumberOfConclusions { get { return Rules.Count; } }
        
        /// <summary>
        /// Добавление переменной
        /// </summary>
        public void AddVariable(FuzzyVariable variable)
        {
            variable.Id = Variables.Count;
            Variables.Add(variable);
        }

        /// <summary>
        /// Добавление правила вывода
        /// </summary>
        public void AddRule(Rule rule)
        {
            Rules.Add(rule);
        }
    }
}
