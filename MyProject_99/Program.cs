using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ========================================================================================
 * OOP | const vs readonly | Difference between const and readonly in C# | const and static
 * ========================================================================================
 * 
 *      The main difference between \const and \readonly keywords in C# is that \const need to be defined at the time of assignment, while \readonly field can be defined at runtime.
 *  Const's are implicitly static, while readonly values don't have to be static.
 *  
 *      Moreover, \const and \readonly have different behavior when working with assemblies. Constants are copied into every assembly that uses them, while \readonly fields are shared across assemblies.
 *      
 *      Constants don't have memory allocation during runtime because they are embedded into IL code. On the other hand, readonly fields allocate memory because they are stored in the loader heap.
 * 
 *      Following are some of the important differences between readonly and const keywords:
 *      
 *      --------------------------------------------------------------------------------------------------------------------------------------------
 *      |No.|      Key         |                  readonly keyword                     |                        const keyword                      |                            
 *      |---|------------------|-------------------------------------------------------|-----------------------------------------------------------|
 *      | 1 |    Purpose       | readonly used to create a readonly fields             | const used to create constants fields                     |
 *      |   |                  |                                                       |                                                           |
 *      | 2 |      Type        | readonly is a constant defined at runtime             | const used to create a constant at compile time           |
 *      |   |                  |                                                       |                                                           |
 *      | 3 |     Change       | readonly field value can be changed after declaration | const field value cannot be changed after declaration     |
 *      |   |                  |                                                       |                                                           |
 *      | 4 |     Method       | readonly fields cannot be defined within a method     | const fields can be declared within a method              |
 *      |   |                  |                                                       |                                                           |
 *      | 5 | Value Assignment | readonly variables are declared as instance variable  | const fields are to be assigned at the time o declaration |
 *      |   |                  | and assigned values in constructor.                   |                                                           |
 *      |---|------------------|-------------------------------------------------------|-----------------------------------------------------------|
 *      
 */

namespace MyProject_98
{
    class MyClass
    {
        private const double PI = 3.14;

        public const string MY_ERROR = "some error";

        public readonly int _a; 

        public static readonly int _b;

        static MyClass()
        {
            _b = 3;
            Console.WriteLine(_b + " - Static constructor");
        }

        public MyClass(int a)
        {
            _a = a;
        }
        public void Foo()
        {
            Console.WriteLine(MY_ERROR);
        }
        public void Bar()
        {
            Console.WriteLine(_a);
            Console.WriteLine(_b);
        }
    }
    class Program
        {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(5);

            myClass.Foo();

            myClass.Bar();
        }
    }
}
