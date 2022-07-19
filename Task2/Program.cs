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

  
}
