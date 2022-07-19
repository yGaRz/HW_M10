using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            while (t != -1)
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
                catch (FormatException)
                {
                    Console.WriteLine("При вводе произошла ошибка, попробуйте еще раз.");
                }
            }
        }
    }  
}