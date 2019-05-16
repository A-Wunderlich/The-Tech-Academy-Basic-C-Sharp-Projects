using System;

namespace AbstractInheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() {FirstName = "Sample",LastName = "Student" };
            employee.SayName();
            Employee employee1 = new Employee() { Id = 555 };
            Employee employee2 = new Employee() { Id = 555 };
            Console.WriteLine(employee1 == employee2);
            Console.ReadLine();


        }
    }
}
