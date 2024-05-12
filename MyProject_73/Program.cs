using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =====================================
 * #enum | DayOfWeek | GetUnderlyingType
 * =====================================
 * 
 * #NOTES: 1) For enums the default data type - int
 *         2) To change a data type for the enum it needed to put :dataType after enum declaration
 *         
 *         -!- Enum.GetUnderlyingType(Type) Method -!-
 *         
 *          Returns the underlying type of the specified enumeration.
 *          
 *                  public static Type GetUnderlyingType (Type enumType);
 *         
 *          The Enum structure enables values to be represented as named constants. The data type of the enumeration's values is known as its underlying type.
 *      For example, the underlying type of the DayOfWeek enumeration, which consists of constants that represent each day of the week (DayOfWeek.Monday, DayOfWeek.Tuesday, etc.), is Int32.
 */

namespace MyProject_73
{
    class DayOfWeekExample
    {
        enum DayOfWeek : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        /// <summary>
        /// Get next day
        /// </summary>
        /// <param name="day"></param>
        /// <returns></returns>
        static DayOfWeek GetNextDay(DayOfWeek day)
        {
            if (day < DayOfWeek.Sunday)
                return day + 1;

            return DayOfWeek.Monday;
        }

        static void Main(string[] args)
        {
            //DayOfWeek dayOfWeek = DayOfWeek.Monday;

            // enum type conversion
            DayOfWeek dayOfWeek;
            int value = 55;
            dayOfWeek = (DayOfWeek)value;

            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek))); // get enum data type

            Console.WriteLine(dayOfWeek);

            Console.WriteLine((int)dayOfWeek); // converting DayOfweek to int

            Console.WriteLine((DayOfWeek)3); // converting int to DayOfWeek

            DayOfWeek nextDay = GetNextDay(dayOfWeek);
            Console.WriteLine(nextDay);
        }
    }
}
