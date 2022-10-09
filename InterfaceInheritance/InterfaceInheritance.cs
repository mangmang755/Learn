using System;
interface IParentInterface
{
    void ParentInterfaceMethod();

}
interface IMyInterface : IParentInterface
{
    void MethodToImplement();
}
class InterfaceImplementer : IMyInterface

{
    public void ParentInterfaceMethod()
    {
        Console.WriteLine("ParentInterfaceMethod() called.");
    }
    public void MethodToImplement()
    {
        Console.WriteLine("MethodToImplement() called.");
    }
    static void Main()
    {
        InterfaceImplementer iImp = new InterfaceImplementer();
        iImp.ParentInterfaceMethod();
        iImp.MethodToImplement();
    }
}