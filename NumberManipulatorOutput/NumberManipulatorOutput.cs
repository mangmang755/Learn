using System;
namespace CalculatorApplication {
    class NumberManipulatorOutput
    {
        public void getValues(out int x,out int y)
        {
            Console.WriteLine("input first value:");
            x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input second value:");
            y = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            NumberManipulatorOutput n=new NumberManipulatorOutput();
            int a, b;
            n.getValues(out a,out b);
            Console.WriteLine("在方法调用之后，a 的值： {0}", a);
            Console.WriteLine("在方法调用之后，b 的值： {0}", b);
            Console.ReadLine();
        }
    }
}