using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            IQuittable employeeQuit = new Employee();
            employeeQuit.Quit();
            Console.ReadLine();


        }
    }
}
