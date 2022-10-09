using System;
namespace CalculatorApplication
{
    class NullablesAtShow2
    {
        static void Main(string[] args)
        {
            double? num1 = null;
            double? num2 = 3.1415;
            double num3 = num1 ?? 5.34;
            Console.WriteLine("num3 的值： {0}", num3);
            num3 = num2 ?? 5.34;
            Console.WriteLine("num3 的值： {0}", num3);
            Console.ReadLine();
        }
    }
}