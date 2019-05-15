using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName,LastName);
        }
    }
}
