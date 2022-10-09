using System;
namespace CalculatorApplication
{
    class NumberManipulatorAddress
    {
        public void swap(ref int x,ref int y)
        {
            int temp;
            temp = x; x = y; y = temp;
        }
        static void Main(string[] args)
        {
            NumberManipulatorAddress n = new NumberManipulatorAddress();
            int a = 100;
            int b = 200;
            Console.WriteLine("在交换之前，a 的值： {0}", a);
            Console.WriteLine("在交换之前，b 的值： {0}", b);

            n.swap(ref a, ref b);
            Console.WriteLine("在交换之后，a 的值： {0}", a);
            Console.WriteLine("在交换之后，b 的值： {0}", b);

            Console.ReadLine();
        }
    }
}