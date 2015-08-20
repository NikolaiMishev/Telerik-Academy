using System;

class SortByStringLength
{
    static void Main()
    {

        Console.Write("Enter N(the lenght of array): ");
        int n = int.Parse(Console.ReadLine());

        string[] str = new string[n];
        Console.WriteLine("Fill the string arrays:");
        for (int i = 0; i < n; i++)
        {
            str[i] = Console.ReadLine();
        }
        SortArrayOfStrings(str);

    }
    static void SortArrayOfStrings(string[] str)
    {

        Array.Sort(str, (x, y) => x.Length.CompareTo(y.Length));
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Sorted :");
        Console.ForegroundColor = ConsoleColor.Gray;
        foreach (string op in str)
        {
            Console.WriteLine(op);
        }
    }
}
