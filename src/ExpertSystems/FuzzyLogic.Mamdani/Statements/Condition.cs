namespace FuzzyLogic.Mamdani.Statements
{
    /// <summary>
    /// Выражение - часть условия
    /// </summary>
    public class Condition : Statement
    {
        public Condition(FuzzyVariable variable, Term term)
            : base(variable, term)
        {
        }
    }
}
