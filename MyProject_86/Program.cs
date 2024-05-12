using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ==========================
 * OOP | this in Constructors
 * ==========================
 * 
 *  #NOTE: Static members functions, because they exist at the class level and not as part of an object, don't have a \this pointer. It's an error to refer to \this in a static method!
 *      
 * -----------------
 * Important Points:
 * -----------------
 * 
 *      -!- When you use \this keyword to call a constructor, the constructor should belong to the same class.
 *      
 *      -!- You can also pass parameter in \this keyword.
 *      
 *      -!- this keyword always pointing to the members of the same class in which it's used.
 *      
 *      -!- When you use \this keyword, it tells the compiler to invoke the default constructor. 
 *          Or in other words, it means a constructor that doesn't contain arguments.
 *          
 * -------------------------------------------------------------------------------------------------------------------------
 *  #NOTE: We can delegate the same parameters between the constructors inside the class.
 *          If constructors have the same fields, it can be delegate between those constructors with help of \this keyword
 *          
 *                          classModifier ClassName (parameters) : this(fields you want to delegate)
 * -------------------------------------------------------------------------------------------------------------------------
 */

namespace MyProject_86
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
            this.lastName = lastName;
            this.birthday = birthday;
        }
        /// <summary>
        /// Student Last Name, First Name, Middle Name and Birthday
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firtName"></param>
        /// <param name="middleName"></param>
        /// <param name="birthday"></param>
        public Student(string lastName, string firstName, string middleName, DateTime birthday) : this(lastName,birthday) // We can delegate a same parameters between the constructors inside the class
        {
            this.firstName = firstName;
            this.middleName = middleName;
        }
        /// <summary>
        /// If we need to create another class object and set different data
        /// </summary>
        /// <param name="student"></param>
        public Student(Student student)
        {
            firstName = student.firstName;
            lastName = student.lastName;
            middleName = student.middleName;
            birthday = student.birthday;
        }

        /// <summary>
        /// Set Student Last Name
        /// </summary>
        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        private string firstName;
        private string middleName;
        private string lastName;
        private DateTime birthday;

        /// <summary>
        /// Print student First Name, Last Name, Middle Name and Birthday
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"First Name: {firstName}\nLast Name: {lastName}\nMiddle Name: {middleName}\nBirthday: {birthday.ToString("MM.dd.yyyy")} year\n");
        }
    }
    class Program
{
        static void Main(string[] args)
        {
            Student student1 = new Student("Smith", new DateTime(2000, 10, 5));
            Student student2 = new Student("Conor",new DateTime(2000, 10, 5));
            Student student3 = new Student("Alexander", "Cocier", "Olegovich", new DateTime(1997, 2, 9));

            student1.Print();
            student2.Print();
            student3.Print();
        }
    }
}
