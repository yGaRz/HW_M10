using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            while(t!=-1)
            {
                Console.WriteLine("Выберите 1 - сложение, 2 - деление");
                try
                {
                    t = int.Parse(Console.ReadLine());
                    int a = myIntCalc.EnterNumber();
                    int b = myIntCalc.EnterNumber();
                    if (t == 1)
                        Console.WriteLine(myIntCalc.Sum(a, b));
                    else if (t == 2)
                        Console.WriteLine(myIntCalc.Div(a, b));
                    else
                        Console.WriteLine("Выбрано не верное значение");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("На ноль делить нельзя");
                }
                catch(FormatException)
                {
                    Console.WriteLine("При вводе произошла ошибка, попробуйте еще раз.");
                }
            }
        }
    }

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
