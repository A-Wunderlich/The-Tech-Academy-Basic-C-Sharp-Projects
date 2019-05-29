using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandeling2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;

            int year = DateTime.Today.Year;
            bool validAnswer = false;
            while (!validAnswer)
            {
                Console.WriteLine("How old are you?");
                validAnswer = int.TryParse(Console.ReadLine(), out age);
                if (!validAnswer) Console.WriteLine("Please enter whole intigers only.");
            }
            try
            {
                if (age <= 0)
                {
                    throw new AgeException();
                }
                else
                {
                    Console.WriteLine("The year you were born was: {0}", (year - age));
                    Console.ReadLine();
                    return;
                }
            }
            catch (AgeException)
            {
                Console.WriteLine("The age you entered is invalid and/or impossible");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {

                Console.WriteLine("An error has occured. Please contact your system admin.");
                Console.ReadLine();
                return;
            }
        }
    }
}
