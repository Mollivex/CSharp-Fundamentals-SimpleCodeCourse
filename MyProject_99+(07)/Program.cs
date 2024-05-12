using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ===============================
 * OOP | Inheritance | as Operator
 * ===============================
 * 
 *      The 'as' operator is used to perform conversions between compatible types. 
 *      
 *      Actually, the 'as' operator fulfills a similar role like 'is', but in a slightly truncated manner.
 *      
 *  -------------------------------------------------------
 *  Syntax of 'as' operator: | expressionName is dataType |
 *  -------------------------------------------------------
 *  
 *  |#| Example of the 'as' operator you may see below: |#|
 * 
 *      In the below example, each and every value is being cast to a string using the 'as' operator and 
 *  assigned to a string variable which is shown on the console.
 * 
 */

namespace MyProject_106
{
    class MyClass1
    {
        public MyClass1()
        {
            Console.WriteLine("MyClass1 constructor is called");
        }
    }
    class MyClass2
    {
        public MyClass2()
        {
            Console.WriteLine("MyClass2 constructor is called");
        }
    }
    class AsOperatorTest
    {
        static void Main(string[] args)
        {
            object[] myObjects = new object[6];
            myObjects[0] = new MyClass1();
            myObjects[1] = new MyClass2();
            myObjects[2] = "string";
            myObjects[3] = 24;
            myObjects[4] = null;

            Console.WriteLine();

            for (int i = 0; i < myObjects.Length; ++i)
            {
                string s = myObjects[i] as string;
                Console.Write("{0}: ", i);
                if (s != null)
                    Console.WriteLine($"'{s}'");
                else
                    Console.WriteLine("not a string");
            }

            Console.WriteLine();
        }
    }
}
