using System;
using System.Collections.Generic;
public class Shape
{
    public int X { get; private set; }
    public int Y { get; private set; }
    /*public int X { get; set; }是其简写:
    private int x; //编译器创建的一个私有的匿名支持字段
    public int X {
    get { return this.x; }
    set { this.x = value; }
    }
    public int x {get;private set;}是另一种简写,
    set前面的private声明是告诉编译器属性X是只读（read-only）的.
    意思是对于外部类不能通过属性X给x赋值,而只能读取其值。*/
    public int Width { get; set; }
    public int Height { get; set; }

    //虚方法
    public virtual void Draw()
    {
        Console.WriteLine("执行基类的画图任务");
    }
}
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("画一个圆形");
        base.Draw();
    }
}
class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("画一个长方形");
        base.Draw();
    }
}
class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("画一个三角形");
        base.Draw();
    }
}

class Program
{
    static void Main()
    {
        // 创建一个 List<Shape> 对象，并向该对象添加 Circle、Triangle 和 Rectangle
        var shape = new List<Shape> {
            new Rectangle(),
            new Triangle(),
            new Circle()};
        foreach (var s in shape)
        {
            s.Draw();
        }
        Console.WriteLine("按下任意键退出。");
        Console.ReadKey();
    }
}
