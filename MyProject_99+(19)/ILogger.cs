using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_118
{
    // Let's say that we offer the following interface:
    public interface ILogger
    {
        // Now we want to add another overload of the Log method to the interface. We can do that without
        // breaking the existing implementation by providing a default implementation - a method body:
        void Log(LogLevel logLevel, string message);
        void Foo()
        {
            Console.WriteLine("Foo Method Test!");
        }
        void LogError(string message)
        {
            Log(LogLevel.Error, message);
        }
    }
}
