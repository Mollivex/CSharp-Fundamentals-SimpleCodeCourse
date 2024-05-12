using System;

/*
 * =========================================================
 * OOP | Interfaces in C# | Default implementation in C# 8.0
 * =========================================================
 * 
 *      A big impediment to software evolution has been the fact that you couldn't add new members to a public interface.
 *  You would break existing implementers of the interface; after all they would have no implementation for the new member!
 *  
 *      Default implementations help with that. An interface member can now be specified with a code body, and if an implementing
 *  class or struct doen't provide an implementation of that member, no error occurs. Instead, the default implementation is used.
 * 
 *      Of course an implementing class that does know about the new member is free to implement it in its own way. In that case,
 *  the default implementation is just ignored.
 * 
 */

namespace MyProject_118
{
    public class Program
    {
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();
            consoleLogger.Foo();

            Console.WriteLine("===================================================");

            consoleLogger.Log(LogLevel.Debug, "some event");
            consoleLogger.Log(LogLevel.Warning, "some warning");
            consoleLogger.Log(LogLevel.Error, "some error");
            consoleLogger.Log(LogLevel.FatalError, "some fatal error");

            Console.WriteLine("===================================================");

            consoleLogger.LogError("some error!");
        }
    }
}
