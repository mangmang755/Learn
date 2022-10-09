//与直接赋值相比，使用反射赋值用时约长75倍，
using System;
using System.Reflection;
namespace System.Diagnostics
{
    public class MyClass
    {
        public int myField;
    }
    class Program
    {
        static void Main ()
        { 
            Stopwatch stopwatch = new Stopwatch();
            MyClass myObj = new MyClass ();
            Type myType = typeof (MyClass);

            FieldInfo fieldInfo = myType.GetField("myField");

            stopwatch.Start ();
            for (int i = 0; i < 10_000_000; i++)
            {
                fieldInfo.SetValue (myObj, 2);
            }
            stopwatch.Stop ();
            Console.WriteLine($"使用反射赋值1千万次耗时：{stopwatch.ElapsedMilliseconds}");

            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < 10_000_000; i++)
            {
                myObj.myField = 2;
            }
            stopwatch.Stop();
            Console.WriteLine($"直接赋值1千万次耗时：{stopwatch.ElapsedMilliseconds}");
            Console.Read();
        }
    }
}