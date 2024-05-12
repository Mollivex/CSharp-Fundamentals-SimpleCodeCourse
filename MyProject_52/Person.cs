using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_52
{
    public class Person
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string LastName { get; set; }

        public Contacts Contacts { get; set; }

        public string GetFullName()
        {
            return $"FirstName: {FirstName ?? "Doesn't exist"} | Surname: {Surname ?? "Doesn't exist"} | LastName: {LastName ?? "Doesn't exist"} ";
        }
        public string GetPhoneNumber()
        {
            return $"Phone Number: {Contacts?.PhoneNumber ?? "Doesnt't exist"} ";
        }
    }
}
