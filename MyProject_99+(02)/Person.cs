using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_101
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"My name is {FirstName}");
        }
    }
}
