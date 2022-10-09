using System;
[AttributeUsage (AttributeTargets.All)]
public class HelpAttribute : System.Attribute

{
    private string topic;
    public readonly string Url;
    public string Topic  // Topic 是一个命名（named）参数
    {
        get { return topic; }
        set { topic = value; }
    }
    public HelpAttribute(string url)
    {
        this.Url = url;
    }  // url 是一个定位（positional）参数
    
}
[HelpAttribute("Information on the class MyClass")]
class Myclass
{

}
namespace AttributeAppl
{
    class Program
    {
        static void Main()
        {
            System.Reflection.MemberInfo info = typeof(Myclass);
            Console.WriteLine(info);
            object[] attributes = info.GetCustomAttributes(true);
            foreach (object attribute in attributes)
            {
                System.Console.WriteLine(attribute);
            }
            Console.ReadKey();
        }
    }
}
