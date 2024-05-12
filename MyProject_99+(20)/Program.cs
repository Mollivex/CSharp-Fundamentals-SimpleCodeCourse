using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
 * ===================================================
 * Structures in C# | struct keyword | Struct VS Class
 * ===================================================
 * 
 *      https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/
 * 
 *      Structs are similar to classes in that they represent data structures that can contain data members and function members.
 *  However, unlike classes, structs are value types and don't require heap allocation. A variable of a 'struct' type directly contains
 *  the data of the 'struct', whereas a variable of a class type contains a reference to the data, the latter known as an object.
 *  
 *  #| Classes and Structures have  
 *     the following basic difference: - classes are reference types and structs are value types.
 *                                     - structures don't support inheritance, but can implement interfaces.
 *                                     - structures cannot have default constructor.
 *  
 * ---------------------------------------------------------------------------------------------------------------------------
 * NOTE: Structs are particularly useful for small data structures that have value semantics. Complex numbers, points in a
 *       coordinate system, or key-value pairs in a dictionary are all good examples of structs. Key to these data structures 
 *       is that they have few data members, that they don't require use of inheritance or reference semantics, rather they
 *       can be conveniently implemented using value semantics where assignment copies the value instead of the reference.
 * ---------------------------------------------------------------------------------------------------------------------------
 * ............................................................................................................................
 *  !#! Structs differ from classes in several important ways:-----------------------------------------------------------------
 *          
 *          #| Structs are value types, classes are reference types.
 *          
 *          #| Unlike classes, structures cannot inherit other structures or classes.
 *          
 *          #| Structures cannot be used as a base for other structures or classes.
 *          
 *          #| All struct types implicitly inherit from the class System.ValueType
 *          
 *          #| Assignment to a variable of a struct type creates a copy of the value being assigned.
 *          
 *          #| The default value of a struct is the value produced by setting all field to their default value.
 *          
 *          #| Boxing and unboxing operations are used to convert between a struct type and certain refrence types.
 *          
 *          #| The meaning of 'this' is different within struct members.
 *          
 *          #| Instance filed declarations for a struct are not permitted to unclude variable initializers.
 *          
 *          #| A struct is not permitted to declare a parameterless instance constructor.
 *          
 *          #| Structure members cannot be abstract, virtual, or protected.
 * ---------------------------------------------------------------------------------------------------------------------------
 * 
 * ---------------------------------------------------
 * Best practices for using Structs and Classes in C#:
 * ---------------------------------------------------
 * 
 *      When using structs, it's important to keep their size small, so they're stored on the stack instead of the heap. This can
 *  help to improve performance and reduce memory usage.
 *      
 *     When using classes, it's a good idea to use inheritance to create hierarchies of objects with shared properties and methods.
 *  This can help to reduce code duplication and make your code more maintainable.
 *  
 *      Another imporant consideration when using strcuts and classes in C# is to use them appropriately based on their intended purpose.
 *  Structs are best used for small, simple data structures thta don't require a lot of functionality, while classes are better suited for 
 *  more complex objects with behavior and functionality.
 * 
 * 
 */

namespace MyProject_119
{
    interface IInterface
    {
        void Foo();
    }
    public class ClassPoint : IInterface
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Foo()
        {
            var t = X + Y;
        }
        public void Print()
        {
            Console.WriteLine($"X:{X}\tY:{Y}");
        }
    }
    public struct StructPoint : IInterface
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Foo()
        {
            var t = X + Y;
        }

        public void Print()
        {
            Console.WriteLine($"X:{X}\tY:{Y}");
        }
    }
    public class Program
    {
        static void Foo(ClassPoint classPoint)
        {
            classPoint.X++;
            classPoint.Y++;
        }
        static void Bar(StructPoint structPoint)
        {
            structPoint.X++;
            structPoint.Y++;
        }
        static void Main(string[] args)
        {
            ClassPoint classPoint1 = new ClassPoint { X=2, Y=3 };
            ClassPoint classPoint2 = new ClassPoint { X=2, Y=3 };

            bool classesAreEqual = classPoint1.Equals(classPoint2);

            StructPoint structPoint1 = new StructPoint { X=2, Y=3 };
            StructPoint structPoint2 = new StructPoint { X=2, Y=3 };

            bool structsAreEqual = structPoint1.Equals(structPoint2);
        }
    }
}
