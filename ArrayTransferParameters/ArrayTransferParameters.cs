using System;
namespace ArrayApplication
{
    class ArrayTransferParameters
    {
        double getAverage(int[] arr)
        {
            double avg;
            int sum = 0;

            foreach(int member in arr)
            {
                sum += member;
            }
            avg=(double)sum/ arr.Length;
            return avg;
        }

        static void Main(string[] args)
        {
            ArrayTransferParameters arr = new ArrayTransferParameters();
            int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            double avg = arr.getAverage(balance);
            Console.WriteLine(avg);
            Console.ReadLine();
        }
    }

}
