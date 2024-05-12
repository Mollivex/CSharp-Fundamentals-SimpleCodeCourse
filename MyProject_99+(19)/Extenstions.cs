using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_118
{
    public static class Extenstions
    {
        public static void Foo(this ILogger logger)
        {
            Console.WriteLine("Foo method!");
        }
    }
}
