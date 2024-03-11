// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter the number of strings: ");
//         int n = int.Parse(Console.ReadLine());

//         Console.WriteLine("Enter the strings: ");
//         string[] initialArray = new string[n];
//         for (int i = 0; i < n; i++)
//         {
//             initialArray[i] = Console.ReadLine();
//         }

//         List<string> newArray = new List<string>();
//         foreach (string str in initialArray)
//         {
//             if (str.Length <= 3)
//             {
//                 newArray.Add(str);
//             }
//         }

//         Console.WriteLine("New array of strings with length less than or equal to 3 characters: ");
//         foreach (string str in newArray)
//         {
//             Console.WriteLine(str);
//         }
//     }
// }
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter the number of strings: ");
//         int n = int.Parse(Console.ReadLine());

//         Console.WriteLine("Enter the strings: ");
//         string[] initialArray = new string[n];
//         for (int i = 0; i < n; i++)
//         {
//             initialArray[i] = Console.ReadLine();
//         }

//         int count = 0;
//         foreach (string str in initialArray)
//         {
//             if (str.Length <= 3)
//             {
//                 count++;
//             }
//         }

//         string[] newArray = new string[count];
//         int index = 0;
//         foreach (string str in initialArray)
//         {
//             if (str.Length <= 3)
//             {
//                 newArray[index] = str;
//                 index++;
//             }
//         }

//         Console.WriteLine("New array of strings with length less than or equal to 3 characters: ");
//         foreach (string str in newArray)
//         {
//             Console.WriteLine(str);
//         }
//     }
// }

string[] GetArray(string message)
{
    Console.Write($"{message}: ");
    string text = Console.ReadLine()!;
    string[] array = text.Split(new char[] {' '});
    return array;
}

int ArraySize(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    return count;
}

string[] NewArray(string[] array, int size)
{
    string[] newArray = new string[size];
    int newIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[newIndex] = array[i];
            newIndex++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
}

string[] array = GetArray("Введите произвольные значения через пробел");
Console.WriteLine();
PrintArray(array);
int size = ArraySize(array);
string[] newArray = NewArray(array, size);
PrintArray(newArray);