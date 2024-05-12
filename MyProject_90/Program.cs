using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ===============================================
 * OOP | Static | Fields | Static modifier keyword
 * ===============================================
 *      
 *      In C#, static is a keyword or modifier that belongs to the type not instance. So instance in not required to access the static members.
 *  In C#, static can be field, method, constructor, class, properties, operator and event.
 *  
 *      If you use the "static" keyword for the declaration of a field/property or a method, it's called a "Static member". The main feature of a non static
 *  member is that it will not be bound to any object. Instead, it's individually accessible with the class name. In other words, the static members are accessible
 *  directly without creating one object.
 *  
 *  #NOTE: Indexers and destructors cannot be static (\this etc.)
 * 
 * -------------------------------
 * Advantage of C# static keyword:  Memory efficient: Now we don't need to create instance for accessing the static members, so it savers memory. 
 * -------------------------------                    Moreover, it belongs to the type, so it will not get memory each time when instance is created.
 * 
 * -----------------------
 * -!- Static Field C# -!-
 * -----------------------
 * 
 *      It's the memory will be allocated individually, without any relation to the object.
 *      
 *      A field which is declared as static, is called static field. Unlike instance field which gets memory each time whenever you create object,
 *  there is only one copy of static field created in the memory. It's shared to all the objects.
 *  
 *      If you change the value of static field, it will be applied to all the objects.
 *      
 */

namespace MyProject_90
{
    class MyClass
    {
        public static int b; // static field
        public void SetB(int b)
        {
            MyClass.b = b;
        }
        public void PrintB()
        {
            Console.WriteLine(b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();
            myClass1.SetB(9);

            MyClass myClass2 = new MyClass();
            myClass2.PrintB();
        }
    }
}
