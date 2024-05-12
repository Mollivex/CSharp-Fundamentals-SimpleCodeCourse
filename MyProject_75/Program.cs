using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * =======================================================
 * #enum | GetValues | Parse and TryParse | Switch feature
 * =======================================================
 * 
 *  -!- Enum.Parse Method -!-
 *      Converts the string representation of the name or numeric value of one or more enumerated constants to an equivalent enumerated object.
 * 
 *  -!- Switch Enum -!-
 *      In C# switch can act upon enum values. And enum switch sometimes results in clearer code. The resulting instructions are sometimes faster as well.
 *      Use switch on enum variables. Add cases with enum values, which are constants and ca be matched in switch.
 *      
 *      #How To Use Switch feature with enums : ( s -> double TAB -> copy enum variable name to switch)
 *      
 */

namespace MyProject_75
{
    class Program
    {
        enum Color
        {
            White,
            Red,
            Green,
            Yellow,
            Blue,
            Orange,
            Black
        }

        static void Main(string[] args)
        {
            // Get all values of the enum
            var values = Enum.GetValues(typeof(Color));
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            // Parse enum
            string str = Console.ReadLine();
            Color color = (Color)Enum.Parse(typeof(Color), str, ignoreCase: true);
            Enum.TryParse(str, out color);
            Console.WriteLine(color);

            // Switch feature with enums ( s -> double TAB -> copy enum variable name to switch)
            switch (color)
            {
                case Color.White:
                    break;

                case Color.Red:
                    break;

                case Color.Green:
                    break;

                case Color.Yellow:
                    break;

                case Color.Blue:
                    break;

                case Color.Orange:
                    break;

                case Color.Black:
                    break;

                default:
                    break;
            }
        }
    }
}
