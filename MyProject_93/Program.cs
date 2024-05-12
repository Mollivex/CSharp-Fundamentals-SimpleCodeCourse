using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ==========================================
 * OOP | Static | Constructor | How to use #2
 * ==========================================
 *  
 *      Startic constructor is used to initialize static data members as soon as the class is referenced the first time, whereas an instance construtor is used
 *  to create an instance of that class with the <new> keyword. A static constructor doen't take access modifiers or have parameters and can't access any non-static
 *  data member of a class.
 *  
 *      Since static constructor is a class constructor, it's guaranteed to be called as soon as we refer to that class or by creating an instance of that class.
 * 
 *  -!- Rules: #| Static constructors can't contain any access modifiers.
 *  
 *             #| Static constructors can't be defined with arguments.
 *             
 *             #| Static constructors can't access the non-static data members.
 */

namespace MyProject_93
{
    class DbRepository
    {
        private static string connectionString;

        static DbRepository()
        {
            ConfigurationManager configurationManager = new ConfigurationManager();

            connectionString = configurationManager.GetConnectionString();
            
        }
        public void GetData()
        {
            Console.WriteLine("Using: " + connectionString); 
        }
    }
    class ConfigurationManager
    {
        public string GetConnectionString()
        {
            return "local DB";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DbRepository dbRepository = new DbRepository();
            dbRepisitory.GetData();
        }
    }
}
