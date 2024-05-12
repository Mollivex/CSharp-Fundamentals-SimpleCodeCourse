using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Globalization;

/*
 * ============================================
 * OOP | Constructors | Constructor Overloading
 * ============================================
 * 
 *      In C#, similar to method overloading, we can also overload constructors. 
 *      
 *      Constructor overloading is a technique to define multiple constructors within a class with different sets of parameters to achive polyrphism.
 *      
 *      We can overload constructors in C# just like methods. We can do so by changing the signatures by using a different number, or type of parameters.
 *      
 *      Given that we have more than one type of parameter in the constructor, we can also change their order and achieve constructor overloading.
 *      
 *      #For constructor overloading, there must be two or more constructors with the same name but different:
 *                  - number of parameters;
 *                  - types of parameters;
 *                  - order of parameters;
 *                  
 *  -!- NOTE:   -ctor  | snippet for creating constructor syntax C#                 
 *                  
 */

namespace MyProject_84
{
    class Student
    {
        /// <summary>
        /// Student Last Name and Birthday
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="birthday"></param>
        public Student(string lastName, DateTime birthday)
        {
            _lastName = lastName;
            _birthday = birthday;
        }
        /// <summary>
        /// Student Last Name, First Name, Middle Name and Birthday
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firtName"></param>
        /// <param name="middleName"></param>
        /// <param name="birthday"></param>
        public Student(string lastName, string firtName, string middleName, DateTime birthday)
        {
            _lastName = lastName;
            _firstName = firtName;
            _middleName = middleName;
            _birthday = birthday;
        }
        /// <summary>
        /// If we need to create another class object and set different data
        /// </summary>
        /// <param name="student"></param>
        public Student(Student student)
        {
            _firstName = student._firstName;
            _lastName = student._lastName;
            _middleName = student._middleName;
            _birthday = student._birthday;
        }

        /// <summary>
        /// Set Student Last Name
        /// </summary>
        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }

        private string _firstName;
        private string _middleName;
        private string _lastName;
        private DateTime _birthday;

        /// <summary>
        /// Print student First Name, Last Name, Middle Name and Birthday
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"First Name: {_firstName}\nLast Name: {_lastName}\nMiddle Name: {_middleName}\nBirthday: {_birthday.ToString("MM.dd.yyyy")} year");
        }

        static void Main(string[] args)
        {
            Student student_1 = new Student("John", "Smith", "Paul", new DateTime(2000, 10, 5));

            // We have create another object with own memory space in heap
            Student student_2 = new Student(student_1);

            // We changed LastName for first object, but not for second
            student_1.SetLastName("#######");

            student_1.Print();

            Console.WriteLine();

            student_2.Print();
        }
    }
}
