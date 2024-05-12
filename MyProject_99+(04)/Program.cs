using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ====================================================================
 * OOP | Inheritance | base Keyword | Inheritance and Class Constructor
 * ====================================================================
 * 
 *      In C# we use the 'base' keyword to call the method of the base class from the derived class.
 *      
 *      The 'base' keyword is used to access members of the base class from within a derived class. 
 * 
 * -------------------------------------------------------------------------------------------------------------------------------
 *  #Use it if you want to: #| Call a method on the base class that has been overridden by another method.
 *                          
 *                          #| Specify which base-class constructor should be called when creating instances of the derived class.
 * -------------------------------------------------------------------------------------------------------------------------------
 *      
 *      The base class access is permitted only in a constructor, in an instance method, and in an instance property accessor.
 *      
 *      Using the 'base' keyword from within a static method will give an error.
 *      
 *      The base class that is accessed is the base class specified in the class declaration. 
 *      For example, if you specify class ClassB : ClassA, the members of ClassA are accessed from classB, regardless of the base class of ClassA.
 * 
 * ---------------------------
 * Accessing base class field:  We can use the base keyword to access the fields of the base class within derived class. It's useful if base and derived
 * ---------------------------  classes have the same fields. If derived class doesn't define same field, there is no need to used base keyword. Base class
 *                              field can be directly accessed by the derived class.
 * 
 * --------------------------
 * Calling base class method:  By the help of base keyword, we can call the base class method also. It's useful if base and derived classes defines same method.
 * --------------------------  In other words, if method is overridden. If derived class doesn't define same method, there is no need to use base keyword. Base
 *                             class method can be directly called by the derived class method.
 * 
 */

namespace MyProject_103
{
    class MyTestClass
    {
        public MyTestClass()
        {
            Console.WriteLine("Constructor MyTestClass called");
        }
    }
    class Point2D : MyTestClass
    {
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("Constructor Point2D called");
        }
        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.WriteLine($"X:\t{X}");
            Console.WriteLine($"Y:\t{Y}");
        }
    }
    class Point3D : Point2D
    {
        public Point3D(int x, int y, int z) : base (x, y)
        {
            Z = z;
            Console.WriteLine("Constructor Point3D called");
        }
        public int Z { get; set; }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Z:\t{Z}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D(3, 4, 5);
            point.Print();

            Console.WriteLine();
        }
    }
}
