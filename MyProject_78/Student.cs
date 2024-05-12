using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_78
{
    class Student
    {
        // Class fields
        public Guid id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;

        public void Print()
        {
            Console.WriteLine("Information about the student:");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Middle Name: {middleName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Group: {group}");
        }

        public string GetFullName()
        {
            return $"{lastName} {firstName} {middleName}";
        }
    }
}
