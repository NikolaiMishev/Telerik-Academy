namespace _03.Refactor_the_following_loop
{
    using System;

    public class The_Loop
    {
        public static void Loop(int[] numbers, int expectedValue)
        {
            bool isFound = false;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentValue = numbers[i];

                if (currentValue == expectedValue)
                {
                    isFound = true;
                }

                Console.WriteLine(currentValue);
            }

            if (isFound)
            {
                Console.WriteLine("Expexted value is found!");
            }
        }
    }
}
