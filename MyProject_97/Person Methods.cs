using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_97
{
    partial class Person
    {
        /// <summary>
        /// Get Person full name
        /// </summary>
        /// <returns></returns>
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        /// <summary>
        /// Print Person full name
        /// </summary>
        public void PrintFullName()
        {
            Console.WriteLine(GetFullName());
        }
    }
}
