//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;
using System.IO;

class PrimeNumbers
{
    static void Main()
    {

        int[] nums = new int[10000001];
        int[] primeNumbers = new int[664579];
        for (int i = 1; i <= 10000000; i++)
        {
            nums[i] = i;
        }
        int k = 0;
        for (int i = 2; i <= 10000000; i++)
        {
            if (nums[i] != 0)
            {
                // Console.Write(nums[i] + " ");
                primeNumbers[k] = i;
                k++;
                for (int j = i + i; j <= 10000000; j += i)
                {
                    nums[j] = 0;
                }
            }
        }
        string fileName = "Prime Numbers.txt";
        string strPath = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory),fileName);

        FileStream fs = new FileStream(strPath, FileMode.OpenOrCreate, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);
        sw.BaseStream.Seek(0, SeekOrigin.End);

        for (int i = 0; i < primeNumbers.Length; i++)
        {
            sw.Write("{0},\n", primeNumbers[i]);
            Console.Write(primeNumbers[i] + ",");
        }



    }
}
