using System;
namespace StaticFuncApplication
{
    class StaticFunc
    {
        public static int num;
        public void count() { num++; }
        public static int getnum() { return num; }
    }
    class StaticFuncTester
    {
        static void Main()
        {
            StaticFunc s = new StaticFunc();
            s.count();
            s.count();
            Console.WriteLine("变量 num： {0}", StaticFunc.getnum());
        }
        
        
    }
}