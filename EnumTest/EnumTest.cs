using System;
public class EnumTest
{
    enum Day { Sun,Mon,Tue,Wed,Thu,Fri,Sat};
    static void Main()
    {
        int x =(int)Day.Sun;
        int y =(int)Day.Mon;
        Console.WriteLine("Sun = {0}",x);
        Console.WriteLine("Mon = {0}",y);
    }
}