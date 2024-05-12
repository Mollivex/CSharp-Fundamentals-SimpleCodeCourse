using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  ===============================================================================
 *  #METHODS. Area of visibility | Variable context | Area of visibility conflicts.
 *  ===============================================================================
 *  
 *  #Scope:
 *  
 *    - This concept defines the part of the application where the variable is accessible, called the scope of a variable. Variables can be defined in classes, methods, loops, and structs.
 *
 *    - There are three main scopes for a variable:
 *
 *          - Class level
 *          - Method level
 *          - Block level (Nested scope)
 * 
 *  #Visibility
 *  
 *    - When we talk about visibility, we need to consider class, method, and variable constructs. Visibility tells us how these items can be accessed.
 *
 *    - There are five types of visibility:
 *
 *            - Public
 *               This is the most forgiving visibility type. The member defined this way can be reached from anywhere, by default enums and interfaces are public.
 *            
 *            - Protected
 *                Members specified this way can only be reached from the same class, or from within the class.
 *            
 *            - Internal
 *                Members specified this way can only be reached from the same project.
 *              
 *            - Protected internal
 *                Members specified this way can only be reached from the same project, and those classes that inherit from the class, even from another project.
 *              
 *            - Private
 *                Members specified this way can only be reached by other members of the same class. By default, classes and structs are set to this visibility level, and this is the most restrictive.
 *  
 *  !VVV! Let's create a small demonstration code. !VVV!
 *  
 */

namespace MyProject_48
{
    public class AnotherVisibility
    {
        public string message = "I am visible from anywhere!";

        protected string pmessage = "Only from the same class!";

        internal string imessage = "I am visible only from within the same project!";

        private string ppmessage = "Untouchable!";
        public void ProtectedMessage()
        {
            Console.WriteLine(pmessage);
            Console.WriteLine(ppmessage);
        }
    }
    public class Visibility : AnotherVisibility
    {
        public static void Main()
        {
            Visibility a = new Visibility();
            AnotherVisibility b = new AnotherVisibility();

            Console.WriteLine(a.message);
            Console.WriteLine(a.imessage);
            Console.WriteLine(a.pmessage);

            b.ProtectedMessage();

            Console.ReadKey();
        }
        /*
         *  #Here we can see the concepts in action:
         *      
         *      - Our 'message' variable, since it is public, is accessible from anywhere. 
         *      
         *      - We have our 'pmessage' variable, which is accessible from the same or inherited classes. 
         *      
         *      - We have the 'imessage' variable, which is accessible from the same or inherited classes. 
         *      
         *      - We also have the 'ppmessage' variable, which is only accessible from the original class.
         * 
         */
    }
}
