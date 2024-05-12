﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * -------------------------
 * |sealed Keyword Modifier|
 * -------------------------
 * 
 *      When applied to a class, the \sealed modifier prevents other classes from inheriting from it. 
 *    
 *      In the following example, class B inherits from class A, but no class can inherit from class B:
 *    
 *                      class A {}
 *                      sealed class B : A {}
 *                      
 *      You can also use the \sealed modifier on a method or property that overrides a virtual method or property
 *   in a base class. This enables you to allow classes to derive from your class and prevent them from overriding
 *   specific virtual methods or propeties.
 * 
 */

namespace MyProject_96_Student
{
    sealed class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
