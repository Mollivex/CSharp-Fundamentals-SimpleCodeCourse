using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
 * ==============================================================
 * Exception Handling in C# | Use exceptions | Try...Catch blocks
 * ==============================================================
 * 
 *      https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/using-exceptions
 *      https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/creating-and-throwing-exceptions
 * 
 *      In C#, error in the program at run time are propagated through the program by using mechanism called exceptions. Exceptions are thrown by code that encounters an error
 *  and caught by code that can correct the error. Exceptions can be thrown by the .NET runtime or by code in a program. Once an exception is thrown, it propagates up the call stack
 *  until a 'catch' statement for the exception is found. Uncaught exceptions are handled by a generic exception handler provided by the system that displays a dialog box.
 * 
 *      Exceptions are represented by classes derived from Exception. This class identifies the type of exception and contains properties that have details about the exception. 
 *  Throwing an exception involves creating an instance of an exception-derived class, optionally configuring properties of the exception, and then throwing the object by using
 *  the 'throw' keyword.
 * 
 */

namespace MyProject_145
{
    class CustomException : Exception
    {
        public CustomException(string message)
        {

        }
        private static void TestThrow()
        {
            throw new CustomException("Custom exception in TestThrow()");
        }
    }
    public class CatchOrder
    {
        public static void Main(string[] args)
        {
            try
            {
                using (var sw = new StreamWriter("./test.txt"))
                {
                    sw.WriteLine("Hello!");
                }
            }
            // Put the more specific exceptions first.
            catch(DirectoryNotFoundException exception)
            {
                Console.WriteLine(exception);
            }
            catch(FileNotFoundException exception)
            {
                Console.WriteLine(exception);
            }
            //Put the least specific exception last
            catch(IOException exception)
            {
                Console.WriteLine(exception);
            }
            Console.WriteLine("Done");
        }
        static void TestFinally()
        {
            FileStream? file = null;
            // Change the path to something that works on your machine
            FileInfo fileInfo = new System.IO.FileInfo("./file.txt");

            try
            {
                file = fileInfo.OpenWrite();
                file.WriteByte(0xF);
            }
            finally
            {
                // Closing the file allows you to reopen it immediately - otherwise IOException is thrown.
                file?.Close();
            }

            try
            {
                file = fileInfo.OpenWrite();
                Console.WriteLine("OpenWrite() succeeded");
            }
            catch(IOException)
            {
                Console.WriteLine("OpenWrite() failed");
            }
        }
    }
    /*
     *      If WriteByte() threw an exception, the code in the second try block that tries to reopen the file would fail if file.Close() isn't called, 
     *  and the file would remain locked. Because 'finally' blocks are executed even if an exception is thrown, the 'finally' block in the previous example 
     *  allows for the file to be closed correctly and helps avoid an error.
     */
}
