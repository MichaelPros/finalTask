using System;

class Program
{
    static void Main()
    {
        // Existing array of strings
        string[] initialArray = { "one", "two", "three", "four", "five", "six" };

        // New array to store strings with length less than or equal to 3
        string[] newArray = new string[initialArray.Length];

        int count = 0;
        foreach (string str in initialArray)
        {
            if (str.Length <= 3)
            {
                newArray[count] = str;
                count++;
            }
        }

        // Remove unused elements from newArray
        Array.Resize(ref newArray, count);

        // Print the new array
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }
}