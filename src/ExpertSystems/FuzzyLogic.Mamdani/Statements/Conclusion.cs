namespace FuzzyLogic.Mamdani.Statements
{
    /// <summary>
    /// Выражение - заключение
    /// </summary>
    public class Conclusion : Statement
    {
        public Conclusion(FuzzyVariable variable, Term term)
            : base(variable, term)
        {
        }
    }
}
