using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        int[] numbers = new int[5];
        int max = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());

        }
        for (int i = 0; i < 3; i++)
        {
            max *= numbers[i];
        }
        int counter = 0;
        Array.Sort(numbers);

        for (int i = 1; i <= max; i++)
        {
            counter = 0;
            for (int j = 0; j < numbers.Length; j++)
            {


                if (i % numbers[j] == 0)
                {
                    counter++;
                }

                if (counter == 3)
                {

                    break;
                }
            }
            if (counter == 3)
            {
                Console.WriteLine(" " + i);
                break;
            }
        }
        
    }
}