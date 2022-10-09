using System;
namespace StringApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串连接
            string fname="Rowan", lname="Atkison";
            string fullname = fname + lname;
            Console.WriteLine(fullname);

            //string构造函数
            char[] letter = {'h','e','l','l','o' };
            string greeting = new string(letter);
            Console.WriteLine(greeting);

            //方法返回字符串
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message:{0}",message);

            //用于转化值的格式化方法
            DateTime waiting = new DateTime(2012,10,10,17,58,1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}",chat);
            Console.ReadLine();
        }
    }
}