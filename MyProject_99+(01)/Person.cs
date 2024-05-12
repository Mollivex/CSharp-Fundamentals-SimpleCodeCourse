using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_100
{
    public class Person
    {
        public Person()
        {
            
        }
        public Person(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Id { get; set; }

        public Address Address { get; set; }
    }
}
