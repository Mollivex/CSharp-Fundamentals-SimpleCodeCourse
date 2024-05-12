using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  ===============================
 *  Enumeration types as bit flags:
 *  ===============================
 *      
 *      If you want an enumeration type to represent a combination of choices, define enum members for thos choices such that an individual choice is a bit field.
 *  That is, the associated values of those enum members should be the powers of two. Then, you can use the bitwise logical operators | or & to combine choices
 *  or intersect combinations of choices, respectively. To indicate that an enumeration type declares bit fields, apply the Flags attribute to it.
 * 
 */

namespace MyProject_71
{
    public enum Days
    {
        None      = 0b_0000_0000,  // 0
        Monday    = 0b_0000_0001,  // 1
        Tuesday   = 0b_0000_0010,  // 2
        Wednesday = 0b_0000_0100,  // 4
        Thursday  = 0b_0000_1000,  // 8
        Friday    = 0b_0001_0000,  // 16
        Saturday  = 0b_0010_0000,  // 32
        Sunday    = 0b_0100_0000,  // 64
        Weekend   = Saturday | Sunday
    }
    internal class FlagsEnumExample
    {
        static void Main()
        {
            // As the following example shows, you can also include some typical combinations in the definition of an enumeration type:

            Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
            Console.WriteLine(meetingDays); // output: Monday, Wednesday, Friday

            Days workingFromHome = Days.Thursday | Days.Friday;
            Console.WriteLine($"Join a meeting by phone on {meetingDays & workingFromHome}");
            // output: Join a meeting by phone on Friday

            bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
            Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");
            // output: Is there a meeting on Tuesday: False

            var a = (Days)37;
            Console.WriteLine(a); // output: Monday, Wednesday, Saturday
        }
    }
}
