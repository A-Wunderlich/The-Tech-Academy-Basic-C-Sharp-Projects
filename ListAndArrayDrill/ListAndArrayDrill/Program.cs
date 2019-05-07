using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        string[] stringArray = {"Red","Blue","Green","Black"};
        Console.WriteLine("Select a number from 0-3 to select a string from the array");
        int stringSelect = Convert.ToInt32(Console.ReadLine());
        if (stringSelect > 3)
        {
            Console.WriteLine("Please choose a number from 0-3.");
            stringSelect = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringArray[stringSelect]);

        }
        else
        {
            Console.WriteLine(stringArray[stringSelect]);
        }
        int[] intArray = { 0, 200, 1337, 1995, 42 };
        Console.WriteLine("Select a number from 0-4 to select a intiger from the array");
        int intSelect = Convert.ToInt32(Console.ReadLine());
        if (intSelect > 4)
        {
            Console.WriteLine("Please choose a number from 0-4.");
            intSelect = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intArray[intSelect]);

        }
        else
        {
            Console.WriteLine(intArray[intSelect]);
        }
        List<string> stringList = new List<string>() { "Doc", "Grumpy", "Happy", "Sleepy", "Bashful", "Sneezy", "Dopey" };
        Console.WriteLine("Select a number from 0-6 to select a string from the list");
        int stringListSelect = Convert.ToInt32(Console.ReadLine());
        if (stringListSelect > (stringList.Count - 1))
        {
            Console.WriteLine("Please choose a number from 0-6.");
            stringListSelect = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[stringListSelect]);
        }
        else
        {
            Console.WriteLine(stringList[stringListSelect]);
        }
        Console.ReadLine();

    }
}

