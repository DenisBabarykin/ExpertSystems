using System;
using System.IO;
using FuzzyLogic.Mamdani.Exceptions;
using FuzzyLogic.Mamdani.Results;

namespace FuzzyLogic.Mamdani.Problems
{
    /// <summary>
    /// Класс реализующий функции загрузки/выгрузки в формате xml
    /// </summary>
    public static class ProblemConditionsHelper
    {
        /// <summary>
        /// Загрузка из файла xml
        /// </summary>
        public static ExecutionResult<ProblemConditions> ReadConditionsFromXmlStream(Stream stream)
        {
            try
            {
                var result = ProblemConditionsReader.ReadFromXmlStream(stream);
                if (result != null)
                {
                    return ExecutionResult<ProblemConditions>.Succeded(result);
                }
                return ExecutionResult<ProblemConditions>.Error("Не удалось распознать документ");
            }
            catch (ProblemConditionsParseException e)
            {
                return ExecutionResult<ProblemConditions>.Error(e.Message);
            }
            catch (Exception e)
            {
                return ExecutionResult<ProblemConditions>.Error(e);
            }
        }

        /// <summary>
        /// Загрузка из текста xml
        /// </summary>
        public static ExecutionResult<ProblemConditions> ReadConditionsFromXmlString(string xmlString)
        {
            try
            {
                var result = ProblemConditionsReader.ReadFromXmlString(xmlString);
                if (result != null)
                {
                    return ExecutionResult<ProblemConditions>.Succeded(result);
                }
                return ExecutionResult<ProblemConditions>.Error("Не удалось распознать документ");
            }
            catch (ProblemConditionsParseException e)
            {
                return ExecutionResult<ProblemConditions>.Error(e.Message);
            }
            catch (Exception e)
            {
                return ExecutionResult<ProblemConditions>.Error(e);
            }
        }

        /// <summary>
        /// Запись в файл xml
        /// </summary>
        public static void WriteToFile(ProblemConditions conditions, string filePath)
        {
            ProblemConditionsWriter.WriteXmlToFile(conditions, filePath);
        }
    }
}
