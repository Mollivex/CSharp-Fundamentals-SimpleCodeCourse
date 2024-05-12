using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =====================================================================================================================
 * #in parameter keyword | Mofidier #in and BENCHMARK test C# | Difference between #ref / #out / #in parameter keywords.
 * =====================================================================================================================
 * 
 *      Keywords #ref, #out and #in are parameter modifiers, that are passed to the method.
 *      
 *      The #in keyword in C# is used to specify that a method parameter is passed by reference, but the called method cannot modify the argument.
 *  This is useful for parameters that are not modified by the called method, but must be passed by reference in order for the calling method
 *  to access the results. 
 *  
 *      -!- It means, you can't change the value of an #in parameter, it's a readonly variable -!-
 * 
 *      The #in keyword is used in the following contexts:
 *          - generic type parameters in generic interfaces and delegates;
 *          - as a parameter modifier, which lets you pass an argument to a method by reference rather than by value;
 *          - foreach statements etc;
 *          
 *     The #in keyword causes arguments to be passed by reference but ensures the argument in not modified. It makes the formal parameter an alias
 *  for the argument, which must be a variable. In other words, any operation on the parameter is made on the argument.
 *  
 *     It's like the #ref or #out keywords, except that #in arguments cannot be modified by the called method. Whereas #ref arguments may be modified,
 *  #out arguments must be modified by the called method, and those modifications are observable in the calling context.
 *      
 *  #NOTE: The #in keyword can also be used with a generic type parameter to specify that the type parameter is contravariant, as part of a foreach
 *  statement, or as part of a join clause in a LINQ query.
 */

namespace MyProject_58
{
    class Program
    {
        struct MyStruct
        {
            public decimal a;
            public decimal b;
            public decimal c;
            public decimal d;
            public decimal e;
            public decimal f;
            // public decimal ...
            public decimal N_number;
        }
        static void Foo(MyStruct value)
        {
            // code block can be empty
        }
        static void Bar(in MyStruct value) 
        {
            // code block can be empty
        }
        static void Main(string[] args)
        {
            // Using #in parameter in method you can save a lot of memory resources to run the program.
            // There is a practical example of using #in parameter in the method you can see below.
            MyStruct a = new MyStruct();
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < int.MaxValue; i++)
            {
                Foo(a);
            }
            sw.Stop();
            Console.WriteLine($"Foo {sw.ElapsedMilliseconds}");

            sw.Restart();

            for (int i = 0; i < int.MaxValue; i++)
            {
                Bar(a);
            }
            sw.Stop();
            Console.WriteLine($"Bar {sw.ElapsedMilliseconds}");
        }
    }
}
