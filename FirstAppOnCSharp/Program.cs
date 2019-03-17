using System;

namespace FirstAppOnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;
            int sumXandY = Calculator.Sum(x, y);

            Console.Write($"The sum of {x} and {y} is {sumXandY}");
            Console.ReadKey();
        }
    }

    class Calculator
    {
        public static int Sum(int x, int y)
        {
            return (x + y);
        }
    }
}
