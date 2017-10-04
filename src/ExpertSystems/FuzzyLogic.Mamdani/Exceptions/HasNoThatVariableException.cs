namespace FuzzyLogic.Mamdani.Exceptions
{
    public class HasNoThatVariableException : MamdaniException
    {
        public HasNoThatVariableException() : base("Нет такой переменной")
        {
        }
    }
}
