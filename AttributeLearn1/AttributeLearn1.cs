[AttributeUsage(AttributeTargets.All,Inherited = true,AllowMultiple = true)]
//其中，枚举组合AttributeTargets指定该特性生效的范围，默认为All即所有范围；
//布尔值Inherited指定应用该特性的成员在派生类中是否会继承该特性，默认为true；
//布尔值AllowMultiple指定能否为同一个元素指定多个此特性，默认为false
public class MyselfAttribute : Attribute
{
    public string ClassName { get; private set; }
    public string Author;
    public MyselfAttribute()
    {
        this.ClassName = ClassName;
    }
}
/*其中特性类的构造函数中的参数称为位置参数（Positional Parameters），
类中的其他公共字段和属性称为命名参数（Named Parameter）， 
通常情况下，将所有必选的参数定义为位置参数，将所有可选的参数定义为命名参数；
特性类和普通类一样可以进行构造函数的重载以适应各种情况下初始化参数的组合使用*/

//使用特性时，通过方括号[] 将特性名称括起来，
//并置于使用该特性的元素声明的上方或前方以指定特性，
//使用时可以省略Attribute后缀，根据想要初始化时调用特性类构造函数的不同，
//需要将该构造函数所需的参数（即位置参数）的值按照顺序传入，
//还可以选择是否指定命名参数的值，命名参数的值通过赋值运算符=显式指定：
[Myself("MyClass", Author = "You")]
//这个声明在概念上等效于：
//MyselfAttribute myselfObj = new MyselfAttribute("MyClass");
//myselfObj.Author = "Me";
//[Myself("MyClass", Author = "You")]  //特性Myself可以对同一元素指定多次
//也可以将多个特性合并在一个方括号里：
//[Myself("MyClass", Author = "Me"), Myself("MyClass", Author = "You")]
public class MyClass
{

}