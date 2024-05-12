using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ====================================
 * OOP | Static | Class | Static Members
 * ====================================
 * 
 *      There are two types of C# static class members, static and non-static.
 *  
 *  ----------------------
 *  #|Non-static members|#
 *  ----------------------
 *  
 *      This is the default type for all members. If you don't use the "static" keyword to declare a field/property or a method, then it can be called
 *  a "Non-static member". The main feature of a non-static member is it will be bound to the object only.
 *  
 *  -!- Non-static Fields/Properties -!- 
 *  The memory is allocated when the object is created.
 *  
 *  -!- Non-static Methods -!- 
 *  These methods can implement operations on non-static fields and properties.
 *  
 *  ------------------
 *  #|Static Members|#
 *  ------------------
 *  
 *      If you use the "static" keyword for the declaration of a field/property or a method, it is called a "Static Member". The main feature of a non-static
 *  is that it will not be bound to any object. Instead, it's individually accessible with the class name. In other words, the static members are accessible
 *  directly without creating one object/
 *  
 *  -!- Static Fields/Properties -!-
 *  The memory will be allocated individually , without any relation to the object.
 *  
 *  -!- Static Methods -!- 
 *  These methods can only implement operations on static fields and properties and can't access non-static members.
 * 
 * --------------------------------------------------------------------------------------------------
 * EXAMPLE: The following code shows the difference between static and non-static members of a class.
 *          The Student class has non-static members, and their values are set by the program.
 * --------------------------------------------------------------------------------------------------
 * 
 */

namespace MyProject_95
{
    class Student
    {
        // non-static data members(fields)
        public string StudentName;
        public string Course;

        /// <summary>
        /// Set student details - student name, course name
        /// </summary>
        /// <param name="studentName"></param>
        /// <param name="courseName"></param>
        public void SetStudentDetails(string studentName, string courseName)
        {
            StudentName = studentName; 
            Course = courseName;
        }
        /// <summary>
        /// Display student details, like Student Name - Course Name
        /// </summary>
        public void DisplayStudentDetails()
        {
            Console.WriteLine($"{StudentName} - {Course}");
        }

        // static data members(fields)
        public static string CollegeName = "ABC College of Technology";
        public static string CollegeAddress = "Hyderbad";

        // static methods
        public static void DisplayCollegeDetails()
        {
            Console.WriteLine(CollegeName);
            Console.WriteLine(CollegeAddress);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // access static members
            Student.DisplayCollegeDetails();

            Console.WriteLine();

            // non-static members
            Student student1 = new Student();
            Student student2 = new Student();

            student1.SetStudentDetails("Sarath", "MCA");
            student2.SetStudentDetails("Syam", "MBA");

            student1.DisplayStudentDetails();
            student2.DisplayStudentDetails();

            Console.ReadLine();
        }
    }
}
