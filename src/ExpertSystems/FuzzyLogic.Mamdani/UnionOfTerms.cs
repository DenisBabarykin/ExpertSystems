using System.Collections.Generic;
using System.Linq;

namespace FuzzyLogic.Mamdani
{
    /// <summary>
    /// Список значений нечеткой переменной
    /// </summary>
    public class UnionOfTerms
    {
        private readonly List<Term> _terms = new List<Term>();

        public double MaxValue(double x)
        {
            return _terms.Max(t => t.AccessoryFunc.GetActivatedValue(x));
        }

        public void Add(Term term)
        {
            _terms.Add(term);
        }

    }
}
