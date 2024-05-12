using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day = System.DayOfWeek;

namespace MyProject_134
{
    /// <summary>
    ///     The following example declares a class that stores the days of the week using the System.DayOfWeek enum. A 'get' accessor
    /// takes a DayOfWeek, the value of a day and returns the corresponding integer. For example, DayOfWeek.Sunday returns 0, 
    /// DayOfWeek.Monday returns 1, and so on.
    /// </summary>
    public class DayOfWeekCollection
    {
        Day[] days =
        {
            Day.Sunday, Day.Monday, Day.Tuesday, Day.Wednesday,
            Day.Thursday, Day.Friday, Day.Saturday
        };

        // Indexer with only a get accessor with the expression-bodied definition:
        public int this[Day day] => FindDayIndex(day);

        private int FindDayIndex(Day day)
        {
            for (int i = 0; i < days.Length; i++)
            {
                if (days[i] == day)
                {
                    return i;
                }
            }

            throw new ArgumentOutOfRangeException(
                nameof(day),
                $"Day {day} is not supported.\nDay input must be a defined System.DayOfWeek value.");
        }
    }
}
