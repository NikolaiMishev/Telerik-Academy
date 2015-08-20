//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
//the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.

using System;
using System.Linq;
class MinMaxSumAndAverageOfN
{
    static void Main()
    {
        Console.Write("Enter numbers count: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbersToWorkWith = new int[n];
        int sum = 0;
        Console.WriteLine("Enter {0} numbers on separate lines:",n);
        for (int i = 0; i < n; i++)
        {
         
            numbersToWorkWith[i] = int.Parse(Console.ReadLine());
            sum += numbersToWorkWith[i];

        }
        
        for (int j = 0; j < numbersToWorkWith.Length; j++)
        {
            for (int i = 0; i < numbersToWorkWith.Length-1; i++)
            {
                if (numbersToWorkWith[i] > numbersToWorkWith[i + 1])
                {
                    int temp = 0;
                    temp = numbersToWorkWith[i + 1];
                    numbersToWorkWith[i + 1] = numbersToWorkWith[i];
                    numbersToWorkWith[i] = temp;
                
                }

            }
        }
       double avg = (double)sum/n;
       
        Console.WriteLine("Max:{0}\nMin:{1}\nSum:{2}\nAverage:{3:0.00}", numbersToWorkWith[n - 1], numbersToWorkWith[0], sum, avg);
       
        

       

    }
}