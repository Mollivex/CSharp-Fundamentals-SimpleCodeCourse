using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ==========================
 * NULL reference type in C#.
 * ==========================
 * 
 *      The null keyword is a literal that represents a null reference, one that does not refer to any object.
 *  Null is the default value of reference type variables. Ordinary value types cannot be null, except for nullable value types.
 *  
 *      In a nullable oblivious context, all reference types were nullable. Nullable reference types refers to a group of
 *  features enabled in a nullable aware context that minimize the likelihood that your code causes the runtime to throw
 *  #System.NullReferenceException. 
 *  
 *      Nullable reference types includes three features that help you avoid these exceptions,
 *  including the ability to explicitly mark a reference type as nullable:
 *      
 *      - Improved static flow analysis that determines if a variable may be null before dereferencing it.
 *      
 *      - Attributes that annotate APIs so that the flow analysis determines null-state.
 *      
 *      - Variable annotations that developers use to explicitly declare the intended null-state for a variable.
 *  
 */

namespace MyProject_50
{
    class MyClass
    {

    }

    struct MyStruct
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Value types default values examples:
            bool b; // #ValueType. Default value - false;

            int a; // #ValueType. Default value - 0;

            double c; // #ValueType. Default value - 0;

            // Class types (Reference types) default values example:
            Random random; // #ReferenceType. Default value = null;

            int[] myArray; // #ReferenceType. Default value = null;

            MyClass myClass; // #ReferenceType. Default value = null;

            MyStruct myStuct; // #ReferenceType. Default value = {namespaceName.MyStruct};
        }
    }
}
