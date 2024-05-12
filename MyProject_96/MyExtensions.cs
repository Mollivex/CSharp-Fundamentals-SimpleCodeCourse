using MyProject_96;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject_96_Student;

namespace MyProject_96_MyExtensions
{
    static class MyExtensions
    {
        public static void Print(this DateTime dateTime)
        {
            Console.WriteLine(dateTime);
        }
        public static bool IsDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            return dateTime.DayOfWeek == dayOfWeek;
        }

        public static string GetFullName(this Student student)
        {
            return student.LastName + " " + student.FirstName;
        }
    }
}
