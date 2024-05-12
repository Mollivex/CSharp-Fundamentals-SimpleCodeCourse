using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

/*
 * ==========================================
 * OOP | Static | Methods | Static properties
 * ==========================================
 *      
 * --------------     
 * Static Methods
 * --------------     
 * 
 *      A static method in C# is a method that keeps only the copy of the method at the Type level, not the object level. The last updated value
 *  of the method is shared among all objects of that Type. That means all class instances share the exact copy of the method and its data.
 *  
 *      Static methods are called by using the class name, not the instance of the class.
 * 
 *      You can define one or more static methods in a non-static class. Static methods can be called without creating an object.
 *  You cannot call static methods using an object of the non-static class.
 *  
 *      The static methods can only call other static methods and access static members. You cannot access non-static members of
 *  the class in the static methods.
 *  
 *      These methods can only implement operations on static fields and properties and can't access non-static members.
 *  
 * --------------------------
 *  Rules for Static Methods:   #| Static methods can be defined using the static keyword before a return type and after an access mofidier.
 * --------------------------   
 *                              #| Static methods can be overloaded but cannot be overridden, because they belong to the class, and not to any instance of the class.
 *                              
 *                              #| Static methods can contain local static variables.
 *                              
 *                              #| Static methods cannot access or call non static variables unless they are explicitly passed as parameters.
 * 
 * --------------
 * Notable Points:  #| A static method can be invoked directly from the class level.
 * --------------   
 *                  #| A static method doesn't required any class object.
 *                  
 *                  #| Any Main() method is shared through the entire class scope, so it always appears with a static keyword.
 *                  
 */

namespace MyProject_91
{
    class MyClass
    {
        public MyClass() 
        {
            Counter++;
        } 

        private static int counter;
        public static int Counter
        {
            get { return counter; }
            private set { counter = value; }
        }

        public int ObjectsCount
        {
            get { return counter; }
        }

        public static int GetCounter()
        {
            return counter;
        }

        public int GetObjectsCount()
        {
            return counter;
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();
            MyClass myClass2 = new MyClass();

            Console.WriteLine(myClass1.ObjectsCount);

            MyClass myClass3 = new MyClass();

            Console.WriteLine(MyClass.Counter);
            Console.WriteLine(MyClass.GetCounter());    
        }
    }
}
