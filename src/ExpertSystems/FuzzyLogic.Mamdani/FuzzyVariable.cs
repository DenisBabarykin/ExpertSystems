using System.Collections.Generic;
using System.Linq;

namespace FuzzyLogic.Mamdani
{
    /// <summary>
    /// Нечеткая переменная
    /// </summary>
    public class FuzzyVariable
    {
        /// <summary>
        /// Имя переменной
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Значения нечеткой переменной
        /// </summary>
        public readonly List<Term> Terms;

        /// <summary>
        /// Лингвистическое имя переменной
        /// </summary>
        public string LingName { get; set; }

        /// <summary>
        /// Является выходной переменной
        /// </summary>
        public bool IsResult { get; set; }

        public FuzzyVariable(string name, string lingName, List<Term> terms, bool isResult = false)
        {
            Name = name;
            LingName = lingName;
            Terms = terms;
            IsResult = isResult;
        }

        public double GetValueForTerm(Term term, double x)
        {
            return term.AccessoryFunc.GetValue(x);
        }

        public string[] ToStringArray()
        {
            var list = new List<string>
            {
                Name,
                LingName,
                string.Join(", ", Terms.Select(x => x.Name).ToArray())
            };
            return list.ToArray();
        }
    }
}
