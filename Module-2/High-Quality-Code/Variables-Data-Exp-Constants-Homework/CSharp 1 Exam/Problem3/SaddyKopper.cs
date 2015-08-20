using System;

public class SaddyKopper
{
    public static void Main()
    {
        /*  SOLUTION IS NOT 100%. BGCODER EVALUATES 50/100 POINTS.
             
             The steps for performing the mathematical transformation follow:
1.	Saddy gets a random positive number from the public
2.	Saddy removes the last digit (the rightmost one) from the number
3.	Saddy then finds all digits at even positions (starting from zero) and finds their sum
4.	Saddy returns again to the step 2 and continues until no digits are left
5.	Saddy then finds the product of all sums found from the current number
6.	Saddy then takes the product as a new number and in this way one transformation occurred
7.	If the new number has only one digit, Saddy stops the magic trick and tells the public how many transformations occurred in total and what is the final resulted number
8.	Else if this is not the 10th transformation in turn, Saddy gets the new number and starts again with it from step 2
9.	If this is the 10th transformation in turn, Saddy stops the magic trick and tells the public the final resulted number
             * 
             •	The number from the public will be between 10,000,000 and 99,999,999,999,999,999
            ------------------------------
             * Example input - 123456789
             * Example output - 3
             *                  9
             */

        string number = Console.ReadLine();
       
        long[] numberInArray = new long[number.Length];

        for (int i = 0; i < number.Length; i++)
        {
            numberInArray[i] = (int)(number[i] - 48);

        }
        long finalOut = 0;
        int iterations = 1;
        long counter = 0;

        while (iterations < 10)
        {
            long sumOfEven = 1;

            for (int i = numberInArray.Length - 1; i >= 0; i--)
            {

                for (int j = 0; j < i; j++)
                {

                    if (j % 2 == 0 || j == 0)
                    {

                        counter += numberInArray[j];
                    }
                }
                if (counter != 0)
                {
                    sumOfEven *= counter;
                }
                counter = 0;
            }
            if (sumOfEven < 10)
            {
                Console.WriteLine(iterations);
                Console.WriteLine(sumOfEven);
                break;
            }
            else  //(sumOfEven>9) 
                finalOut = sumOfEven;
            Console.WriteLine(sumOfEven + " end");
            {
                number = Convert.ToString(sumOfEven);

                numberInArray = new long[number.Length];
                for (int i = 0; i < number.Length; i++)
                {
                    numberInArray[i] = (int)(number[i] - 48);

                }
            }

            iterations++;
        }

        if (iterations == 10)
        {
            Console.WriteLine(finalOut);

        }
    }
}

