using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_134
{
    /// <summary>
    ///     The following example declares a class that stores the days of the week. A 'get' accessor
    /// takes a string, the named of a day, and returns the corresponding integer. For example, "Sunday"
    /// retuns 0, "Monday" returns 1, and so on.
    /// </summary>
    public class DayCollection
    {
        string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };

        // Indexer with only a get accessor with the expression-bodied definition:
        public int this[string day] => FindDayIndex(day);

        private int FindDayIndex(string day)
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
                $"Day {day} isn't supported.\nDay input must be in the form \"Sun\", \"Mon\", etc.");
        }
    }
}
