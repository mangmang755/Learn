using System;
namespace PolymorphismApplication
{
    abstract class Shape
    {
        abstract public int area();//只能存在于抽象类
        public virtual void Draw() { }//必须有{}
    }
    class Rectangle : Shape
    {
        private int len;
        private int wid;
        public Rectangle(int a=0,int b = 0)
        {   //构造函数
            len = a;
            wid = b;
        }
        public override int area()
        {
            Console.WriteLine("Rectangle 类的面积： ");
            return wid * len;
        }

    }
    class RectangleTester
    {
        static void Main()
        {
            Rectangle rect = new Rectangle(10, 7);
            double a = rect.area();
            Console.WriteLine("面积： {0}", a);
            Console.ReadKey();
        }
    }
}