using FuzzyLogic.Mamdani.Problems;
using FuzzyLogic.Mamdani.Results;

namespace FuzzyLogic.Mamdani.Interfaces
{
    public interface IMamdaniService
    {
        ExecutionResult<double> SolveProblem(Problem problem);
        ExecutionResult<double> SolveProblem(ProblemConditions conditions, double[] input);

        string GetLog { get; }
    }
}
