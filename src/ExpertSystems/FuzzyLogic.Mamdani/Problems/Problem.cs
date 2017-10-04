namespace FuzzyLogic.Mamdani.Problems
{
    /// <summary>
    /// Задача нечеткой логики
    /// </summary>
    public class Problem
    {
        /// <summary>
        /// Условия
        /// </summary>
        public ProblemConditions ProblemConditions { get; set; }

        /// <summary>
        /// Входные данные
        /// </summary>
        public double[] InputData { get; set; }
    }
}
