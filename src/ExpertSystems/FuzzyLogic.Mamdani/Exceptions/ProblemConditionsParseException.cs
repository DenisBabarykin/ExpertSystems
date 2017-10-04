using System;

namespace FuzzyLogic.Mamdani.Exceptions
{
    internal class ProblemConditionsParseException : Exception
    {
        public ProblemConditionsParseException(string message) : base(message) { }
    }
}
