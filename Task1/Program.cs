using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface ICalc<T>
    {
        public T Sum(T a, T b);
        public T Div(T a, T b);
    }
}
