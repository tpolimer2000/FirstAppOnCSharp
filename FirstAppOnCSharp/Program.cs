using System;

namespace FirstAppOnCSharp
{
    /// <summary>
    /// Запускаемый класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Метод Main вызывается при старте программы.
        /// </summary>
        /// <param name="args">Массив аргументов.</param>
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;
            int sumXandY = Calculator.Sum(x, y);

            Console.Write($"The sum of {x} and {y} is {sumXandY}");
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс, который содержит методы для математических операций над числами.
    /// </summary>
    class Calculator
    {
        /// <summary>
        /// Метод Sum выполняет суммирование 2-х переменных.
        /// </summary>
        /// <param name="x">Первое слагаемое.</param>
        /// <param name="y">Второе слагаемое</param>
        /// <returns>Развращает сумму x и у.</returns>
        public static int Sum(int x, int y)
        {
            return (x + y);
        }
    }
}
