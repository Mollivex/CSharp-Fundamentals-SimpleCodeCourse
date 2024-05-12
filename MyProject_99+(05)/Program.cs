using MyProject_104;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

/*
 * ============================================================
 * OOP | Inheritance | as Operator | is Operator | Type-casting
 * ============================================================
 * 
 *      Two of the most common tasks a C# developer faces are type-casting and compatibility checking:
 *      
 *      #| Type-casting comes in handy when we would like to convert an object of a certain type to another object of the same type. 
 *      
 *      #| Compatibility checking is a facility in C# to support the casting operation. The support for this comes in form of two operators, one called 'as' and the other called 'is'.
 * 
 * ------------------------------------------------------------------------------------------------------------------------------------------------------------------
 * is Operator: The 'is' operator will check if the result of the expression is compatible with a given type by simply testing, and it will check whether the runtime 
 * ------------ type of an expression's result is compatible with a given type. The test against patterns came to C# as a feature with version 7.0. -----------------
 * 
 * -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 * as Operator: The 'as' operator is used to perform conversions between compatible types. It has a very similar role to the 'is' operator, however, it works differently under the hood.      
 * -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 *  
 * ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 * Differences Between As and Is:   #| The 'is' operator is used to check if the run-time type of an object is compatible with the given type or not, whereas the 'as' operator is used to
 * ------------------------------      perform conversion between compatible reference types or nullable types.
 *                                  
 *                                  #| The 'is' operator is of Boolean type, whereas the 'as' operator isn't.
 *                                  
 *                                  #| The 'is' operator returns true if the given object if of the same type, whereas the 'as' operator returns the object when they are compatible with
 *                                     the given type.
 *                                     
 *                                  #| The 'is' operator returns false if the given object isn't of the same type, whereas the 'as' operator returns null if the conversion isn't possible.
 *                                  
 *                                  #| The 'is' operator is used for only reference, boxing and unboxing conversions, whereas the 'as' operator is used only for a nullable, reference, and
 *                                     boxing conversions.
 *                                  -------------------------------------------------------------------------------------------------------------------------------------------------------
 */


namespace MyProject_104
{
    class Point
    {
        public Point()
        {
            
        }
        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
            Console.WriteLine("Constructor Point is called");
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public void Print()
        {
            Console.WriteLine($"X: {X}, Y: {Y}, Z: {Z}");
        }
    }

    }
    class Program
    {
        static void Main(string[] args)
        {
        // Using operator 'as' example
        object obj = new Point {X = 2, Y = -7, Z = 10 };
        Foo(obj);

        // Using operator 'is' example
        object obj1 = "";
        Bar(obj1);

        }
    /// <summary>
    /// Example how operator 'as' works
    /// </summary>
    /// <param name="obj"></param>
    static void Foo(object obj)
    {
        Point point = obj as Point;

        if (point != null)
        {
            point.Print();
        }
    }

    /// <summary>
    /// Example how operator 'is' works
    /// </summary>
    /// <param name="obj"></param>
    static void Bar(object obj)
    {
        if (obj is Point point) // we can at once assign new class object for our variable
        {
            point.Print();
        }
    }
}
