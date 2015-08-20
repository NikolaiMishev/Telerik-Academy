//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;

class BinarySearch
{
    static void Main()
    {

        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number to seek: ");
        int key = int.Parse(Console.ReadLine());

        Console.WriteLine("Ente {0} numbers to array: ", n);
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
       
        int min = 0;
        int max = arr.Length-1;

        while (max >= min)
        {
            int mid = (min + max) / 2;
            if (arr[mid] < key)
            {
                min = mid + 1;
            }
            else if (arr[mid] > key)
            {
                max = mid - 1;
            }
            else
            {
                Console.WriteLine("The number {0} is found in position {1}", key , mid);
                break;
            }
        }

    }
}