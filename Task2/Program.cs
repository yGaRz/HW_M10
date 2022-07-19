using System;

namespace Task2
{
    class Program
    {

        static void Main(string[] args)
        {

            MessageWriter messageWriter = new MessageWriter();
            myIntCalc calc = new myIntCalc();
            calc.logger = messageWriter;
            int t = 0;
            while (t != -1)
            {
                calc.Work();
            }
        }
    }

    public class myIntCalc : ICalc<int>
    {
        public Ilogger logger;

        public void Work()
        {
            Console.WriteLine("Выберите 1 - сложение, 2 - целочисленное деление");
            try
            {
                int t = int.Parse(Console.ReadLine());
                int a = EnterNumber();
                int b = EnterNumber();
                if (t == 1)
                    logger.Write(Sum(a, b).ToString());
                else if (t == 2)
                    logger.Write(Div(a, b).ToString());
                else
                    logger.WriteException("Выбрано не верное значение");
            }
            catch (DivideByZeroException)
            {
                logger.WriteException("На ноль делить нельзя");
            }
            catch (FormatException)
            {
                logger.WriteException("При вводе произошла ошибка, попробуйте еще раз.");
            }
        }
        public int EnterNumber()
        {
            logger.Write("Введите число");
            return int.Parse(Console.ReadLine());
        }
        public int Div(int a, int b)
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

    public class MessageWriter : Ilogger
    {
        public void Write(string str)
        {
            Console.WriteLine(str);
        }
        public void WriteException(string str)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(str);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }

    public interface Ilogger
    {
        public void Write(string str);
        public void WriteException(string str);
    }

    public interface ICalc<T>
    {
        public static T Sum(T a, T b) { return default(T); }
        public static T Div(T a, T b) { return default(T); }
    }
}
