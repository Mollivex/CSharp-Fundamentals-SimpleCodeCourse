using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_118
{
    // An existing class, maybe in a different code base with different owners, implements ILogger:
    public class ConsoleLogger : ILogger
    {
        void ILogger.Log(LogLevel logLevel, string message)
        {
            switch (logLevel)
            {
                case LogLevel.Debug:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    break;
                case LogLevel.Info:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    break;
                case LogLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();
                    break;
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    break;
                case LogLevel.FatalError:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    break;
            }
            Console.WriteLine($"{DateTime.Now}: {message}");
            Console.ResetColor();
        }
    }
}
