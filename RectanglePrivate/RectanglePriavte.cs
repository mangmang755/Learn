using System;
namespace RectanglePrivate
{
    class Rectangle
    {
        private double length;
        private double width;

        public void Acceptdetalis()
        {
            Console.WriteLine("输入长度：");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("输入宽度：");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}", GetArea());
        }
    }// end class Rectangle

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetalis();
            r.Display();
            Console.ReadLine();
        }
    }
}