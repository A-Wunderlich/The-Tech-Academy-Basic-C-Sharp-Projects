using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures
{
    class Employee
    {
        public Employee(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public Employee(string name) : this(name,400)
        {
        }


        public int Id { get; set; }
        public string Name { get; set; }
    }
}
