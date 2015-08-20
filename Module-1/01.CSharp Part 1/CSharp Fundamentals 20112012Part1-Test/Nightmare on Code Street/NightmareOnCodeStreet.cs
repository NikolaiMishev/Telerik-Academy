using System;

class NightmareOnCodeStreet
{
    static void Main()
    {

        string str = Console.ReadLine();
        char[] array = str.ToCharArray();
        int counter = 0;
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(Char.IsDigit(array[i])&& i % 2 != 0)
            {
                sum += (int)(array[i]-48);
                counter++;
            }
        }
        Console.WriteLine(counter + " " + sum);
    }
}