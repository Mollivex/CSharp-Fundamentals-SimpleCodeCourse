using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_101
{
    public class Student : Person
    {
        public string Group { get; set; }
        public int ID { get; set; }

        public void StudentInfo()
        {
            Console.WriteLine($"Group: {Group}\tID: {ID}");
        }
        public void Learn()
        {
            Console.WriteLine("I learn!");
        }
    }
}
