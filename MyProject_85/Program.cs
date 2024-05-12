using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
 * ===============================
 * OOP | this Keyword | What is it 
 * ===============================
 * 
 *      The \this keyword refers to the current instance of the class and is also used as a modifier of the first parameter of an extenstion method. It is also used to differentiate
 *  between the method parameters and class fields if they both have the same name.
 *      
 *      Another usage of \this keyword is to call another constructor from a constructor in the same class.
 *      
 *      Here, for an example, we are showing a record of Students i.e: ID, Name, Age and Subject.To refer to the fields of the current class, we have used the \this keyword in C#:
 *      
 *                          public Student (int id, string name, int age, string subject)
 *                          {
 *                              this.id = id;
 *                              this.name = name;
 *                              this.subject = subject;
 *                              this.age = age;
 *                          }
 *                          
 * -------------------------------------------------------------------------------------------    
 *  -!- Uses of \this keyword in C# -!-
 *  
 *      -!- To refer to the current class instance variable to easily distinguish the instance 
 *          variables or the field names and names of the parameters in case thay are the same.
 *      
 *      -!- To pass the current object as a parameter to another method.
 *      
 *      -!- For declaring indexers
 * -------------------------------------------------------------------------------------------  
 *      
 *      

 *          
 */

namespace MyProject_85
{
    class Student
    {
        public int age;
        public string id, name, subject;

        public Student(string id, string name, int age, string subject)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.subject = subject;
        }
        public void ShowInfo()
        {
            Console.WriteLine(id + "\t" + name + "\t" + age + "\t" + subject);
        }
    }
    class StudentDetails
    {
        static void Main(string[] args)
        {
            Student std1 = new Student("QWD39rf2", "Jack", 23, "Maths");
            Student std2 = new Student("48as1W2E", "Harry", 22, "Science");
            Student std3 = new Student("23fgQEW1", "Steve", 26, "Biology");
            Student std4 = new Student("3WWsWqQ2", "David", 27, "English");
            Student std5 = new Student("SF22geW3", "Alex", 25, "Programming");

            std1.ShowInfo();
            std2.ShowInfo();
            std3.ShowInfo();
            std4.ShowInfo();
            std5.ShowInfo();

            Console.WriteLine();
        }
    }
}
