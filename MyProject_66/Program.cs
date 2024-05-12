using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ================================================================
 * Casting and type conversion | Explicit and Implicit conversions.
 * ================================================================
 * 
 *  -?- What is a type casting -?-
 *  
 *      When a data type is converted into another data type by a programmer or user while writing a program code of any programming language, 
 *  the mechanism is known as type casting. The programmer manually uses it to convert one data type into another. It is used if we want to 
 *  change the target data type to another data type. Hence it also called a narrowing conversion.
 *  
 *                                  Destination Type(smaller) <--- Source Type(bigger)
 *  ======
 *  #NOTE: Remember that the destination data type must be smaller than the source data type!
 *  ======
 * 
 *  -?- What is a type conversion -?-
 * 
 *      If a data type is automatically converted into another data type at compile time is known as type conversion. The conversion is performed
 *  by the compiler if both data types are compatible with each other. It is also known as widening conversion of the data type.
 *  
 *                                  Destination Type(bigger) <--- Source Type(smaller)
 *  ======
 *  #NOTE: Remember that the destination data type shouldn't be smaller than the source type! 
 *  ======
 *  
 *  
 *  Syntax C#: Destination_dataType = (target_datatype) variable;
 *  
 *            - Destination_dataType it is known as cating operator.
 *            - (target_datatype) it is the data type in which we want to convert the destination data type.
 *  
 */

namespace MyProject_66
{
    class Program
    {
        static void Foo(double a)
        {
            Console.WriteLine(a + 0.35);
        }
        static void Main(string[] args)
        {
            // Explicit conversion (when the compiler cannot convert itself a larger value type to a smaller value type, and therefore the programmer helps with that)
            double a = 5.9;
            float b = (float)a;
            Console.WriteLine(b + 0.55);

            // Implicit conversion (when the compiler can convert data types  itself, automatically without any programmer's actions, it all happens in compiler)
            int a1 = 28;
            Foo(b);
            double c = a1;
            decimal d = a1;

            // boolean and string data types can be converted !ONLY! with #(dataType).Parse || #Convert.To(dataType)
            string text = "hello";
            int valueTest1 = int.Parse(text);
            int valueTest2 = Convert.ToInt32(text);

            bool statement1 = true;
            int valueTest3 = Convert.ToInt32(statement1);

            double valueTest4 = 5.2;
            bool statement2 = Convert.ToBoolean(valueTest4);
        }
    }
}
