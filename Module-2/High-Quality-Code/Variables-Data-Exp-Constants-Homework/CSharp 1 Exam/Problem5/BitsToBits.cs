using System;

public class BitsToBits
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string concatenate = string.Empty;
        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            string inputTostring = Convert.ToString(input, 2).PadLeft(30, '0');
            concatenate += inputTostring;
        }
       
        int zerosCount = 0;
        int onesCount = 0;
        int biggestZerosCount = 0;
        int biggestOnesCount = 0;
        for (int i = 0; i < concatenate.Length; i++)
        {
            if (concatenate[i] == '0')
            {
                if (onesCount > biggestOnesCount)
                {
                    biggestOnesCount = onesCount;
                }

                onesCount = 0;
                zerosCount++;
            }
            else if (concatenate[i] == '1')
            {
                if (zerosCount > biggestZerosCount)
                {
                    biggestZerosCount = zerosCount;
                }

                onesCount++; 
                zerosCount = 0;
            }
        }

        int zerosResult = biggestZerosCount > zerosCount ? biggestZerosCount : zerosCount;
        int onesResult = biggestOnesCount > onesCount ? biggestOnesCount : onesCount;

        Console.WriteLine("{0}", zerosResult);
        Console.WriteLine("{0}", onesResult);
    }
}