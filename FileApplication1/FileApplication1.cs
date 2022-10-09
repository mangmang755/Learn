using System.IO;
namespace FileApplication1
{
    class Program
    {
        static void Main()
        {
            try
            {
                // 创建一个 StreamReader 的实例来读取文件 
                // using 语句也能关闭 StreamReader
                using(StreamReader sr = new StreamReader(@"D:\C#\FileApplication1\Jamaica.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                // 向用户显示出错消息
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}