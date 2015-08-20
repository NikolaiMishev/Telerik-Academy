using System;

class BinarySearch
{
    static void Main()
    {

        Console.Write("Enter N(the lenght of array): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("FIll the array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        
        Console.WriteLine("The number is : {0} :", arr[Array.BinarySearch(arr,k)-1]);
    }
   
}