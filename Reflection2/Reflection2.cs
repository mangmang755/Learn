using System;
using System.Reflection;//System.Reflection 类的 MemberInfo用于发现与类相关的特性（attribute）。
namespace BugFixApplication
{
    // 一个自定义特性 BugFix 被赋给类及其成员
    [AttributeUsage
    #region//定义了特性能被放在那些前面        
        (AttributeTargets.Class |//规定了特性能被放在class的前面
        AttributeTargets.Constructor |//规定了特性能被放在构造函数的前面
        AttributeTargets.Field |//规定了特性能被放在域的前面
        AttributeTargets.Method |//规定了特性能被放在方法的前面
        AttributeTargets.Property,//规定了特性能被放在属性的前面
    #endregion
        AllowMultiple = true)]//这个属性标记了我们的定制特性能否被重复放置在同一个程序实体前多次。

    public class DeBugInfo : System.Attribute//继承了预定义特性后的自定义特性
    {
        private int bugNo;
        private string developer;
        private string lastReview;
        public string message;

        public DeBugInfo(int bg, string dev, string d)//构造函数，接收三个参数并赋给对应实例
        {
            this.bugNo = bg;
            this.developer = dev;
            this.lastReview = d;
        }
        #region//定义对应的调用，返回对应值value
        public int BugNo
        {
            get
            {
                return bugNo;
            }
        }
        public string Developer
        {
            get
            {
                return developer;
            }
        }
        public string LastReview
        {
            get
            {
                return lastReview;
            }
        }
        //前面有public string message;
        public string Message//定义了可以通过Message = "",来对message进行赋值。
                             //因为不在构造函数中，所以是可选的
        {
            get
            { return message; }
            set
            { message = value; }
        }
        /*
         * 这部分可以简写如下
         * public string Message{get;set;}
        */
    }
    #endregion

    [DeBugInfo(45, "Zara Ali", "12/8/2012",
         Message = "Return type mismatch")]
    [DeBugInfo(49, "Nuha Ali", "10/10/2012",
         Message = "Unused variable")]//前面定义时的AllowMultiple=ture允许了多次使用在同一地方
    class Rectangle
    {
        protected double length;
        protected double width;//定义两个受保护的（封装）的成员变量
        public Rectangle(double l, double w)//构造函数，对两个成员变量进行初始化，公开的
        {
            length = l;
            width = w;
        }

        [DeBugInfo(55, "Zara Ali", "19/10/2012",
             Message = "Return type mismatch")]
        public double GetArea()
        {
            return length * width;
        }

        [DeBugInfo(56, "Zara Ali", "19/10/2012")]//因为message是可选项，所以可以不给出
                                                 //不给出即为null，为空白
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width:{0}", width);
            Console.WriteLine("Area:{0}", GetArea());//常规打印
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)//程序入口
        {
            Rectangle r = new Rectangle(4.5, 7.5);//实例化
            r.Display();//执行打印长、宽、面积

            Type type = typeof(Rectangle);//让type对应这个Rectangle类
            // 遍历 Rectangle 类的特性
            foreach (Object attributes in type.GetCustomAttributes(false))//遍历Rectangle的所有特性
            {
                DeBugInfo dbi = (DeBugInfo)attributes;//强制转换
                if (null != dbi)//dbi非空
                {
                    Console.WriteLine("Bug on: {0}", dbi.BugNo);
                    Console.WriteLine("Developer: {0}", dbi.Developer);
                    Console.WriteLine("Last REviewed: {0}", dbi.LastReview);
                    Console.WriteLine("Remarks: {0}", dbi.Message);
                }
            }
            // 遍历方法特性
            foreach (MethodInfo m in type.GetMethods())//遍历Rectangle类下的所有方法
            {
                foreach (Attribute a in m.GetCustomAttributes(true))//遍历每个方法的特性
                {
                    DeBugInfo dbi = a as DeBugInfo;//通过 object 声明对象，是用了装箱和取消装箱的概念.
                                                   //也就是说 object 可以看成是所有类型的父类。
                                                   //因此 object 声明的对象可以转换成任意类型的值。
                                                   //通过拆装箱代替强制转换
                    if (null != dbi)//同理打印
                    {
                        Console.WriteLine("BugFixApplication no: {0},for Method: {1}", dbi.BugNo, m.Name);
                        Console.WriteLine("Developer:{0}", dbi.Developer);
                        Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                        Console.WriteLine("Remarks: {0}", dbi.Message);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}