using System.Linq;
using System.Text;
using FuzzyLogic.Mamdani.Exceptions;
using FuzzyLogic.Mamdani.Interfaces;
using FuzzyLogic.Mamdani.Problems;
using FuzzyLogic.Mamdani.Results;

namespace FuzzyLogic.Mamdani
{
    /// <summary>
    /// Базовая реализация IMamdaniService
    /// </summary>
    public class MamdaniService : IMamdaniService
    {
        private StringBuilder _logBuilder;

        /// <summary>
        /// Решение задачи нечеткой логики
        /// </summary>
        public ExecutionResult<double> SolveProblem(Problem problem)
        {
            _logBuilder = new StringBuilder();

            var checkResult = CheckConditions(problem.ProblemConditions);
            if (!checkResult.Success)
            {
                ExecutionResult<double>.Error(checkResult.ErrorMessage);
            }

            var fuzzificationResult = Fuzzificate(problem);
            var aggregationResult = Aggregate(problem, fuzzificationResult);
            var compositionResult = Composite(problem, aggregationResult);
            var defuzzificationResult = Defuzzificate(compositionResult);

            return ExecutionResult<double>.Succeded(defuzzificationResult);
        }

        /// <summary>
        /// Проверка ограничений
        /// </summary>
        private ExecutionResult CheckConditions(ProblemConditions problemConditions)
        {
            if (problemConditions.Variables.Count(x => x.IsResult) != 1)
                return ExecutionResult.Error("В задаче должна быть задана одна и только одна выходная переменная.");

            foreach (var rule in problemConditions.Rules)
            {
                if (!rule.Conclusion.FuzzyVariable.IsResult)
                    return
                        ExecutionResult.Error(
                            "Ошибка в правилах вывода. Заключение должно быть выражением относительно результирующей переменной. Правило с ошибкой: " +
                            string.Join(" => ", rule.ToStringArray()) + ". Результирующая переменная - " +
                            problemConditions.Variables.FirstOrDefault(x => x.IsResult).Name);
            }

            return ExecutionResult.Succeded();
        }

        /// <summary>
        /// Решение задачи нечеткой логики
        /// </summary>
        public ExecutionResult<double> SolveProblem(ProblemConditions conditions, double[] input)
        {
            var problem = new Problem
            {
                InputData = input,
                ProblemConditions = conditions
            };
            return SolveProblem(problem);
        }

        /// <summary>
        /// Получение лога выполнения операций
        /// </summary>
        public string GetLog => _logBuilder?.ToString();

        /// <summary>
        /// Фаззификация
        /// </summary>
        private double[] Fuzzificate(Problem problem)
        {
            if (problem.InputData == null)
                throw new ArgumentOutOfBoundsException();
            if (problem.InputData.Length != problem.ProblemConditions.Variables.Count - 1)
                throw new ArgumentOutOfBoundsException();

            double[] result = new double[problem.ProblemConditions.NumberOfConditions];
            int i = 0;

            InMemoryLogger.PrintMessage("Начало процедуры фаззификации");

            foreach (var rule in problem.ProblemConditions.Rules)
            {
                foreach (var condition in rule.Conditions)
                {
                    var id = condition.FuzzyVariable.Id;
                    var variable = condition.FuzzyVariable;
                    result[i] = variable.GetValueForTerm(condition.Term, problem.InputData[id]);
                    InMemoryLogger.PrintMessage("Значение нечеткой перемнной: " + variable.Name + " : " + result[i] + " ");
                    i++;
                }
                //InMemoryLogger.PrintMessage();
            }

            InMemoryLogger.PrintMessage("Процедура фаззификации завершена");
            return result;
        }

        /// <summary>
        /// Агрегация
        /// </summary>
        private double[] Aggregate(Problem problem, double[] fuzzificationResult)
        {
            int i = 0;
            int j = 0;
            double[] result = new double[problem.ProblemConditions.NumberOfConclusions];

            InMemoryLogger.PrintMessage("Начало процедуры аггрегации");

            foreach (var rule in problem.ProblemConditions.Rules)
            {
                double truthOfConditions = 1.0;
                foreach (var condition in rule.Conditions)
                {
                    truthOfConditions = System.Math.Min(truthOfConditions, fuzzificationResult[i]);
                    i++;
                }
                result[j] = truthOfConditions;
                InMemoryLogger.PrintMessage(rule + " Достоверность:" + result[j] + " ");
                j++;
            }
            //InMemoryLogger.PrintMessage();
            InMemoryLogger.PrintMessage("Процедура аггрегации завершена");

            return result;
        }

        /// <summary>
        /// Композиция
        /// </summary>
        private UnionOfTerms Composite(Problem problem, double[] aggregationResult)
        {
            var result = new UnionOfTerms();
            InMemoryLogger.PrintMessage("Начало процедуры композиции");

            int i = 0;

            foreach (var rule in problem.ProblemConditions.Rules)
            {
                var term = rule.Conclusion.Term.Clone();
                term.AccessoryFunc.SetActivatedValue(aggregationResult[i]);
                result.Add(term);
                i++;
            }

            InMemoryLogger.PrintMessage("Процедура композиции завершена");
            return result;
        }

        /// <summary>
        /// Дефаззификация
        /// </summary>
        private double Defuzzificate(UnionOfTerms compositionResult)
        {
            double x, y1 = 0.0, y2 = 0.0, step = 0.01;

            InMemoryLogger.PrintMessage("Начало процедуры дефаззификации");

            for (x = 0.0; x <= 1.0; x += step)
            {
                y1 += x * compositionResult.MaxValue(x);
            }
            for (x = 0.0; x <= 1.0; x += step)
            {
                y2 += compositionResult.MaxValue(x);
            }

            InMemoryLogger.PrintMessage("Результат: " + (y1 / y2));
            InMemoryLogger.PrintMessage("Процедура дефаззификации завершена");

            return y1 / y2;
        }
    }
}
