using System;
namespace ConsoleApp4
{
    //Interface members are by default abstract and public.
    //An interface cannot contain a constructor (as it cannot be used to create objects).
    //C# does not support "multiple inheritance" (a class can only inherit from one base class). However, it can be achieved with interfaces, because the class can implement multiple interfaces.
    //You do not have to use the override keyword when implementing an interface.

    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Method from first interface.");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Method from Second interface.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();
        }
    }
}
