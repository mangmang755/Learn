using System.Reflection.Emit;
using System.Reflection;
using System;
/*使用反射（Reflection）使得程序在运行过程中可以动态的获取对象或类型的类型信息，
然后调用该类型的方法和构造函数，或访问和修改该类型的字段和属性；
可以通过晚期绑定技术动态的创建类型的实例；可以获取程序集中的所有类型信息；
可以在动态构建新类型；还可以检索元素所添加的特性；
　　※反射相关的类基本都位于命名空间System.Reflection中；
　　※动态构建新类型的类位于命名空间System.Reflection.Emit中；

    访问或修改类型的实例、静态字段：*/
namespace AttributeTest
{
    public class MyClass
    {
        public int myField;
        public static int myStaticField;
    }
    
    /*class Test
    {   //使用方式：
        //访问或修改类型的实例字段myField
        MyClass myObj = new MyClass() { myField = 1 };//创建实例
        Type myType = typeof(MyClass);//获取类型，或myObj.GetType()

        FieldInfo fieldInfo = myType.GetField("myField");//获取类型中指定的字段信息
       Console.WriteLine((int) fieldInfo.GetValue(myObj)); //1，获取实例字段的值
       fieldInfo.SetValue(myObj, 2); //给实例字段赋值 

            //访问或修改类型的静态字段myStaticField
            FieldInfo staticFieldInfo = myType.GetField("myStaticField"); //获取类型中指定的字段信息
        Console.WriteLine(staticFieldInfo.GetValue(null)); //0，获取静态字段的值
            staticFieldInfo.SetValue(null, 2); //给静态字段赋值
    }*/


}