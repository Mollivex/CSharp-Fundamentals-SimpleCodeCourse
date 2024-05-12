using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ===============================
 * OOP | Inheritance | is Operator
 * ===============================
 * 
 *      The 'is' operator checks if the result of an expression is compatible with a given type. 
 *      
 *      Also it's used to check whether the run-time type of an object is compatible with a given type or not.
 *  In other words, we use the 'is' operator to verify that the type of an object is what we expect it to be.
 * 
 *  -------------------------------------------------------
 *  Syntax of 'is' operator: | expressionName is dataType |
 *  -------------------------------------------------------
 * 
 *  |#| Example of the 'is' operator you may see below: |#|
 *  
 *      In the below example, we will be checking whether object obj is a class or not. If the argument passed
 *  is not a class then the application will jump to the message "obj is neither MyClass1 nor MyClass2"
 *  
 */

namespace MyProject_105
{
    public class MyClass1
    {
        public MyClass1()
        {
            Console.WriteLine("Constructor MyClass1 is called");
        }
    }
    public class MyClass2
    {
        public MyClass2()
        {
            Console.WriteLine("Constructor MyClass2 is called");
        }
    }
    public class IsOperatorTest
    {
        static void Main(string[] args)
        {
            MyClass1 myClass1 = new MyClass1();
            MyClass2 myClass2 = new MyClass2();

            Console.WriteLine();

            Test(myClass1);
            Test(myClass2);
            Test("Passing String Value instead of class");

            Console.ReadLine();
        }
        public IsOperatorTest()
        {
            Console.WriteLine("Constructor IsOperatorTest is called");
        }
        public static void Test(object obj)
        {
            MyClass1 a;
            MyClass2 b;

            if(obj is MyClass1)
            {
                Console.WriteLine("obj is MyClass1");
                a = (MyClass1)obj;
            }
            else if(obj is MyClass2)
            {
                Console.WriteLine("obj is MyClass2");
                b = (MyClass2)obj;
            }
            else
            {
                Console.WriteLine("obj is neither MyClass1 nor MyClass2");
            }
        }
    }
}
