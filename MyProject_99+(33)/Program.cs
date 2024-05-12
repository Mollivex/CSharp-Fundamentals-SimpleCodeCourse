using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

/*
 * =================================================
 * Reflection in C# | Application | Viewing Metadata
 * =================================================
 * 
 *      https://www.tutorialspoint.com/csharp/csharp_reflection.html
 *      https://www.programiz.com/csharp-programming/reflection
 *      https://learn.microsoft.com/en-us/dotnet/framework/reflection-and-codedom/reflection
 *      
 *      Reflection objects are used for obtaining type information at runtime. The classes that give access to the metadata
 *  of a running program are in the System.Reflection namespace.
 *  
 *      The System.Reflection namespace conatins classes that allow you to obtain information about the application and to
 *  dynamically add types, values, and objects to the application.
 *  
 * ---------------------------
 * Applications of Reflection:      #| It allows view attribute information at runtime.
 * ---------------------------      #| It allows examing various types in an assembly and instantiate these types.
 *                                  #| It allows late binding to methods and properties.
 *                                  #| It allows creating new types at runtime and then performs some tasks using those types.
 * 
 * -----------------
 * Viewing Metadata:   The MemberInfo object of the System.Reflection class need to be initialized for discovering the attributes associated with a class. To do this, you
 * -----------------   define an object of the target class, as: 
 *                                                                  
 *                                                  System.Reflection.MemberInfo info = typeof(MyClass);
 * 
 */

[AttributeUsage(AttributeTargets.All)]
public class HelpAttribute : System.Attribute
{
    public readonly string URL;

    public string Topic // Topic is a named parameter
    {
        get { return topic; }
        set { topic = value; }
    }

    public HelpAttribute(string url) // url is a positional parameter
    {
        this.URL = url;
    }

    private string topic;
}

[HelpAttribute("Information on the class MyClass")]
class MyClass { }

namespace MyProject_132
{
    class Program
    {
        static void Main(string[] args)
        {
            MemberInfo info = typeof(MyClass);
            object[] attributes = info.GetCustomAttributes(true);

           for (int i = 0; i < attributes.Length; i++)
            {
                Console.WriteLine(attributes[i]);
            }
            Console.ReadLine();
        }
    }
}
