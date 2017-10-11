using FuzzyLogic.Mamdani.Interfaces;

namespace FuzzyLogic.Mamdani
{
    /// <summary>
    /// Значение нечеткой переменной
    /// </summary>
    public class Term
    {
        /// <summary>
        /// Функция принадлежности
        /// </summary>
        public IAccessoryFunc AccessoryFunc { get; set; }
        
        /// <summary>
        /// Лингвистическое значение
        /// </summary>
        public string Name { get; set; }

        private Term()
        {
        }

        /// <summary>
        /// Конструктор для создания значения с трапециевидной функцией принадлежности
        /// </summary>
        public Term(string name, double a, double b, double c, double d)
        {
            Name = name;
            AccessoryFunc = new TrapFunc(a, b, c, d);
        }

        /// <summary>
        /// Создание клона значения (для неизменности исходного)
        /// </summary>
        public Term Clone()
        {
            return new Term
            {
                AccessoryFunc = AccessoryFunc.CopyFunc(),
                Name = Name
            };
        }

        /// <summary>
        /// Метод для вывода описания значения переменной в таблицу
        /// </summary>
        /// <returns></returns>
        public string[] ToStringArray()
        {
            var trapFunc = AccessoryFunc as TrapFunc;
            if (trapFunc == null)
                return new string[0];

            return new[] { Name, trapFunc.A.ToString(), trapFunc.B.ToString(), trapFunc.C.ToString(), trapFunc.D.ToString()};
        }
    }
}
