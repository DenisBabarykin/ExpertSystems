namespace FuzzyLogic.Mamdani.Exceptions
{
    public class HasNoThatTermException : MamdaniException
    {
        public HasNoThatTermException() : base("Не найден такой терм")
        {
        }
    }
}
