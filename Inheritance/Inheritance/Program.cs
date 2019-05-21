using System;
using System.Collections.Generic;
using System.Linq;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            List<Employee> joeList = new List<Employee>();
            Employee employee1 = new Employee() { FirstName = "John", LastName = "Jones", Id = 1 };
            list.Add(employee1);
            Employee employee2 = new Employee() { FirstName = "Joe", LastName = "Shmoe", Id = 2 };
            list.Add(employee2);
            Employee employee3 = new Employee() { FirstName = "Jack", LastName = "Johnson", Id = 3 };
            list.Add(employee3);
            Employee employee4 = new Employee() { FirstName = "Tom", LastName = "Smith", Id = 4 };
            list.Add(employee4);
            Employee employee5 = new Employee() { FirstName = "Scott", LastName = "Barnes", Id = 5 };
            list.Add(employee5);
            Employee employee6 = new Employee() { FirstName = "Zack", LastName = "Dyment", Id = 6 };
            list.Add(employee6);
            Employee employee7 = new Employee() { FirstName = "John", LastName = "Jones", Id = 7 };
            list.Add(employee7);
            Employee employee8 = new Employee() { FirstName = "Joe", LastName = "Thompson", Id = 8 };
            list.Add(employee8);
            Employee employee9 = new Employee() { FirstName = "Jill", LastName = "Johnson", Id = 9 };
            list.Add(employee9);
            Employee employee10 = new Employee() { FirstName = "Sara", LastName = "Cage", Id = 10 };
            list.Add(employee10);
            employee4.SayName();

            // this is the part with the lists made with a foreach loop and lambda expressions
            foreach (Employee employee in list)
            {
                if (employee.FirstName == "Joe")
                {
                    joeList.Add(employee);
                }
            }
            List<Employee> newJoeList = list.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> greaterId = list.Where(y => y.Id > 5).ToList();

            Console.ReadLine();
        }
    }
}
