using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {

        try
        {
            List<int> intList = new List<int>() { 4, 6, 18, 40, 75, 100 };
            Console.WriteLine("Enter a number to divide the list of intigers with");
            int number = Convert.ToInt32(Console.ReadLine());
            foreach (int num in intList)
            {
                int quotient = num / number;
                Console.WriteLine(quotient);
            }

        }
        catch (FormatException)
        {
            Console.WriteLine("Please type a whole number.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Please do not divide by zero");
        }
        Console.WriteLine("The program has exited the try/catch block and continued on");
        Console.ReadLine();
    }
}
