using System;
namespace StaticVarApplication
{
    class StaticVar
    {
        public static int num;
        public void count() { num++; }
        public int getNum() { return num; }
    }

    class StaticTester
    {
        static void Main()
        {
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();
            Console.WriteLine("s1 的变量 num： {0}", s1.getNum());
            s1.count();
            s1.count();
            s1.count();
            s2.count();
            Console.WriteLine("s2 的变量 num： {0}", s2.getNum());
            s2.count();
            s2.count();
            Console.WriteLine("s2 的变量 num： {0}", s2.getNum());
            Console.ReadKey();
        }
    }
}