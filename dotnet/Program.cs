using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of strings: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the strings: ");
        string[] initialArray = new string[n];
        for (int i = 0; i < n; i++)
        {
            initialArray[i] = Console.ReadLine();
        }

        List<string> newArray = new List<string>();
        foreach (string str in initialArray)
        {
            if (str.Length <= 3)
            {
                newArray.Add(str);
            }
        }

        Console.WriteLine("New array of strings with length less than or equal to 3 characters: ");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }
}
