using System;
namespace ArrayApplication{
    class ParamArray
    {
        public static void UseParams(params int[] list)
        {
            for(int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
        public static void UseParams2(params object[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            UseParams(1, 2, 3, 4);
            UseParams2(1, 'a', "Apple");
            int[] myIntArray = { 5, 6, 7, 8, 9 };
            UseParams(myIntArray);
            object[] myObjectArray = { 1, 'b', "boom", "app" };
            UseParams2(myObjectArray);
            UseParams2(myIntArray);//输出为"System.Int32[]"
        }
    }
}