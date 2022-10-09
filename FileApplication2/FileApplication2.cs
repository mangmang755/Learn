using System.IO;
namespace FileApplication2
{
    public class Program
    {
        static void Main()
        {
            string[] names = new string[] { "Zara Ali", "Nuha Ali" };
            using(StreamWriter sw = new StreamWriter(@"D:\C#\FileApplication2\names.txt"))
            {
                foreach (string name in names)
                {
                    sw.WriteLine(name);
                }
            }
            string line;
            using(StreamReader sr = new StreamReader(@"D:\C#\FileApplication2\names.txt"))
            {
                while((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadLine();
        }
    }
}