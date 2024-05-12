
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ================================================
 * OOP | Interfaces in C# | Explicit implementation
 * ================================================
 * 
 *      Explicit implementation is useful when class is implementing multiple interfaces; thereby, it is more readable and eliminates the confusion.
 *  It's also useful if interfaces have the same method name coincidently.
 *  
 *      If a class implements two interfaces that contain a member with the same signature, then implementing that member on the class will cause both
 *  interfaces to use that memmber as their implementation.
 *  
 *      An explicit interface implementation doesn't have an access modifier since it isn't accessible 
 *  as a member of the type it's defined in. Instead, it's only accessible when called through an instance 
 *  of the interface. If you specify an access modifier for an explicit interface implementation, you get
 *  compiler error CS0106.
 *  
 *      But you might not want the same implementation to be called for both interfaces. To call a different implementation depending on which interface
 *  is in use, you can imlement an interface member explicitly. An explicit interface implementation is a class member that is only called through the
 *  specified interface. Name the class member by prefixing it with the name of the interface and a period.
 * 
 */

namespace MyProject_117
{
    interface IFirstInterface
    {
        void Action();
    }
    interface ISecondInterface 
    { 
        void Action();
    }
    class MyClass: IFirstInterface, ISecondInterface
    {
        public void Action()
        {
            Console.WriteLine("MyClass Action...");
        }
    }
    class MyOtherClass : IFirstInterface , ISecondInterface
    {
        void IFirstInterface.Action()
        {
            Console.WriteLine("MyClass FirtsInterface.Action...");
        }
        void ISecondInterface.Action()
        {
            Console.WriteLine("MyClass SecondInterface.Action...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Foo(myClass);
            Bar(myClass);

            Console.WriteLine();

            MyOtherClass myOtherClass = new MyOtherClass();
            Foo(myOtherClass);
            Bar(myOtherClass);

            Console.WriteLine();

            ((IFirstInterface)myOtherClass).Action();
            ((ISecondInterface)myOtherClass).Action();

            Console.WriteLine();

            // Example of using AS/IS operators
            if (myOtherClass is IFirstInterface firstInterface)
            {
                firstInterface.Action();
            }
        }
        static void Foo(IFirstInterface firstInterface)
        {
            firstInterface.Action();
        }
        static void Bar(ISecondInterface secondInterface)
        {
            secondInterface.Action();
        }
    }
}
