using System;

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

        int count = 0;
        foreach (string str in initialArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] newArray = new string[count];
        int index = 0;
        foreach (string str in initialArray)
        {
            if (str.Length <= 3)
            {
                newArray[index] = str;
                index++;
            }
        }

        Console.WriteLine("New array of strings with length less than or equal to 3 characters: ");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }
}