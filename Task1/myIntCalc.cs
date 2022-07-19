using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class myIntCalc : ICalc<int>
    {
        public static int EnterNumber()
        {
            Console.WriteLine("Введите число");
            return int.Parse(Console.ReadLine());
        }
        public static int Div(int a, int b)
        {
            if (b != 0)
                return a / b;
            throw new DivideByZeroException();
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }

    public interface ICalc<T>
    {
        public static T Sum(T a, T b) { return default(T); }
        public static T Div(T a, T b) { return default(T); }
    }
}
