using System;
namespace InheritanceApplication
{
    class Shape
    {
        protected int width;
        protected int height;
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
    }

    //基类PaintCost
    public interface PaintCost
    {
        int getCost(int area);
    }

    //派生类
    class Rectangle : Shape, PaintCost
    {
        public int getArea()
        {
            return width * height;
        }
        public int getCost(int area)
        {
            return area * 70;
        }
    }
    class RectangleTester
    {
        static void Main()
        {
            Rectangle rect = new Rectangle();
            int area;
            rect.setWidth(7);
            rect.setHeight(5);
            area = rect.getArea();
            Console.WriteLine("总面积： {0}", rect.getArea());
            Console.WriteLine("油漆总成本： ${0}", rect.getCost(area));
            Console.ReadKey();
        }
    }
}