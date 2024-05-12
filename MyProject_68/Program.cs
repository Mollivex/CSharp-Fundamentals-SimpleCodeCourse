using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  =====================
 *  Nullable value types.
 *  =====================
 *  
 *      A nullable value type T? represents all values of its underlying value type T and an additional null value.
 * 
 *      #For example, you can assign any of the following three values to a #bool? variable: true, false, or null. 
 *                    An underlying value type T cannot be a nullable value type itself.
 *                    
 *      Any nullable value type is an instance of the generic System.Nullable<T> structure. You can refer to a nullable
 *  value type with an underlying type T in any of the following interchangeable forms: Nullable<T> or T?
 *  
 *      You typically use a nullable value type when you need to represent the undefined value of an underlying
 *  value type. 
 *  
 *      #For example, a Boolean, or bool, variable can only be either true or false. However, in some
 *  applications a variable value can be undefined or mising. 
 *  
 *      #For example, a database field may contain true or
 *  false, or it may contain no value at all, that is, NULL. You can use the bool? type in that scenario.
 *  
 *  ===================================
 *  #Characteristics of Nullable Types:
 *  ===================================
 *  
 *  - Nullable types can only be used with value types.
 *  
 *  - The Value property will throw an #InvalidOperationException if value is null; otherwise it will return the value.
 *  
 *  - The HasValue property returns true if the variable contains a value, or false if it is null.
 *  
 *  - You can only use == and != operators with a nullable types. For other comparison use the Nullable static class.
 *  
 *  - Nested nullable types are not allowed. Nullable <Nullable<int> > i; will give a compile time error.
 *  
 *  - Nullable <T> type allows assigment of null to value types.
 *  
 *  - ? operator is a shorthand syntax for Nullable types.
 *  
 *  - Use value property to get the value of nullable type.
 *  
 *  - Use HasValue property to chech whether value is assigned to nullable type or not.
 *  
 *  - Static Nullable class is a helper class to compare nullable types.
 *  
 * -------
 *  #NOTE: To change a value type to the nullable type you need to add ? symbol to the name of dataType: int value = null; ---> int? value = null;
 * -------
 * 
 */

namespace MyProject_68
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Examination of an instance of a nullable value type
            int? a = null;
            if (a is int valueOfA)
                Console.WriteLine($"a is {valueOfA}");
            else
                Console.WriteLine("a doesn't have a value");

            // Nulllable (i = 0)

            int? i = null;

            Console.WriteLine(i == null); // output: True

            // HasValue it's like a value-checker, indicate if variable has any value or it's null (return True/False) 
            Console.WriteLine(i.HasValue); // output: False

            Console.WriteLine(i.GetValueOrDefault()); // output: 0 (data type default value)

            Console.WriteLine(i.GetValueOrDefault(5)); // output: 5

            // The most common form of use for GetValueOrDefault(n)
            Console.WriteLine(i ?? 55); // output: 55

            Console.WriteLine(i.Value); // output: InvalidOperationException

            // Nulllable (j = 2)

            int? j = 2;
            Console.WriteLine(i == null); // output: False
            Console.WriteLine(i.HasValue); // output: True
            Console.WriteLine(i.GetValueOrDefault()); // output: 2
            Console.WriteLine(i.GetValueOrDefault(5)); // output: 2
            Console.WriteLine(i ?? 55); // output: 2
            Console.WriteLine(i.Value); // output: 2

            // Example with struct System.DataTime
            Nullable<DateTime> dateTime1 = DateTime.Now;
            DateTime? dateTime2 = null;
            Console.WriteLine(dateTime1);

            // Comparison operations
            int x = 5;
            int? y = 22;
            int? result = x + y;

            Console.WriteLine(result); // 27
            Console.WriteLine(x == y); // False
            Console.WriteLine(x > y); // False
            Console.WriteLine(x < y); // True
        }
    }
}
