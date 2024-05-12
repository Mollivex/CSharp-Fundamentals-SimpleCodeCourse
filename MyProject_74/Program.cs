using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ====================
 * #enum | Conversions:
 * ====================
 *  
 *      For any enumeration type, there exist explicit conversions between the enumeration type and its underlying intergral type. If you cast an enum value to its underlying
 *  type, the result is the associated integral value of an enum member.
 *  
 *      Use the Enum.IsDefined method to determine whether an enumeration type contains an enum member with the certain associated value.
 *      
 *      For any enumeration type, there exist boxing and unboxing conversions to an from the Sytem.Enum type, respectively.
 */

namespace MyProject_74
{
    class Program
    {
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            DayOfWeek dayOfWeek;

            int value = 5;

            dayOfWeek = (DayOfWeek)value;

            if (Enum.IsDefined(typeof(DayOfWeek),value))
            {
                dayOfWeek = (DayOfWeek)value; // converting int to DayOfWeek
            }
            else
            {
                throw new Exception("Invalid DayOfWeek value!");
            }

            Console.WriteLine(dayOfWeek);
        }
    }
}
