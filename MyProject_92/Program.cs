using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ==========================
 * OOP | Static | Constructor
 * ==========================
 * 
 * -------------------    
 * Static Constructors
 * -------------------
 * 
 *      A non-static class can contain a parameterless static constructor. It can be defined with the static keyword and
 *  without access modifiers like public, private and protected.
 *  
 *      Below is the following example demonstrates the difference between static constructor and instance constructor.
 * 
 *      The non-static class StopWatch contains a static constructor and also a non-static constructor.
 *      
 *      The static constructor is called only once whenever the static method is used or creating an instance for the first time.
 *  The following example shows that the static constructor gets called when the static method called for the first time.
 *  Calling the static method second time onwards won't call a static constructor.
 * 
 * ------------------------------
 * Rules for Static Constructors:       #| The static constructor is defined using the static keyword and without using access modifiers public, private, or protected
 * ------------------------------
 *                                      #| A non-static class can contain one parameterless static constructor. Parameterized static constructor aren't allowed.
 *                                      
 *                                      #| Static constructor will be executed only once in the lifetime. So, you cannot determine when it will get called in an application
 *                                         if a class is being used at multiple places.
 *                                      
 *                                      #| A static constructor can only access static members. It cannot contain or access instance member.
 *                                      
 *                                      #| The user has no control on when the static constructor is executed in the program.
 *                                      
 *                                      #| A static constructor is called automatically to initialize the class before the first instance is 
 *                                         created or any static members are referenced.
 *                                      
 *                                      #| A typical use of static constructors is when the class is using a log file and the constructor is used to write entries to this file.
 * 
 */

namespace MyProject_92
{
    class Stopwatch 
    {
        /// <summary>
        /// static constructor
        /// </summary>
        static Stopwatch()
        {
            Console.WriteLine("Static constructor called");
        }

        /// <summary>
        /// instance constructor
        /// </summary>
        public Stopwatch()
        {
            Console.WriteLine("Instance constructor called");
        }

        /// <summary>
        /// static method
        /// </summary>
        public static void DisplayInfo()
        {
            Console.WriteLine("DisplayInfo called");
        }

        /// <summary>
        /// instance method
        /// </summary>
        public void Start()
        {

        }
        /// <summary>
        /// instance method
        /// </summary>
        public void Stop()
        {

        }
    }
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Non-static constructor");
        }


        static MyClass()
        {
            Console.WriteLine("Static constructor");
            a = 3; // we can use only static fields and methods in static class constructor
            Bar();
        }
        
        static int a; 
        public static void Bar()
        {

        }

        public static void Foo()
        {
            Console.WriteLine("Foo ");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            // Stopwatch class example
            Stopwatch sw1 = new Stopwatch(); // here is the first static constructor and then instance constructor called 
            Stopwatch sw2 = new Stopwatch(); // only instance constructor called
            Stopwatch.DisplayInfo();
            Console.WriteLine();

            // #SimpleCode static constructors example
            MyClass.Foo(); // here is the first static constructor called

            new MyClass();
            new MyClass();
            new MyClass();

        }
    }
}
