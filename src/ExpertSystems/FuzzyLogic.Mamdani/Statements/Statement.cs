namespace FuzzyLogic.Mamdani.Statements
{
    /// <summary>
    /// Выражение (определенное значение определенной переменной)
    /// </summary>
    public abstract class Statement
    {
        /// <summary>
        /// Нечеткая переменная
        /// </summary>
        public FuzzyVariable FuzzyVariable { get; }
        /// <summary>
        /// Значение
        /// </summary>
        public Term Term { get; }

        protected Statement(FuzzyVariable variable, Term term)
        {
            FuzzyVariable = variable;
            Term = term;
        }

        /// <summary>
        /// Для отображения в таблицах
        /// </summary>
        public new string ToString()
        {
            return FuzzyVariable.Name + "=" + Term.Name;
        }

        /// <summary>
        /// Для отображения в таблицах
        /// </summary>
        public string[] ToStringArray()
        {
            return new[] {FuzzyVariable.Name, Term.Name};
        }
    }
}
