using System;

namespace FuzzyLogic.Mamdani.Results
{
    /// <summary>
    /// Результат выполнения
    /// </summary>
    public class ExecutionResult
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }

        public static ExecutionResult Succeded()
        {
            return new ExecutionResult { Success = true };
        }

        public static ExecutionResult Error()
        {
            return new ExecutionResult { ErrorMessage = "Операция завершилась неудачно." };
        }

        public static ExecutionResult Error(string message)
        {
            return new ExecutionResult { ErrorMessage = message };
        }

        public static ExecutionResult Error(Exception e)
        {
            return new ExecutionResult { ErrorMessage = "Непридвиденная ошибка" + Environment.NewLine + e.ToString() };
        }
    }

    public class ExecutionResult<T> : ExecutionResult 
    {
        public T Data { get; set; }

        public static ExecutionResult<T> Succeded(T data)
        {
            return new ExecutionResult<T> {Data = data, Success = true};
        }

        public new static ExecutionResult<T> Error()
        {
            return new ExecutionResult<T> { ErrorMessage = "Операция завершилась неудачно." };
        }

        public new static ExecutionResult<T> Error(string message)
        {
            return new ExecutionResult<T> { ErrorMessage = message };
        }

        public new static ExecutionResult<T> Error(Exception e)
        {
            return new ExecutionResult<T> { ErrorMessage = "Непридвиденная ошибка" + Environment.NewLine + e.ToString() };
        }
    }
}
