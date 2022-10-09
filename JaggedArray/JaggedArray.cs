using System;
namespace ArrayApplication
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            /* 一个由 3 个整型数组组成的交错数组 */
            int[][] a = new int[][]
            {
                new int[]{ 1,2,3 },new int[]{ 4,5,6,7,8 },
                new int[]{ 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 }
            };
            int i, j;
            for (i = 0; i < a.Length; i++)
            {
                for (j = 0; j < a[i].Length; j++)
                {
                    Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]);
                }
            }
            Console.ReadKey();
        }
    }
}
