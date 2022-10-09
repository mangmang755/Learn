//#define PI
using System;
namespace PreprocessorDAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            #if (PI)
            Console.WriteLine("PI is defined");     //PI存在，则这条语句编译
            #else
            Console.WriteLine("PI is not defined"); //PI不存在，则这条语句编译
            #endif
            Console.ReadKey();
        }
    }
}