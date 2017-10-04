using System;

namespace FuzzyLogic.Mamdani.Exceptions
{
    /// <summary>
    /// Исключение модуля нечеткой логики
    /// </summary>
    public class MamdaniException : Exception
    {
        public MamdaniException(string message)
            : base(message)
        {
        }
    }
}
