using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =====================================
 * Stuctures in C# | Boxing and unboxing
 * =====================================
 *      
 *      A value of a class type can be coverted to type object or to an interface type that is implemented by the class
 *  simply by treating the reference as another type at compile-time. Likewise, a value type object or a value of an 
 *  interface type can be converted back to a class type without changing the reference (but, of course, a run-time type 
 *  check is required in this case). 
 *  
 *      Since structs are not reference types, these operations are implemented differently for struct types. When a value
 *  of a struct type is converted to certain reference types, a boxing operation takes place. Likewise, when a value of certain
 *  reference types is converted back to a struct type, an unboxing operation takes place. 
 *      
 *      A key difference from the same operations on class types is that boxing and unboxing copies the struct value either
 *  into or out of the boxed instance.
 *  
 *  NOTE: Thus, following a boxing or unboxing operation, changes made to the struct are not reflected in the boxed struct.
 *  
 *  NOTE: You can use ILSpy extension for VS Studio, which can show you where are boxing and unboxing operation in your code.
 * 
 */

namespace MyProject_125
{
    interface IPrintable
    {
        void Print();
    }
    struct Point : IPrintable
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.WriteLine($"X: {X}\tY: {Y}");
        }
    }
    class Program
    {
        static void Print(IPrintable printable)
        {
            printable.Print();
        }
        static void Main(string[] args)
        {
            Point point = new Point { X = 2 , Y = 3 };
            Print(point); // boxing operation (view ILSpy)
        }
    }
}
