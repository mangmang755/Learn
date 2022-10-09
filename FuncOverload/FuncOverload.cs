using System;
namespace PolymorphismApplication
{
    class Printdata
    {
        void print(int i) { Console.WriteLine("输出整型: {0}", i); }
        void print(string s) { Console.WriteLine("输出字符串: {0}", s); }

        static void Main()
        {
            Printdata data = new Printdata();
            data.print(1);
            data.print("Hello");
            Console.ReadLine();
        }
    }
}