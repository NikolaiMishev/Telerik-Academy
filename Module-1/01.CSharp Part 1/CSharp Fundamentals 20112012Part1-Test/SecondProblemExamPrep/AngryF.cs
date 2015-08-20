using System;

//AngryGPS

class AngryF
{
    static void Main()
    {
        //first 
        long number = long.Parse(Console.ReadLine());

        if (number < 0)
        {
            number = -number;
        }
        int sumEven = 0;
        int sumOdd = 0;
        while (number != 0)
        {


            int digit = (int)(number % 10);
            number /= 10;
            

            if (digit % 2 == 0)
            {
                sumEven += digit;
            }
            else
            {
                sumOdd += digit;
            }
        }
        if (sumEven == sumOdd)
        {
            Console.WriteLine("Strait " + sumEven);
        }
        else if (sumEven > sumOdd)
        {
            Console.WriteLine("Right " + sumEven);
        }
        else if (sumOdd > sumEven)
        {
            Console.WriteLine("Left " + sumOdd);
        }


         /* Other:
          * 
          * 
         string num = Console.ReadLine();
         int sumEven = 0;
         int sumOdd = 0;
         
         for(int i = 0; i<num.length; i++)
         {
         if(num == '-')
         {
         continue;
         }
         int digit = num[i] - '0';
         if (digit % 2 == 0)
            {
                sumEven += digit;
            }
            else
            {
                sumOdd += digit;
            }
         }
         if (sumEven == sumOdd)
         {
             Console.WriteLine("Strait " + sumEven);
         }
         else if (sumEven > sumOdd)
         {
             Console.WriteLine("Right " + sumEven);
         }
         else if (sumOdd > sumEven)
         {
             Console.WriteLine("Left " + sumOdd);
         }
          * */
    }
}
