using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  ============================================================
 *  #METHODS | Value and Reference types in C# | STACK AND HEAP.
 *  ============================================================
 *  
 *      In C#, these data types are categorized based on how they store their value in the memory.
 *  
 *      Value types and Reference types are the two main categories of C# types. A variable of a value type contains an instance of the type. This differs from a variable
 *  of a reference type, which contains a reference to an instance of the type. By default, on assignment, passing an argument to a method, and returning a method result, 
 *  variable values are copied. In the case of value-type variables, the corresponding type instances are copied.
 *          
 * ==========================================================================================================================================================================
 * #Value Type (STACK): A data type is a value type if it stores a data value within its own memory space. It means the variables of these data types directly contain values.
 * ==========================================================================================================================================================================
 * 
 *      A value type can be one of the two following kids: 
 *          - a structure type, which encapsulates data and related functionality;
 *          - an enumeration type, which is defined by a set of named constants and represents a choice or a combination of choices;
 *  
 *  #For example, consider integer variable int i = 100; The system stores 100 in the memory space allocated for the variable i.
 *  
 *      The following data types are all of value type: bool, byte, char, decimal, double, enum, float, int, long, sbyte, short, struct, uint, ulong, ushort.
 *  
 *  #NOTE: All the value types derive from System.ValueType, which in-turn, derives from System.Object.
 *  
 *  #NOTE: A value type variable cannot be null because it holds value, not a memory address. C# 2.0 introduced nullable types, using which you can assign null to a value
 *         type variable without assigning a value to it.
 *         
 *      As it known, a value type cannot be assigned a null value. For example, int i = null wull give you a compile 
 *  time error.
 *      
 *      C# 2.0 intoduced nullable types that allow you to assign null to value type variables. You can declare nullable
 *  types using Nullable<T> where T is a type.
 *  
 *      #For example, Nullable<int> i = null;
 *  
 * ===============================================================================================================================================================
 *  #Reference Type (HEAP): Unlike value types, a reference type doesn't store its value directly. Instead, it stores the address where the value is being stored.
 *                   In other words, a reference type contains a pointer to another memory location that holds the data.
 * ===============================================================================================================================================================
 *  
 *  #For example, consider the following string variable:
 *  
 *      string s = "Hello, world!";
 *  
 *      The system selects a random location in memory (*randomAddress 0x803200*) for the variable s. The value of a variable s is (*for example 0x60000*), which
 *  is the memory address of the actual data value. Thus, refence type stores the address of the location where the actual value is stored instead of the value itself.
 *  
 *      String is a reference type, but it is immutable. It means once we assigned a value, it cannot be changed. If we change a string value, then the compiler creates
 *  a new string object in the memory and point a variable to the new memory location. So, passing a string value to a function will create a new variable in the memory,
 *  and any change in the value in the function will not be reflected in the original value, as shown below.
 *  
 *      The followings are reference type data types: String, Arrays (even if their elements are value types), Class, Delegate.
 *  
 *  #NOTE: The default value of a reference type variable is null when they are not initialized. Null means not refering to any object.
 *  
 */

namespace MyProject_49
{
    public class Student
    {
        /// <summary>
        /// Example: Passing Value Type Variables
        /// </summary>
        /// <param name="x"></param>
        static void ChangeValue(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }

        private string StudentName;
        
        /// <summary>
        /// Example: Passing Reference Type Variables
        /// </summary>
        /// <param name="std2"></param>
        static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Steve";
        }

        /// <summary>
        /// Example: Passing string
        /// </summary>
        /// <param name="name"></param>
        static void ChangeReferenceType(string name)
        {
            name = "Steve";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=============================================");
            /*
             * #Passing Value Type Variables:
             *      When you pass a value-type variable from one method to another, the system creates a separate copy of a variable in another method.
             *  If value got changed in the one method, it wouldn't affect the variable in another method.
             */

            //Example: Passing Value Type Variables
            Console.WriteLine("=============================================");

            int i = 100;
            Console.WriteLine(i);
            ChangeValue(i);                                      //EXAMPLE #1
            Console.WriteLine(i);

            /* 
             *  In the above example, variable i in the Main() method remains unchanged even after we pass it to the ChangeValue() method and change it's value there.
             */
            Console.WriteLine("=============================================");

            /*
             * #Passing Reference Type Variables:
             *      When you pass a reference type variable from one method to another, it doesn't create a new copy; instead, it passes the variable's address. So, if we change the
             * value of a variable in a method, it will also be reflected in the calling method.
             */

            //Example: Passing Reference Type Variables
            Console.WriteLine("=============================================");

            Student std1 = new Student();
            std1.StudentName = "Bill";                          //EXAMPLE #2
            ChangeReferenceType(std1);
            Console.WriteLine("\n" + std1.StudentName);

            /*
             *  In the above example, we pass the Student(#it needs to create class firstly#) object std1 to the ChangeReferenceType() method. Here, it actually pass the memory address of std1.
             *  Thus, when the ChangeReferenceType() method changes StudentName(#it needs to create method firstly#), it is actually changing StudentName of std1 object, because std1 and std2 
             *  are both pointing to the same address memory.
             */

            // Example: Passing string
            Console.WriteLine("\n=============================================");

            string name = "Bill";
            ChangeReferenceType(name);                            //EXAMPLE #3
            Console.WriteLine(name);

            Console.WriteLine("=============================================");
        }
    }
}
